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
using PharmaTech.UserControle;


namespace PharmaTech.Forme
{
    public partial class ZaprimanjeLijekova : Form
    {
        List<lijek> lijekovi = null;
        
        public ZaprimanjeLijekova()
        {
            InitializeComponent();
            DohvatiZaposlenike();
            lijekovi = DohvatiSveLijekove();
            txtDobavljac.ReadOnly = true;
            txtSelektiranaNar.ReadOnly = true;
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
        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            uxStavke.Controls.Add(new StavkaPrimke(lijekovi, this));
        }

        private void ZaprimanjeLijekova_Load(object sender, EventArgs e)
        {
            dgvNarudzbenice.DataSource = null;
            DogvatiSveNarudzbenice();
        }
        

        private void DogvatiSveNarudzbenice()
        {
            
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from narudzbenica in context.narudzbenicas
                           join zaposlenik in context.zaposleniks on narudzbenica.id_zaposlenik equals zaposlenik.id_zaposlenik
                           join dobavljac in context.dobavljacs on narudzbenica.id_dobavljac equals dobavljac.id_dobavljac
                           
                           
                           select new
                           {
                               ID_narudzbenice = narudzbenica.id_narudzbenica,
                               Datum = narudzbenica.datum_narudzbe,
                               Zaposlenik = zaposlenik.ime_prezime,
                               Dobavljac = dobavljac.naziv_dobavljaca
                           };

                
                dgvNarudzbenice.DataSource = upit.ToList();
            }
        }


        private void DohvatiStavkeNarudzbenice(int odabrana)
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from stavka_narudzbe in context.stavka_narudzbe
                           join lijek in context.lijeks on stavka_narudzbe.id_lijek equals
                                lijek.id_lijek
                           where stavka_narudzbe.id_narudzbenica == odabrana
                           select new
                           {
                               Lijek = lijek.naziv_lijek,
                               Kolicina = stavka_narudzbe.narucena_kolicina,
                               Cijena = lijek.nabavna_cijena,
                               Ukupna_cijena = (stavka_narudzbe.narucena_kolicina * lijek.nabavna_cijena).ToString()

                           };

                dgvStavkeNar.DataSource = upit.ToList();
            }
        }

        private void dgvNarudzbenice_SelectionChanged_1(object sender, EventArgs e)
        {
            var odabrana = dgvNarudzbenice.CurrentRow.Cells[0].Value;
            DohvatiStavkeNarudzbenice((int)odabrana);
            txtSelektiranaNar.Text = odabrana.ToString();
            var dobavljac = dgvNarudzbenice.CurrentRow.Cells[3].Value;
            txtDobavljac.Text = dobavljac.ToString();
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
                
                using (var context = new PI2256_DBEntities1())
                {
                    var upit = from zaposlenik in context.zaposleniks
                               where zaposlenik.ime_prezime == cbZaposlenik.SelectedItem.ToString()
                               select zaposlenik;
                    idOdabraniZap = upit.FirstOrDefault().id_zaposlenik;


                }
                int brojac = 0;
                int id = 0;


                foreach (StavkaPrimke item in uxStavke.Controls)
                {

                    brojac++;
                    if (brojac == 1)
                    {
                        using (var context = new PI2256_DBEntities1())
                        {
                            var upit = from dobavljac in context.dobavljacs
                                       where dobavljac.naziv_dobavljaca == txtDobavljac.Text
                                       select dobavljac;
                            int idDob = upit.FirstOrDefault().id_dobavljac;

                            int idPrimk = context.skladisna_primka.Count()+2;
                            try
                            {

                                skladisna_primka skladisna_Primka = new skladisna_primka
                                {
                                    id_primka = idPrimk,
                                    datum_zaprimanja = dtpDatum.Value,
                                    id_zaposlenik = idOdabraniZap,
                                    id_dobavljaca = idDob,
                                    id_narudzbenice = int.Parse(txtSelektiranaNar.Text)

                                };

                                id = skladisna_Primka.id_primka;
                                context.skladisna_primka.Add(skladisna_Primka);
                                context.SaveChanges();
                            }
                            catch
                            {
                                MessageBox.Show("Spremanje nije uspjelo.");
                            }
                        }
                    }
                    item.AzurirajLijek(id);

                }

                if (brojac > 0)
                {

                    MessageBox.Show("Lijekovi su ažuriani");
                    using (var context = new PI2256_DBEntities1())
                    {
                        var upit = from stavka_primke in context.stavka_primke
                                   join lijek in context.lijeks on stavka_primke.id_lijek equals lijek.id_lijek
                                   where stavka_primke.id_primka == id
                                   select new
                                   {

                                       Primka_id = stavka_primke.id_primka,
                                       Lijek = lijek.naziv_lijek,
                                       Primljena_kolicina = stavka_primke.primljena_kolicina
                                     



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

        public void Izbrisi(StavkaPrimke odabranaKontrola)
        {
            uxStavke.Controls.Remove(odabranaKontrola);
            odabranaKontrola.Dispose();

        }
    }
}
