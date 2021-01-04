using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        HarcosKezelo harcoskezelo;
        public Form1()
        {
            InitializeComponent();

            string strcon = "server=localhost;userid=root;database=cs_harcosok";
            MySqlConnection conn = new MySqlConnection(strcon);
            try
            {
                conn.Open();
                harcoskezelo = new HarcosKezelo(conn);
            }
            catch(Exception)
            {
                if(MessageBox.Show("Nem sikerült csatlakozni az adatbázis kiszolgálóhoz.") == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }

            HarcosListaFrissit();
        }

        private void btnharcosadd_Click(object sender, EventArgs e)
        {
            if(txtharcosnev.Text.Length != 0)
            {
                if (harcoskezelo.HarcosHozzaad(txtharcosnev.Text))
                {
                    HarcosListaFrissit();
                }
                else
                {
                    MessageBox.Show("Ilyen néven már létezik harcos");
                }
            }
        }

        private void btnkepessegad_Click(object sender, EventArgs e)
        {
            if (kepessegnevetextbox.Text.Length != 0 && hasznalocombobox.Text.Length != 0 && leirastextbox.Text.Length != 0)
            {
                harcoskezelo.KepessegHozzaad(kepessegnevetextbox.Text, hasznalocombobox.Text, leirastextbox.Text);
            }
            else
            {
                MessageBox.Show("Tölts ki minden szükséges mezőt!");
            }
        }

        private void HarcosListaFrissit()
        {
            hasznalocombobox.Items.Clear();
            harcosoklistbox.Items.Clear();
            List<string> harcosok = harcoskezelo.OsszesHarcos();
            List<string> harcosokdate = harcoskezelo.OsszesHarcosDatummal();

            for (int i = 0; i < harcosok.Count; i++)
            {
                hasznalocombobox.Items.Add(harcosok[i]);
                harcosoklistbox.Items.Add(harcosokdate[i]);
            }
        }

        private void harcosoklistbox_SelectedValueChanged(object sender, EventArgs e)
        {
            kepessegleirasatextbox.Text = "";
            string[] harcosnev = harcosoklistbox.SelectedItem.ToString().Split(',');
            
            List<string> kepessegek = harcoskezelo.HarcosKepessegei(harcosnev[0]);

            kepessegeklistbox.Items.Clear();

            foreach(string kepesseg in kepessegek)
            {
                kepessegeklistbox.Items.Add(kepesseg);
            }
        }

        private void kepessegeklistbox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (kepessegeklistbox.SelectedItem != null)
            {
                string[] harcosnev = harcosoklistbox.SelectedItem.ToString().Split(',');
                string leiras = harcoskezelo.KepessegLeirasa(kepessegeklistbox.SelectedItem.ToString(), harcosnev[0]);
                kepessegleirasatextbox.Text = leiras;
            }
        }

        private void kepessegtorolbtn_Click(object sender, EventArgs e)
        {
            if(kepessegeklistbox.SelectedIndex == -1)
            {
                MessageBox.Show("nincs kiválasztva képesség");
            }
            else
            {
                string[] harcosnev = harcosoklistbox.SelectedItem.ToString().Split(',');
                harcoskezelo.KepessegTorol(kepessegeklistbox.SelectedItem.ToString(), harcosnev[0]);

                List<string> kepessegek = harcoskezelo.HarcosKepessegei(harcosnev[0]);

                kepessegeklistbox.Items.Clear();

                foreach (string kepesseg in kepessegek)
                {
                    kepessegeklistbox.Items.Add(kepesseg);
                }
            }
        }

        private void leirasmodostbtn_Click(object sender, EventArgs e)
        {
            if (kepessegeklistbox.SelectedIndex == -1)
            {
                MessageBox.Show("nincs kiválasztva képesség");
            }
            else
            {
                string[] harcosnev = harcosoklistbox.SelectedItem.ToString().Split(',');
                harcoskezelo.LeirasModosit(kepessegeklistbox.SelectedItem.ToString(), harcosnev[0], kepessegleirasatextbox.Text);
            }
        }
    }
}
