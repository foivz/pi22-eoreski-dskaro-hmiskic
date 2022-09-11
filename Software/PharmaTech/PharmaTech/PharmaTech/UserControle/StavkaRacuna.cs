using PharmaTech.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaTech.UserControle
{
    public partial class StavkaRacuna : UserControl
    {
        public double? ukupanZbroj = 0;
        public double? ukupanZbroj2 = 0;
        private List<lijek> Lijekovi = null;
        private KreirajRacun Forma = null;
        public StavkaRacuna(List<lijek> lijekovi, KreirajRacun kreirajForm)
        {
            Lijekovi = lijekovi;
            Forma = kreirajForm;
            InitializeComponent();
        }

        private void uxObrisi_Click(object sender, EventArgs e)
        {
            Forma.Izbrisi(this);
        }

        private void StavkaRacuna_Load(object sender, EventArgs e)
        {
            DohvatiLijekove();
            uxKolicinaNaZalihi.ReadOnly = true;
            uxCijena.ReadOnly = true;
            uxUkupanIznos.ReadOnly = true;
        }

        private void DohvatiLijekove()
        {
            foreach (var item in Lijekovi.OrderBy(x => x.naziv_lijek))
            {
                uxNazivLijeka.Items.Add(item.naziv_lijek);
            }
        }

        private double? KolicinaLijeka(string naziv)
        {
            double? kolicina = Lijekovi.First(x => x.naziv_lijek == naziv).kolicina_na_zalihi;
            return kolicina;
        }

        private double? CijenaLijeka(string naziv)
        {
            double? cijena = Lijekovi.First(x => x.naziv_lijek == naziv).cijena;
            return cijena;
        }

        private void uxNazivLijeka_SelectedIndexChanged(object sender, EventArgs e)
        {
            double? kolicina = KolicinaLijeka(uxNazivLijeka.Text);
            uxKolicinaNaZalihi.Text = kolicina.ToString();

            double? cijena = CijenaLijeka(uxNazivLijeka.Text);
            uxCijena.Text = cijena.ToString();
        }

        private void uxKolicinaKupnje_TextChanged(object sender, EventArgs e)
        {
            if (uxKolicinaKupnje.Text != "")
            {
                if (Int32.Parse(uxKolicinaKupnje.Text) > Int32.Parse(uxKolicinaNaZalihi.Text))
                {
                    MessageBox.Show("Tražena količina veća je od količine na zalihi. Molimo pokušajte ponovno.");
                    uxKolicinaKupnje.Text = "";
                    ukupanZbroj = 0;
                    Forma.IspuniZbroj();
                }
                else
                {
                    uxUkupanIznos.Text = IzracunIznosa().ToString();
                    ukupanZbroj = 0;
                    ukupanZbroj += IzracunIznosa();
                    Forma.IspuniZbroj();
                }
                
            }
            else
            {
                uxUkupanIznos.Text = "";
            }
            
        }

        private double? IzracunIznosa()
        {
            double? cijenaLijeka = Double.Parse(uxCijena.Text);
            int kolicina = Int32.Parse(uxKolicinaKupnje.Text);
            double? ukupanIznosRacuna = kolicina * cijenaLijeka;
            return ukupanIznosRacuna;
        }

        internal void AzurirajLijek(int idRacuna)
        {
            lijek lijek = null;
            lijek = Lijekovi.FirstOrDefault(r => r.naziv_lijek == uxNazivLijeka.Text);
            if (lijek == null || uxKolicinaKupnje.Text == "") return;
            else
            {
                int kolicina = int.Parse(uxKolicinaKupnje.Text);
                int kolicinaZalihe = int.Parse(uxKolicinaNaZalihi.Text) - int.Parse(uxKolicinaKupnje.Text);
                AzurirajKolicunuLijeka(lijek, kolicina, idRacuna, kolicinaZalihe);
            }
        }

        private void AzurirajKolicunuLijeka(lijek lijek, int kolicina, int idRacuna, int kolicinaZalihe)
        {
            using (var context = new PI2256_DBEntities1())
            {

                stavka_racuna stavke_racuna = new stavka_racuna
                {
                    id_lijek = lijek.id_lijek,
                    id_racun = idRacuna,
                    kolicina = kolicina
                };
                context.stavka_racuna.Add(stavke_racuna);
                context.SaveChanges();

                context.lijeks.Attach(lijek);
                lijek.kolicina_na_zalihi = kolicinaZalihe;
                context.SaveChanges();
            }
        }
    }
}
