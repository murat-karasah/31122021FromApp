using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31122021FromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ortalama> olist = new List<Ortalama>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Ortalama o = new Ortalama();
                o.ogrenciId = FakeData.NumberData.GetNumber(100, 10050);
                o.ogrenciAd = FakeData.NameData.GetFirstName();
                o.ogrenciSoyad = FakeData.NameData.GetSurname();
                o.ogrenci1Sinav = FakeData.NumberData.GetNumber(1, 100);
                o.ogrenci2Sinav = FakeData.NumberData.GetNumber(1, 100);
                o.ortalama = o.oortalama();
                
                olist.Add(o);

            }
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            var listele = olist.OrderBy(o => o.ogrenciId).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listele;
            temizle();
        }

        private void temizle()
        {
            txtOgrenciNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txt1Sinav.Clear();
            txt2Sinav.Clear();
            txtOrtalama.Clear();
        }

        private void btnKalanlar_Click(object sender, EventArgs e)
        {
            var kalanlar = olist.Where(o => o.ortalama <= 49).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kalanlar;
            temizle();

        }

        private void btn_Basarili_Click(object sender, EventArgs e)
        {
            var gecenler = olist.Where(o => o.ortalama >= 50).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gecenler;
            temizle();

        }

        int secilenid;
        Ortalama secogr;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secogr = olist.Find(x => secilenid == x.ogrenciId);
            txtOgrenciNo.Text = secogr.ogrenciId.ToString();
            txtAd.Text = secogr.ogrenciAd;
            txtSoyad.Text = secogr.ogrenciSoyad;
            txt1Sinav.Text = secogr.ogrenci1Sinav.ToString();
            txt2Sinav.Text = secogr.ogrenci2Sinav.ToString();
            txtOrtalama.Text = secogr.ortalama.ToString();
            //Ortalama secilen = (Ortalama)dataGridView1.CurrentRow.DataBoundItem;
            //txtOgrenciNo.Text = secilen.ogrenciId.ToString();
            //txtAd.Text = secilen.ogrenciAd;
            //txtSoyad.Text = secilen.ogrenciSoyad;
            //txt1Sinav.Text = secilen.ogrenci1Sinav.ToString();
            //txt2Sinav.Text = secilen.ogrenci2Sinav.ToString();
            //txtOrtalama.Text = secilen.ortalama.ToString();
        }
    }
}
