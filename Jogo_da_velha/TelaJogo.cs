﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Jogo_da_velha
{
    public partial class TelaJogo : Form
    {
        Thread NavegaTela;
        public TelaJogo()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            NavegaTela = new Thread(AbrirJanela);
            NavegaTela.SetApartmentState(ApartmentState.STA);
            NavegaTela.Start();
        }

        public void AbrirJanela(object obj)
        {
            Application.Run(new TelaInicio());
        }
    }
}