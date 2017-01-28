using RegistroPelicula.Entidades;
using RegistroPelicula.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroPelicula.UI.Registro
{
    public partial class RegistroCategorias : Form
    {
        public RegistroCategorias()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "";
            DescripcionTextBox.Text = "";
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Categorias categorias = new Categorias(DescripcionTextBox.Text);
                var db = new RegistroDb();
                db.Categorias.Add(categorias);
                db.SaveChanges();
                MessageBox.Show("Guardado");

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RegistroConsultas().Show();
        }
    }
}
