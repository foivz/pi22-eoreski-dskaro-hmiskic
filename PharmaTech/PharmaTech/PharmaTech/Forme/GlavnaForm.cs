﻿using System;
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
    public partial class GlavnaForm : Form
    {
        public GlavnaForm()
        {
            InitializeComponent();
        }

        private void btnPregledInventura_Click(object sender, EventArgs e)
        {
            PregledInventura pregledInventura = new PregledInventura();
            pregledInventura.ShowDialog();
        }
    }
}
