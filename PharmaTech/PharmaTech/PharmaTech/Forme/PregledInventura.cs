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

namespace PharmaTech
{
    public partial class PregledInventura : Form
    {
        public PregledInventura()
        {
            InitializeComponent();
        }

        private void PregledInventura_Load(object sender, EventArgs e)
        {
            dgvInventure.DataSource = null;
            dgvInventure.DataSource = DogvatiSveInventure();



        }

        private object DogvatiSveInventure()
        {
            
            using (var context = new PI2256_DBEntities())
            {
                var upit = from inventura in context.inventuras
                           join zaposlenik in context.zaposleniks on inventura.id_zaposlenik equals zaposlenik.id_zaposlenik
                           select new
                           {
                               Id_inventure = inventura.id_inventura,
                               Datum_inventure = inventura.datum_pocetka,
                               Zaposlenik = zaposlenik.ime_prezime
                           };

                return upit.ToList();
            }
        }




        private void DohvatiStavkeInventure(int id)
        {
            using (var context = new PI2256_DBEntities())
            {
                var upit = from stavka_inventure in context.stavka_inventure
                           join lijek in context.lijeks on stavka_inventure.id_lijek equals
                                lijek.id_lijek
                           where stavka_inventure.id_inventura == id
                           select new
                           {
                               Lijek = lijek.naziv_lijek,
                               Kolicina_na_zalihi = lijek.kolicina_na_zalihi,
                               Prebrojana_kolicna = stavka_inventure.stvarna_kolicina

                           };

                dgvStavke.DataSource = upit.ToList();
            }
        }

        private void dgvInventure_SelectionChanged_1(object sender, EventArgs e)
        {
            var odabrana = dgvInventure.CurrentRow.Cells[0].Value;
            DohvatiStavkeInventure((int)odabrana);
        }

        private void btnKreirajInventurniList_Click_1(object sender, EventArgs e)
        {
            Form form = new KreirajInventurniList();
            form.ShowDialog();

        }
    }
}
