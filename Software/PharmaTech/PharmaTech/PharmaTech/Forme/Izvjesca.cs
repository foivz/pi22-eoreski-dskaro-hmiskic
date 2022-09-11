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
    public partial class Izvjesca : Form
    {
        public Izvjesca()
        {
            InitializeComponent();
        }

        private void Izvjesca_Load(object sender, EventArgs e)
        {
            DohvatiRacune();
            DohvatiLijekove();
            IzracunajZaradu();
            PieChart();
            NajprodavanijiIzracun();
            dgvRacuni.Columns["zaposlenik"].Visible = false;
            dgvRacuni.Columns["stavka_racuna"].Visible = false;
            dgvRacuni.Columns["mbo_kupca"].Visible = false;
        }

        private void NajprodavanijiIzracun()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = (from p in context.stavka_racuna
                            join lijek in context.stavka_racuna on p.id_lijek equals lijek.id_lijek
                            orderby p.kolicina descending
                            select new
                            {
                                p.lijek.naziv_lijek,
                                p.kolicina
                            }).Take(10);

                dgvNajprodavaniji.DataSource = upit.Distinct().ToList();
            }
        }

        private void PieChart()
        {
            chart1.Titles.Add("Grafikon zarada");

            chart1.Series["Zarada"].Points.AddXY("Ukupno",double.Parse(txtUkupnaZarada.Text));
            chart1.Series["Zarada"].Points.AddXY("Mjesečno",double.Parse(txtMjesecnaZarada.Text));
            chart1.Series["Zarada"].Points.AddXY("Tjedno", double.Parse(txtTjednaZarada.Text));
        }

        private void IzracunajZaradu()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from racun in context.racuns
                           select racun.ukupan_iznos;
                
                double total = upit.Sum();
                txtUkupnaZarada.Text = total.ToString();

                double totalMjesec = Math.Round((total / 12),2);
                txtMjesecnaZarada.Text = totalMjesec.ToString();

                double totalTjedan = Math.Round((total / 52), 2);
                txtTjednaZarada.Text = totalTjedan.ToString();
            }
        }

        private void DohvatiLijekove()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from lijek in context.lijeks
                           select new
                           {
                               lijek.naziv_lijek,
                               lijek.kolicina_na_zalihi,
                               lijek.rok_trajanja
                           };

                dgvStanjeZaliha.DataSource = upit.ToList();
            }
        }

        private void DohvatiRacune()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from r in context.racuns
                           select r;

                dgvRacuni.DataSource = upit.ToList();
            }
        }

        private void btnGenerirajIzvjestaj_Click(object sender, EventArgs e)
        {
            racun odabraniRacun = dgvRacuni.CurrentRow.DataBoundItem as racun;
            RacunIzvjestajForm form = new RacunIzvjestajForm(odabraniRacun.id_racuna);
            form.ShowDialog();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
