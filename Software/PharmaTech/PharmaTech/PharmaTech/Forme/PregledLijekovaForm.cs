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
    public partial class PregledLijekovaForm : Form
    {
        public PregledLijekovaForm()
        {
            InitializeComponent();
        }

        private void PregledLijekovaForm_Load(object sender, EventArgs e)
        {            
            OsvjeziLijekove();
            PopuniFilter();
            PopuniSort();
        }

        private void OsvjeziLijekove()
        {
            dgvLijekovi.DataSource = null;
            dgvLijekovi.DataSource = PrikaziLijekove();
            dgvLijekovi.Columns["id_lijek"].Visible = false;
            dgvLijekovi.Columns["jedinica_mjere"].Visible = false;
            dgvLijekovi.Columns["rok_trajanja"].Visible = false;
            dgvLijekovi.Columns["nacin_primjene"].Visible = false;
            dgvLijekovi.Columns["nabavna_cijena"].Visible = false;
            dgvLijekovi.Columns["stavka_inventure"].Visible = false;
            dgvLijekovi.Columns["stavka_narudzbe"].Visible = false;
            dgvLijekovi.Columns["stavka_primke"].Visible = false;
            dgvLijekovi.Columns["stavka_racuna"].Visible = false;
        }

        private object PrikaziLijekove()
        {
            using(var context = new PI2256_DBEntities1())
            {
                return context.lijeks.ToList();                         
            }
        }



        private void cmbSortiranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sortiraj();
        }

        private void cmbFiltriranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if(dgvLijekovi.CurrentRow != null)
            {
                lijek odabraniLijek = dgvLijekovi.CurrentRow.DataBoundItem as lijek;
                DetaljiLijekaForm detaljiLijekaForm = new DetaljiLijekaForm(odabraniLijek);
                detaljiLijekaForm.ShowDialog();
            }
        }

        private void btnDodajLijek_Click(object sender, EventArgs e)
        {
            DodajLijekForm dodajLijekForm = new DodajLijekForm();
            dodajLijekForm.ShowDialog();
            OsvjeziLijekove();
        }

        private void btnAzurirajLijek_Click(object sender, EventArgs e)
        {
            if(dgvLijekovi.CurrentRow != null)
            {
                lijek odabraniLijek = dgvLijekovi.CurrentRow.DataBoundItem as lijek;
                AzurirajLijekForm azurirajLijekForm = new AzurirajLijekForm(odabraniLijek);
                azurirajLijekForm.ShowDialog();
                OsvjeziLijekove();
            }
        }

        private void btnIzbrisiLijek_Click(object sender, EventArgs e)
        {
            if(dgvLijekovi.CurrentRow != null)
            {
                lijek odabraniLijek = dgvLijekovi.CurrentRow.DataBoundItem as lijek;
                using (var context = new PI2256_DBEntities1())
                {
                    context.lijeks.Attach(odabraniLijek);
                    context.lijeks.Remove(odabraniLijek);
                    context.SaveChanges();
                }
                OsvjeziLijekove();
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            using(var context = new PI2256_DBEntities1())
            {
                var upit = from lijek in context.lijeks
                           where lijek.naziv_lijek == txtPretraga.Text
                           select lijek;
                dgvLijekovi.DataSource = upit.ToList();
            }
            
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            txtPretraga.Clear();
            OsvjeziLijekove();
        }

        private void PopuniFilter()
        {
            var filteri = new List<string>();
            filteri.Add("Svi lijekovi");
            filteri.Add("Lijekovi na recept");
            filteri.Add("Lijekovi bez recepta");

            cmbFiltriranje.DataSource = filteri;
        }

        private void PopuniSort()
        {
            var sortiranje = new List<string>();
            sortiranje.Add("Zadano");
            sortiranje.Add("Uzlazno");
            sortiranje.Add("Silazno");

            cmbSortiranje.DataSource = sortiranje;
        }
        private void Filtriraj()
        {
            
            if(cmbFiltriranje.SelectedIndex == 1)
            {
                using (var context = new PI2256_DBEntities1())
                {
                    var upit = from lijek in context.lijeks
                               where lijek.potreban_recept == "Da"
                               select lijek;

                    dgvLijekovi.DataSource = upit.ToList();
                }
            }else if(cmbFiltriranje.SelectedIndex == 2)
            {
                using (var context = new PI2256_DBEntities1())
                {
                    var upit = from lijek in context.lijeks
                               where lijek.potreban_recept == "Ne"
                               select lijek;

                    dgvLijekovi.DataSource = upit.ToList();
                }
            }
            else
            {
                OsvjeziLijekove();
            }
        }

        private void Sortiraj()
        {
            if (cmbSortiranje.SelectedIndex == 1)
            {
                using (var context = new PI2256_DBEntities1())
                {
                    var upit = from lijek in context.lijeks
                               orderby lijek.naziv_lijek
                               select lijek;

                    dgvLijekovi.DataSource = upit.ToList();
                }
            }
            else if (cmbSortiranje.SelectedIndex == 2)
            {
                using (var context = new PI2256_DBEntities1())
                {
                    var upit = from lijek in context.lijeks
                               orderby lijek.naziv_lijek descending
                               select lijek;

                    dgvLijekovi.DataSource = upit.ToList();
                }
            }
        }   
    }
}
