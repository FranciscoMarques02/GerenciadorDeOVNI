﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOvni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Instanciar um objeto da jenela:
            Inicializador janela = new Inicializador();
            // Abrir nova janela:
            janela.ShowDialog();
            // Encerrar o programa quando fechado:
            Application.Exit();
            
        }
    }
}
