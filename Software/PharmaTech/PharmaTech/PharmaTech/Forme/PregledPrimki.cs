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
    public partial class PregledPrimki : Form
    {
        public PregledPrimki()
        {
            InitializeComponent();
        }

        private void btnKreirajPrimku_Click(object sender, EventArgs e)
        {
            ZaprimanjeLijekova form = new ZaprimanjeLijekova();
            form.ShowDialog();
            DogvatiSvePrimke();
        }

        private void DogvatiSvePrimke()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from skladisna_primka in context.skladisna_primka
                           join zaposlenik in context.zaposleniks on skladisna_primka.id_zaposlenik equals zaposlenik.id_zaposlenik
                           join dobavljac in context.dobavljacs on skladisna_primka.id_dobavljaca equals dobavljac.id_dobavljac
                           select new
                           {
                               Id_primke = skladisna_primka.id_primka,
                               Datum = skladisna_primka.datum_zaprimanja,
                               Zaprimio = zaposlenik.ime_prezime,
                               Dobavljac = dobavljac.naziv_dobavljaca
                           };


                dgvPrimki.DataSource = upit.ToList();
            }
        }

        
        private void DohvatiStavkePrimke(int id)
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from stavka_primke in context.stavka_primke
                           join lijek in context.lijeks on stavka_primke.id_lijek equals
                                lijek.id_lijek
                           where stavka_primke.id_primka == id
                           select new
                           {
                               Lijek = lijek.naziv_lijek,
                               Primljena_kolicna = stavka_primke.primljena_kolicina

                           };

                dgvStavke.DataSource = upit.ToList();
            }
        }

        private void btnZatvori_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void PregledPrimki_Load(object sender, EventArgs e)
        {
            dgvPrimki.DataSource = null;
            DogvatiSvePrimke();
        }

        private void dgvPrimki_SelectionChanged(object sender, EventArgs e)
        {
            var odabrana = dgvPrimki.CurrentRow.Cells[0].Value;
            DohvatiStavkePrimke((int)odabrana);
        }
    }
}
