using North_DbFirst.Models;
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
    public partial class SiparişKendim : Form
    {
        public SiparişKendim()
        {
            InitializeComponent();
        }
        NorthwindContext _dataContext = new NorthwindContext();


        private void SiparişKendim_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }


        private void ListeyiDoldur()
        {
            lstUrunler.DataSource = _dataContext.Products.OrderBy(x => x.ProductName).ToList();

            cmbCalisan.DataSource = _dataContext.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            cmbKargo.DataSource = _dataContext.Shippers.ToList();
            cmbKargo.DisplayMember = "CompanyName";

            cmbMusteri.DataSource = _dataContext.Customers.ToList();
            cmbMusteri.DisplayMember = "CustomerId"; 



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            txtAra.Text = txtAra.Text.ToUpper();
            txtAra.SelectionStart = txtAra.Text.Length;
            for (int i = 0; i < lstUrunler.Items.Count; i++)
            {
                if (lstUrunler.Items[i].ToString().Contains(txtAra.Text))
                {
                    lstUrunler.SetSelected(i, true);
                    if (txtAra.Text=="")
                    {
                        lstUrunler.SetSelected(i, false);
                    }
                }
                else
                {
                    lstUrunler.SetSelected(i, false);
                }

            }
        }
    }
}
