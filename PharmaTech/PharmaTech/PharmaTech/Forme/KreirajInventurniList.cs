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
    public partial class KreirajInventurniList : Form
    {
        List<lijek> lijekovi = null;
        public KreirajInventurniList()
        {
            InitializeComponent();
            lijekovi = DohvatiSveLijekove();
        }

        private List<lijek> DohvatiSveLijekove()
        {
            using (var context = new PI2256_DBEntities())
            {
                return context.lijeks.ToList();
            }
        }

        private void KreirajInventurniList_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            uxStavke.Controls.Add(new StavkaInventure(lijekovi, this));

        }
    }
}
