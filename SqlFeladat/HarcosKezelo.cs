using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    class HarcosKezelo
    {
        MySqlConnection conn;
        public HarcosKezelo(MySqlConnection conn)
        {
            this.conn = conn;
        }

        public bool HarcosHozzaad(string harcosnev)
        {
            string query = $"INSERT INTO harcosok (nev, letrehozas) values ('{harcosnev}', DATE())";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException)
            {
                return false;
            }
            return true;
        }

        public void KepessegHozzaad(string kepessegnev, string harcosnev, string leiras)
        {
            string query = $"INSERT INTO kepessegek (nev, leiras, harcos_id) values ('{kepessegnev}', '{leiras}', " +
                $"(SELECT id FROM harcosok WHERE nev = '{harcosnev}'))";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();
        }

        public List<string> OsszesHarcos()
        {
            List<string> harcosok = new List<string>();
            string query = "SELECT nev FROM harcosok";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                harcosok.Add(rd[0].ToString());
            }
            rd.Close();
            return harcosok;
        }

        public List<string> OsszesHarcosDatummal()
        {
            List<string> harcosok = new List<string>();
            string query = "SELECT nev, letrehozas FROM harcosok";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                harcosok.Add(rd[0].ToString() + ", " + rd[1].ToString());
            }
            rd.Close();
            return harcosok;
        }

        public List<string> HarcosKepessegei(string harcosnev)
        {
            List<string> kepessegek = new List<string>();
            string query = $"SELECT kepessegek.nev from kepessegek, harcosok where kepessegek.harcos_id = harcosok.id AND harcosok.nev = '{harcosnev}'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while(rd.Read())
            {
                kepessegek.Add(rd[0].ToString());
            }
            rd.Close();

            return kepessegek;
        }

        public string KepessegLeirasa(string kepessegnev, string harcosnev)
        {
            string query = $"select kepessegek.leiras from kepessegek, harcosok " +
                $"where kepessegek.harcos_id = harcosok.id and kepessegek.nev = '{kepessegnev}' and harcosok.nev = '{harcosnev}'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            string leiras = rd[0].ToString();

            rd.Close();
            return leiras;
        }

        public void KepessegTorol(string kepessegnev, string harcosnev)
        {
            string query = $"delete from kepessegek where nev = '{kepessegnev}' and harcos_id = (SELECT id FROM harcosok where nev = '{harcosnev}')";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();
        }

        public void LeirasModosit(string kepessegnev, string harcosnev, string leiras)
        {
            string query = $"update kepessegek set leiras = '{leiras}' where nev = '{kepessegnev}' and harcos_id = (SELECT id FROM harcosok where nev = '{harcosnev}')";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();
        }
    }
}
