using PharmaTech.UserControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaTech.Forme
{
    public partial class KreirajRacun : Form
    {

        private GlavnaForm glavnaForm;
        List<lijek> lijekovi = null;
        public KreirajRacun(GlavnaForm form)
        {
            InitializeComponent();
            glavnaForm = form;
            lijekovi = DohvatiSveLijekove();
        }

        private List<lijek> DohvatiSveLijekove()
        {
            using (var context = new PI2256_DBEntities1())
            {
                return context.lijeks.ToList();
            }
        }

        private void KreirajRacun_Load(object sender, EventArgs e)
        {
            btnDodajStavku.Enabled = true;
            btnSpremiStavke.Enabled = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            uxStavke.Controls.Add(new StavkaRacuna(lijekovi, this));
        }

        public void Izbrisi(StavkaRacuna odabranaKontrola)
        {
            uxStavke.Controls.Remove(odabranaKontrola);
            odabranaKontrola.Dispose();
            IspuniZbroj();
        }

        int brojac = 0;
        int id = 0;

        private void btnSpremiStavke_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Želite li spremiti stavke?", "Spremanje", MessageBoxButtons.YesNo);
            string kor_ime = glavnaForm.kor_ime.ToString();

            if (dialog == DialogResult.Yes)
            {
                foreach (StavkaRacuna item in uxStavke.Controls)
                {

                    brojac++;
                    if (brojac == 1)
                    {
                        using (var context = new PI2256_DBEntities1())
                        {
                            int idRacuna = context.racuns.Count() + 2;

                            var upit = from zaposlenik in context.zaposleniks
                                       where zaposlenik.korisnicko_ime == kor_ime
                                       select zaposlenik.id_zaposlenik;
                            int idZaposlenika = upit.FirstOrDefault();
                            double ukupnaCijena = double.Parse(txtUkupnaCijena.Text);

                            try
                            {
                                racun rac = new racun
                                {
                                    id_racuna = idRacuna,
                                    datum_izdavanja = DateTime.Now.Date,
                                    id_zaposlenik = idZaposlenika,
                                    ukupan_iznos = ukupnaCijena,
                                    mbo_kupca = idRacuna
                                };

                                id = rac.id_racuna;
                                context.racuns.Add(rac);
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
                        var upit = from stavka_racuna in context.stavka_racuna
                                   join lijek in context.lijeks on stavka_racuna.id_lijek equals lijek.id_lijek
                                   where stavka_racuna.id_racun == id
                                   select new
                                   {
                                       Racun_id = stavka_racuna.id_racun,
                                       Lijek = lijek.naziv_lijek,
                                       Kupljena_kolicina = stavka_racuna.kolicina,
                                       Jedinicna_cijena = lijek.cijena,
                                       Ukupan_iznos = lijek.cijena*stavka_racuna.kolicina
                                   };
                        dgvStavke.DataSource = upit.ToList();

                    }

                    var uc = uxStavke.Controls.OfType<StavkaRacuna>().ToList();
                    foreach (var item in uc)
                    {
                        uxStavke.Controls.Remove(item);
                        item.Dispose();
                    }

                    btnSpremiStavke.Enabled = false;
                    btnDodajStavku.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Niste dodali ni jedan lijek!");
                }

            }
            else if (dialog == DialogResult.No)
            {
                var uc = uxStavke.Controls.OfType<StavkaRacuna>().ToList();
                foreach (var item in uc)
                {
                    uxStavke.Controls.Remove(item);
                    item.Dispose();
                }
                txtUkupnaCijena.Text = "";
            }
        }
        public void IspuniZbroj()
        {
            double? iznos = 0;
            foreach (StavkaRacuna item in uxStavke.Controls)
            {
                iznos += item.ukupanZbroj;
            }
            txtUkupnaCijena.Text = iznos.ToString();
        }

    }
}
