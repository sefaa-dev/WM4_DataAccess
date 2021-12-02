﻿using North_DbFirst.Models;
using North_DbFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_DbFirst
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }
        NorthwindContext _dbContext = new NorthwindContext();

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstProducts.DataSource = _dbContext.Products.OrderBy(x => x.ProductName).ToList();

            cmbEmployes.DataSource = _dbContext.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            cmbShippers.DataSource = _dbContext.Shippers.ToList();
            cmbShippers.DisplayMember = "CompanyName";
            cmbCustomers.DataSource = _dbContext.Customers.OrderBy(x => x.CompanyName).ToList();
            cmbCustomers.DisplayMember = "CompanyName";
        }

        private List<Product> UrunAra(Func<Product, bool> predicate = null )
        {
            return predicate == null ? _dbContext.Products.OrderBy(x => x.ProductName).ToList() :
                _dbContext.Products.Where(predicate).OrderBy(x => x.ProductName).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string text = txtAra.Text.ToLower();
            lstProducts.DataSource = UrunAra(x => x.ProductName.ToLower().Contains(text));
        }

        private List<SepetViewModel> _sepet = new List<SepetViewModel>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem == null) return;
            var urun = lstProducts.SelectedItem as Product;
            var sepetUrun = _sepet.FirstOrDefault(x => x.Urun.ProductId == urun.ProductId);

            if(sepetUrun == null)
            {
                _sepet.Add(new SepetViewModel
                {
                    Urun = urun,
                    Adet = 1
                });

            }
            else
            {
                sepetUrun.Adet++;
            }
            SepetiDoldur();
        }

        private void SepetiDoldur()
        {
            var toplamFiyat = _sepet.Sum(x => x.AraToplam);
            lbToplam.Text = $"Toplam: {toplamFiyat:c2}";

            lstCard.Columns.Clear();
            lstCard.Items.Clear();
            lstCard.MultiSelect = false;
            lstCard.View = View.Details;
            lstCard.FullRowSelect = true;
            lstCard.Columns.Add("Adet");
            lstCard.Columns.Add("Ürün");
            lstCard.Columns.Add("Ara Toplam");

            foreach(var item in _sepet)
            {
                ListViewItem viewItem = new ListViewItem(item.Adet.ToString());
                viewItem.Tag = item;
                viewItem.SubItems.Add(item.Urun.ProductName);
                viewItem.SubItems.Add($"{item.AraToplam:c2}");
                lstCard.Items.Add(viewItem);
            }
            lstCard.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (lstCard.SelectedItems.Count == 0) return;

            var secili = lstCard.SelectedItems[0].Tag as SepetViewModel;
            if(secili.Adet == 1)
            {
                _sepet.Remove(secili);
            }
            else
            {
                secili.Adet--;
            }
            SepetiDoldur();
        }

        private void btnArttır_Click(object sender, EventArgs e)
        {
            if (lstCard.SelectedItems.Count == 0) return;

            var secili = lstCard.SelectedItems[0].Tag as SepetViewModel;
            secili.Adet++;
            SepetiDoldur();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (!_sepet.Any()) return;

            using (var tran = _dbContext.Database.BeginTransaction())
            {
                var customer = cmbCustomers.SelectedItem as Customer;
                var employee = cmbEmployes.SelectedItem as Employee;
                var shipper = cmbShippers.SelectedItem as Shipper;
                try
                {
                    var order = new Order()
                    {
                        CustomerId = customer?.CustomerId,
                        EmployeeId = employee?.EmployeeId,
                        ShipVia = shipper?.ShipperId,
                        Freight = nFreight?.Value,
                        OrderDate = DateTime.Now,
                        RequiredDate = dtpRDate.Value,
                        ShipAddress = txtShipAdress.Text,
                        ShipCity = txtShipCity.Text,
                        ShipName = txtShipName.Text,
                        ShipPostalCode = txtPostalCode.Text,
                        ShipRegion = txtShipRagion.Text,
                        ShipCountry = txtShipCountry.Text
                    };
                    _dbContext.Orders.Add(order);
                    _dbContext.SaveChanges();

                    foreach (var item in _sepet)
                    {
                        if (item.Urun.ProductId == 1)
                            throw new Exception("Çayi Satmıyoruz");

                        _dbContext.OrderDetails.Add(new OrderDetail
                        {
                            Discount = 0,
                            OrderId = order.OrderId,
                            ProductId = item.Urun.ProductId,
                            Quantity = item.Adet,
                            UnitPrice = item.Urun.UnitPrice.GetValueOrDefault()
                        });
                    }
                    _dbContext.SaveChanges();

                    tran.Commit();
                    MessageBox.Show($"{_sepet.Sum(x => x.AraToplam) + order.Freight:c2} tutarındaki siparişiniz {order.OrderId} nolu siparişiniz başarıyla oluşturulmuştur");
                    _sepet = new List<SepetViewModel>();
                    SepetiDoldur();
                }
                catch (Exception ex)
                {

                    tran.Rollback();
                    MessageBox.Show("Sipariş işleminde bir hata oluştu" + ex.Message);
                    _dbContext = new();
                }
            }
        }
    }
}
