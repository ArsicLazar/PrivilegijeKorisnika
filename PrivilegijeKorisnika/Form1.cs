using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdKorsnikInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrivilegijeKorisnika.Entiteti.KorisnikIS p = s.Load<PrivilegijeKorisnika.Entiteti.KorisnikIS>(1209912431224);

                MessageBox.Show("Jedinstveno korisnicko ime: " + p.JedKorIme + " | Ime korisnika: " + p.Ime + " | Prezime korinska: " + p.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajKorisnika_Click(object sender, EventArgs e)
        {
           try{
                ISession s = DataLayer.GetSession();


                KorisnikIS p = new Entiteti.KorisnikIS();

                //p.Id = 122345543;
                //p.JedKorIme = "ASF5532";
                p.Ime = "Dejan";
                p.ImeRod = "Ivan";
                p.Prezime = "Denic";
                //p.BrKancelarije = 0;
                


                s.Save(p);
                //s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
           }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
           }
        }

        private void cmdInfoProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = s.Load<Profil>(121343472);

                MessageBox.Show(p.BojaPozadine + p.SpisakElGrafInt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Profil p = new Profil();

                p.BojaPozadine = "Zelena";
                p.SpisakElGrafInt = "Adminske kontrole";



                s.Save(p);
                //s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKorGrupa_Click(object sender, EventArgs e)
        {
            try{
                ISession s = DataLayer.GetSession();
                KorisnikIS k1 = s.Load<KorisnikIS>(1209912431224);

                foreach (GrupaKorisnika g1 in k1.Grupe) {
                    MessageBox.Show(g1.Id);
                }

                GrupaKorisnika g2 = s.Load<GrupaKorisnika>("Phoenix");
                foreach (KorisnikIS k2 in g2.Korisnik) {
                    MessageBox.Show(k2.Ime + " " + k2.Prezime);
                }

                s.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGrupaProfil_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                GrupaKorisnika g1 = s.Load<GrupaKorisnika>("Phoenix");
                foreach (Profil p1 in g1.GrupaProfil)
                {
                    MessageBox.Show(p1.Id.ToString());
                }

                Profil p2 = s.Load<Profil>("1456278");
                foreach (GrupaKorisnika g2 in p2.ProfilGrupa)
                {
                    MessageBox.Show(g2.Id);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdNePokPri_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.GetSession();

                NeuspeliPokusajPrijave n = s.Load<NeuspeliPokusajPrijave>("Netfiber2332");
                MessageBox.Show(n.KorNalog);


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSistemProv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SistemProvere sp = s.Load<SistemProvere>("DanMan23");
                MessageBox.Show(sp.SifraZadPutProm);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPrivilegije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Privilegije p = s.Load<Privilegije>(1);
                MessageBox.Show(p.Ime);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdInfoGrupa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaKorisnika g = s.Load<GrupaKorisnika>("ComLink");
                MessageBox.Show("Sifra grupe: " + g.SifraGrupe);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEmailAdr_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EmailAresa g = s.Load<EmailAresa>(0901993568321);
                while(g.Id != 0)
                MessageBox.Show(g.Email);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
