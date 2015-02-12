using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Alumnos alumnos = new Alumnos();

        private void bguardar_Click(object sender, EventArgs e)
        {
            Alumno alu = new Alumno();

            alu.Nombre = tnombre.Text;
            alu.Nota = int.Parse(tnota.Text);

            alumnos.AgregarAlumno(alu);

            tnombre.Text = "";
            tnota.Text = "";

            tlista.Text = tlista.Text + alu.mostrardatos() + "\r\n"; 
        }
    }
}
