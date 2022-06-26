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
    public partial class DetaljiLijekaForm : Form
    {
        lijek odabraniLijek;
        public DetaljiLijekaForm(lijek lijek)
        {
            InitializeComponent();
            odabraniLijek = lijek;
        }

        private void DetaljiLijekaForm_Load(object sender, EventArgs e)
        {

            using(var context = new PI2256_DBEntities1())
            {
                txtIdLijeka.Text = odabraniLijek.id_lijek.ToString();
                txtNazivLijeka.Text = odabraniLijek.naziv_lijek;
                txtJedinicaMjere.Text = odabraniLijek.jedinica_mjere;
                txtRokTrajanja.Text = odabraniLijek.rok_trajanja;
                txtNacinPrimjene.Text = odabraniLijek.nacin_primjene;
                txtPotrebanRecept.Text = odabraniLijek.potreban_recept;
                txtCijena.Text = odabraniLijek.cijena.ToString();
                txtNabavnaCijena.Text = odabraniLijek.nabavna_cijena.ToString();
                txtKolicinaNaZalihi.Text = odabraniLijek.kolicina_na_zalihi.ToString();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
