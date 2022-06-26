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
    public partial class DodajLijekForm : Form
    {
        public DodajLijekForm()
        {
            InitializeComponent();
        }

        private void DodajLijekForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            using (var context = new PI2256_DBEntities1())
            {
                string recept = "Ne";
                if (chcPotrebanRecept.Checked == true)
                {
                    recept = "Da";
                }
                string naziv = txtNazivLijeka.Text;
                string jedinica = txtJedinicaMjere.Text;
                string rok = txtRokTrajanja.Text;
                string nacin = txtNacinPrimjene.Text;
                double cijena = double.Parse(txtCijena.Text);
                double nabavna = double.Parse(txtNabavnaCijena.Text);
                int kolicina = int.Parse(txtKolicinaNaZalihi.Text);

                lijek noviLijek = new lijek
                {
                    naziv_lijek = naziv,
                    jedinica_mjere = jedinica,
                    rok_trajanja = rok,
                    nacin_primjene = nacin,
                    potreban_recept = recept,
                    cijena = cijena,
                    nabavna_cijena = nabavna,
                    kolicina_na_zalihi = kolicina
                };

                context.lijeks.Add(noviLijek);
                context.SaveChanges();
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
