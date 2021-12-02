using Nort_DbFront.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nort_DbFront
{
    public partial class KategoryForm : Form
    {
        public KategoryForm()
        {
            InitializeComponent();
        }
        NorthwindContext _dbContext = new NorthwindContext();
        private void KategoryForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }
        Category _selectedCategory;
        private void ListeyiDoldur()
        {
            lstCategory.DataSource = _dbContext.Categories.ToList();
            lstCategory.DisplayMember = "CategoryName";
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItem == null) return;
            _selectedCategory = (Category)lstCategory.SelectedItem;

            txtKategoryName.Text = _selectedCategory.CategoryName;
            txtDescription.Text = _selectedCategory.Description;
        }

        private void btnKaydet_Click(object sender, EventArgs e)   
        {
            try
            {
                var yeni = new Category
                {
                    CategoryName = txtKategoryName.Text,
                    Description = txtDescription.Text,
                };
                _dbContext.Categories.Add(yeni);

                int result = _dbContext.SaveChanges();
                ListeyiDoldur();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
