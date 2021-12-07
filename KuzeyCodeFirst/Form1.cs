using KuzeyCodeFirst.Data;
using KuzeyCodeFirst.Models;
using KuzeyCodeFirst.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KuzeyCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private KuzeyContext _dbContext = new KuzeyContext();
        private KategoriRepo _kategoriRepo = new KategoriRepo();
        private SiparisRepo _siparisRepo = new SiparisRepo();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //_dbContext.Kategoriler.Add(new Kategori()
            //{
            //    Ad = "Kategori",
            //    Aciklama = "açıklama"
            //});
            //_dbContext.SaveChanges();

            var kategori = new Kategori()
            {
                Ad = "Kategori",
                Aciklama = "açıklama"
            };
            _kategoriRepo.Add(kategori);
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var kategori = _dbContext.Kategoriler.First();
            kategori.Aciklama = "Güncel Açıklama";
            _dbContext.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kategori = _dbContext.Kategoriler.First();
            _dbContext.Kategoriler.Remove(kategori);
            _dbContext.SaveChanges();
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
