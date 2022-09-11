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

namespace PharmaTech.Forme
{
    public partial class RacunIzvjestajForm : Form
    {
        private int selectedRacunId;
        public RacunIzvjestajForm(int racunId)
        {
            InitializeComponent();
            selectedRacunId = racunId;
        }

        private void RacunIzvjestajForm_Load(object sender, EventArgs e)
        {
            using (var context = new PI2256_DBEntities1())
            {
                var queryRacun = from r in context.racuns
                                 where r.id_racuna == selectedRacunId
                                 select r;

                racun jedanRacun = queryRacun.Single();
                racunBindingSource.DataSource = jedanRacun;

                var queryStavke = from s in context.stavka_racuna
                                  where s.id_racun == selectedRacunId
                                  select s;

                List<stavka_racuna> stavkeRacuna = queryStavke.ToList();
                stavkaracunaBindingSource.DataSource = stavkeRacuna;

                var queryLijek = from lijek in context.lijeks
                                 join sr in context.stavka_racuna on lijek.id_lijek equals sr.id_lijek
                                 where sr.id_racun == selectedRacunId
                                 select lijek;

                List<lijek> lijekovi = queryLijek.ToList();
                lijekBindingSource.DataSource = lijekovi;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
