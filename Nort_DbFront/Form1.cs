using Microsoft.EntityFrameworkCore;
using Nort_DbFront.Models;
using Nort_DbFront.ViewModels;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private NorthwindContext _dContext = new NorthwindContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            var query1 = _dContext.Categories.Select(x=> new CategoryViewModel()
            {                
                CategoryName = x.CategoryName,
                Description = x.Description,
                Picture = x.Picture,
                ProductCount = x.Products.Count
            }).ToList();

            dgvNorth.DataSource = query1;

            var query2 = from cat in _dContext.Categories
                         join prod in _dContext.Products on cat.CategoryId equals prod.CategoryId
                         //where prod.UnitPrice > 20
                         select new
                         { 
                             cat.CategoryName,
                             prod.ProductName,
                             prod.UnitPrice
                         };
            dgvNorth.DataSource = query2.OrderBy(x => x.CategoryName).ThenByDescending(x => x.UnitPrice).ToList();

            var query3 = _dContext.Products.Select(x => new
            {
                x.Category.CategoryName,
                x.ProductName,
                x.UnitPrice


            }).OrderBy(x => x.CategoryName).ThenByDescending(x => x.UnitPrice).ToList();
            dgvNorth.DataSource = query3;

            var query4 = _dContext.Products
                .Include(x=>x.Supplier)
                .Include(x=>x.Category)
                .Select(x => new
            {
                x.ProductName,
                x.UnitPrice,
                x.Supplier.CompanyName,
                x.Category.CategoryName
            }).ToList();

            var query5 = _dContext.Products
                .Include(x => x.Supplier)
                .Include(x => x.Category)
                .Include(x => x.OrderDetails)
                .ThenInclude(x=>x.Order)
                //.Select(x => new
                //{
                //    x.ProductName,
                //    x.Category.CategoryName,
                //    x.Supplier.CompanyName,
                //    x.OrderDetails.Count,
                
                //})
                .ToList();

            RaporuGoster();
            Console.WriteLine();
        }
        private int _offset = 0, _pageSize = 10,_maxPage = 0;

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (_offset + 1 == _maxPage) return;
            _offset++;
            RaporuGoster();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (_offset == 0) return;
            _offset--;
            RaporuGoster();   
            

            
        }
        private void RaporuGoster()
        {
            label1.Text = $"{_offset + 1}";
            var query = _dContext.Products
               .Include(x => x.Category)
               .Include(x => x.Supplier)
               .Select(x => new
               {
                   x.Category.CategoryName,
                   x.ProductName,
                   x.UnitPrice,
                   x.Supplier.CompanyName

               });
            if (_maxPage == 0)
            {
                _maxPage = (int)Math.Ceiling (query.Count()/Convert.ToDouble(_pageSize));
            }

                var result = query
               .OrderBy(x => x.CategoryName)
               .Skip(_offset * _pageSize)
               .Take(_pageSize)
               .ToList();
            dgvNorth.DataSource = result;
        }
    }
}
