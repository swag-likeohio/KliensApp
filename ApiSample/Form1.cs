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

        public Form1()
        {
            InitializeComponent();

            var url = string.Empty;
            var key = string.Empty;

            if (url == string.Empty) url = "http://20.234.113.211:8101/";
            if (key == string.Empty) key = "1-cc3cd448-3f46-40e8-9159-3907be066ba6";
            
            var proxy = new Api(url, key);

            var snaps = proxy.ProductsFindAll();

            List<string> termekek = new List<string>();

            if (snaps.Content != null)
            {

                for (var i = 0; i < 100; i++)
                {
                    if (i < snaps.Content.Count)
                    {
                        string nev = snaps.Content[i].ProductName;
                        decimal ar = snaps.Content[i].SitePrice;

                        

                        termekek.Add(nev);
                        

                        
                    }
                }

                listBox1.DataSource = termekek.ToList();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
