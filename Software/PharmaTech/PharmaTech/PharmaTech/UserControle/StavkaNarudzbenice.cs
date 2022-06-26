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
    public partial class StavkaNarudzbenice : UserControl
    {
        private List<lijek> Lijekovi = null;
        private KreirajNarudzbenicucs Forma = null;
        public StavkaNarudzbenice(List<lijek> lijekovi,KreirajNarudzbenicucs kreirajForm)
        {
            InitializeComponent();
            Lijekovi = lijekovi;
            Forma = kreirajForm;
        }
        private void DohvatiLijekove()
        {
            foreach (var item in Lijekovi.OrderBy(x => x.naziv_lijek))
            {
                uxNazivLijeka.Items.Add(item.naziv_lijek);
            }
        }


        private void uxIzbrisi_Click(object sender, EventArgs e)
        {
            Forma.Izbrisi(this);
        }

        private void StavkaNarudzbenice_Load(object sender, EventArgs e)
        {
            DohvatiLijekove();
            uxCijena.ReadOnly = true;
        }
        private double? CijenaLijeka(string naziv)
        {
            double? kolicina = Lijekovi.First(x => x.naziv_lijek == naziv).nabavna_cijena;
            return kolicina;
        }
     
        private void uxNazivLijeka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            uxKolicina.Text = "";
            double? cijena = CijenaLijeka(uxNazivLijeka.Text);
            uxCijena.Text = cijena.ToString();
            uxKolicina.BackColor = System.Drawing.Color.AntiqueWhite;

        }
        public void NapraviStavku(lijek lijek, int kolicina, int idNarudzbenice)
        {
            using (var context = new PI2256_DBEntities1())
            {

                stavka_narudzbe stavka_Narudzbe = new stavka_narudzbe
                {
                    id_lijek = lijek.id_lijek,
                    id_narudzbenica = idNarudzbenice,
                    narucena_kolicina = kolicina


                };
                context.stavka_narudzbe.Add(stavka_Narudzbe);
                context.SaveChanges();

                
            }
        }

        public void Azuriraj(int idNarudzbenice)
        {
            lijek lijek = null;
            lijek = Lijekovi.FirstOrDefault(r => r.naziv_lijek == uxNazivLijeka.Text);
            if (lijek == null || uxKolicina.Text == "") return;
            else
            {
                int kolicina = int.Parse(uxKolicina.Text);
                NapraviStavku(lijek, kolicina, idNarudzbenice);
            }
        }
    }
}
