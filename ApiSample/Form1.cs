using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;

namespace ApiSample
{
    public partial class Form1 : Form
    {
        List<string> termekek = new List<string>();
        List<decimal> arak = new List<decimal>();
        //Termekek uj = new Termekek();

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

                for (var i = 0; i < 100; i++)
                {
                    if (i < snaps.Content.Count)
                    {
                        string nev = snaps.Content[i].ProductName;
                        decimal ar = snaps.Content[i].SitePrice;

                        termekek.Add(nev);
                        arak.Add(ar);

                        

                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = uj;
            listBox1.DataSource = termekek;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valasztotttermek = listBox1.SelectedIndex;

            string megjelenik = Math.Round(arak[valasztotttermek]).ToString();

            textBox1.Text = megjelenik + " Ft";
        }
    }
}
