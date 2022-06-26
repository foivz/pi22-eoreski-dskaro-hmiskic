using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaTech.Forme;

namespace PharmaTech.UserControle
{
    public partial class StavkaInventure : UserControl
    {
        private List<lijek> Lijekovi = null;
        private KreirajInventurniList Forma = null;
        public StavkaInventure(List<lijek> lijekovi, KreirajInventurniList kreirajForm)
        {
            Lijekovi = lijekovi;
            Forma = kreirajForm;
            InitializeComponent();
        }


        private void StavkaInventure_Load(object sender, EventArgs e)
        {
            DohvatiLijekove();
            uxKolicinaNaZalihi.ReadOnly = true;
            uxRazlika.ReadOnly = true;
            uxStvarnaKolicina.ReadOnly = true;

        }


        private void DohvatiLijekove()
        {
            foreach (var item in Lijekovi.OrderBy(x => x.naziv_lijek))
            {
                uxNazivLijeka.Items.Add(item.naziv_lijek);
            }
        }


        public double Razlika(string stvarnaKolicina, string stanjeNaZalihi)
        {
            stanjeNaZalihi = stanjeNaZalihi.Replace(".", ",");
            double razlika;
            if (stanjeNaZalihi != "")
            {
                razlika = double.Parse(stvarnaKolicina) - double.Parse(stanjeNaZalihi);
                return razlika;
            }
            else
                return 0;

        }

        
        private double? KolicinaLijeka(string naziv)
        {
            double? kolicina = Lijekovi.First(x => x.naziv_lijek == naziv).kolicina_na_zalihi;
            return kolicina;
        }

      
        private void uxStvarnaKolicina_TextChanged(object sender, EventArgs e)
        {
            double razlika = 0;
            try
            {
                razlika = Razlika(uxKolicinaNaZalihi.Text, uxStvarnaKolicina.Text);
            }
            catch
            {
                MessageBox.Show("Unešena vrijednost mora biti broj");
                uxRazlika.Text = "0";
                uxStvarnaKolicina.Clear();
            }

            if (uxStvarnaKolicina.Text != "")
            {
                uxStvarnaKolicina.BackColor = SystemColors.Window;
                if (razlika > 0)
                {
                    uxRazlika.Text = razlika.ToString();
                    uxRazlika.BackColor = System.Drawing.Color.Red;
                }
                else if (razlika < 0)
                {
                    uxRazlika.Text = Math.Abs(razlika).ToString();
                    uxRazlika.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    uxRazlika.Text = razlika.ToString();
                    uxRazlika.BackColor = System.Drawing.Color.DarkSeaGreen;
                }
            }
            else
            {
                uxRazlika.BackColor = SystemColors.Control;
                uxStvarnaKolicina.BackColor = System.Drawing.Color.LightGray;
            }

        }

        private void uxNazivLijeka_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxStvarnaKolicina.Text = "";
            uxRazlika.Text = "0";
            double? kolicina = KolicinaLijeka(uxNazivLijeka.Text);
            uxKolicinaNaZalihi.Text = kolicina.ToString();
            uxStvarnaKolicina.ReadOnly = false;
            uxStvarnaKolicina.BackColor = System.Drawing.Color.AntiqueWhite;
        }
        public void AzurirajKolicunuLijeka(lijek lijek, int kolicina, int idInventure)
        {
            using (var context = new PI2256_DBEntities1())
            {

                stavka_inventure stavke_Inventure = new stavka_inventure
                {
                    id_lijek = lijek.id_lijek,
                    id_inventura = idInventure,
                    stvarna_kolicina = kolicina
                    

                };
                context.stavka_inventure.Add(stavke_Inventure);
                context.SaveChanges();

                context.lijeks.Attach(lijek);
                lijek.kolicina_na_zalihi = kolicina;
                context.SaveChanges();
            }
        }


        public void AzurirajLijek(int idInventure)
        {
            lijek lijek = null;
            lijek = Lijekovi.FirstOrDefault(r => r.naziv_lijek == uxNazivLijeka.Text);
            if (lijek == null || uxStvarnaKolicina.Text == "") return;
            else
            {
                int kolicina = int.Parse(uxStvarnaKolicina.Text.Replace(".", ","));
                AzurirajKolicunuLijeka(lijek, kolicina, idInventure);
            }
        }

        private void uxIzbrisi_Click(object sender, EventArgs e)
        {
            Forma.Izbrisi(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uxRazlika_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxKolicinaNaZalihi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
