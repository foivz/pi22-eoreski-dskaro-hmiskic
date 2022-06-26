using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaTech.UserControle;

namespace PharmaTech.Forme
{
    public partial class KreirajNarudzbenicucs : Form
    {
        List<lijek> lijekovi = null;
        public KreirajNarudzbenicucs()
        {
            InitializeComponent();
            DohvatiDobavljace();
            lijekovi = DohvatiSveLijekove();
            DohvatiZaposlenike();
        }

        
        private List<lijek> DohvatiSveLijekove()
        {
            using (var context = new PI2256_DBEntities1())
            {
                return context.lijeks.ToList();
            }
        }
        private void DohvatiZaposlenike()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from zaposlenik in context.zaposleniks
                           select zaposlenik.ime_prezime;
                cbZaposlenik.DataSource = upit.ToList();

            }


        }
        private void DohvatiDobavljace()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from dobavljac in context.dobavljacs
                           select dobavljac.naziv_dobavljaca;
                cbDobavljac.DataSource = upit.ToList();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            uxStavke.Controls.Add(new StavkaNarudzbenice(lijekovi, this));
        }

        public void Izbrisi(StavkaNarudzbenice odabranaKontrola)
        {
            uxStavke.Controls.Remove(odabranaKontrola);
            odabranaKontrola.Dispose();

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Želite li spremiti stavke?", "Spremanje", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                int idOdabraniZap;
                int idOdabraniDob;
                using (var context = new PI2256_DBEntities1())
                {
                    var upit = from zaposlenik in context.zaposleniks
                               where zaposlenik.ime_prezime == cbZaposlenik.SelectedItem.ToString()
                               select zaposlenik;
                    idOdabraniZap = upit.FirstOrDefault().id_zaposlenik;

                    var upit2 = from dobavljac in context.dobavljacs
                                where dobavljac.naziv_dobavljaca == cbDobavljac.SelectedItem.ToString()
                                select dobavljac;

                    idOdabraniDob = upit2.FirstOrDefault().id_dobavljac;


                }
                int brojac = 0;
                int id = 0;


                foreach (StavkaNarudzbenice item in uxStavke.Controls)
                {

                    brojac++;
                    if (brojac == 1)
                    {
                        using (var context = new PI2256_DBEntities1())
                        {
                            int idNar = context.narudzbenicas.Count() + 1;
                            try
                            {

                                narudzbenica narudzbenica = new narudzbenica
                                {
                                    id_narudzbenica = idNar,
                                    datum_narudzbe = dtpDatum.Value,
                                    id_zaposlenik = idOdabraniZap,
                                    id_dobavljac = idOdabraniDob

                                };

                                id = narudzbenica.id_narudzbenica;
                                context.narudzbenicas.Add(narudzbenica);
                                context.SaveChanges();
                            }
                            catch
                            {
                                MessageBox.Show("Spremanje nije uspjelo.");
                            }
                        }
                    }
                    item.Azuriraj(id); 

                }

                if (brojac > 0)
                {

                    MessageBox.Show("Lijekovi su ažuriani");
                    using (var context = new PI2256_DBEntities1())
                    {
                        var upit = from stavka_narudzbe in context.stavka_narudzbe
                                   join lijek in context.lijeks on stavka_narudzbe.id_lijek equals lijek.id_lijek
                                   where stavka_narudzbe.id_narudzbenica == id
                                   select new
                                   {

                                       Narudzbenica_id = stavka_narudzbe.id_narudzbenica,
                                       Lijek = lijek.naziv_lijek,
                                       Kolicina = stavka_narudzbe.narucena_kolicina,
                                       Cijena = lijek.nabavna_cijena,
                                       Ukupna_cijena = Math.Abs(stavka_narudzbe.narucena_kolicina * lijek.nabavna_cijena)



                                   };
                        dgvStavke.DataSource = upit.ToList();

                    }


                }
                else
                {
                    MessageBox.Show("Niste dodali ni jedan lijek!");
                }

            }
            else if (dialog == DialogResult.No)
            {
                var uc = uxStavke.Controls.OfType<StavkaInventure>().ToList();
                foreach (var item in uc)
                {
                    uxStavke.Controls.Remove(item);
                    item.Dispose();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvStavke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uxStavke_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
