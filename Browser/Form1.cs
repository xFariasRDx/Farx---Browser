using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        List<string> Favorites = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("www.bing.com");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_GoForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Url.Text);
        }

        private void btn_Favorites_Click(object sender, EventArgs e)
        {
            Favorites.Add(webBrowser1.Url.ToString());
            cmb_Actualizar();
        }

        private void cmb_Actualizar()
        {
            foreach (string direccion in Favorites)
            { 
                cmb_Favorites.Items.Add(direccion);
            }
        }

        private void cmb_Favorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmb_Favorites.SelectedItem.ToString());
        }
    }
}
