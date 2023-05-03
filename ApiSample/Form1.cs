using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;

namespace ApiSample
{
    public partial class Form1 : Form
    {
        List<ProductDTO> termekek = new List<ProductDTO>();

        ProductDTO uj = new ProductDTO();

        public Form1()
        {
            InitializeComponent();

            var url = string.Empty;
            var key = string.Empty;

            if (url == string.Empty) url = "http://20.234.113.211:8101/";
            if (key == string.Empty) key = "1-cc3cd448-3f46-40e8-9159-3907be066ba6";

            var proxy = new Api(url, key);

            var snaps = proxy.ProductsFindAll();

            if (snaps.Content != null)
            {

                for (var i = 0; i < 300; i++)
                {
                    if (i < snaps.Content.Count)
                    {
                        string nev = snaps.Content[i].ProductName;
                        decimal ar = snaps.Content[i].SitePrice;
                        string bvin = snaps.Content[i].Bvin;

                        ProductDTO termek = new ProductDTO();

                        termek.ProductName = nev;
                        termek.SitePrice = Math.Round(ar);
                        termek.Bvin = bvin;
                        

                        termekek.Add(termek);

                        

                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = termekek.ToList();

            
        }

       

     
        private void button2_Click_1(object sender, EventArgs e)
        {
            var url = string.Empty;
            var key = string.Empty;

            if (url == string.Empty) url = "http://20.234.113.211:8101/";
            if (key == string.Empty) key = "1-cc3cd448-3f46-40e8-9159-3907be066ba6";

            Api proxy = new Api(url, key);

            var ujar = textBox1.Text;

            var index = dataGridView1.CurrentRow.Index;

            ProductDTO aktualis = termekek[index];

            aktualis.SitePrice = Decimal.Parse(ujar);

            var id = aktualis.Bvin;

            var kell = proxy.ProductsFind(id).Content;

            kell.SitePrice = aktualis.SitePrice;

            ApiResponse<ProductDTO> valtozas = proxy.ProductsUpdate(kell);

            MessageBox.Show("Sikeres mentés!");


        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckUjAr(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Érvénytelen ár");
            }
        }

        private bool CheckUjAr(string beirt)
        {
           
                return beirt.All(char.IsDigit);
            
        }
    }
}
