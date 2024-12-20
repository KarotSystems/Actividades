﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGestionLib_Click(object sender, EventArgs e)
        {
            this.Hide();
            Libreria agregarLibro = new Libreria();
            agregarLibro.Show();
        }

        private void btnPretamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos pres = new Prestamos();
            pres.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
