using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace pryMoralesBiblioteca
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public string[,] matLibros = new string[20, 5];
        public int contador = 0;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            int i = 0;

            StreamReader srLibro = new StreamReader("../../../LIBRO.txt");

            while (!srLibro.EndOfStream)
            {
                string[] vecLibro = srLibro.ReadLine().Split(separador);

                //Borrar el espacio en blanco
                vecLibro[0] = Regex.Replace(vecLibro[0], @"\t", "");
                vecLibro[1] = Regex.Replace(vecLibro[1], @"\t", "");
                vecLibro[2] = Regex.Replace(vecLibro[2], @"\t", "");
                vecLibro[3] = Regex.Replace(vecLibro[3], @"\t", "");
                vecLibro[4] = Regex.Replace(vecLibro[4], @"\t", "");



                if (i < 20)
                {
                    //Uso el vector para cargar la info del libro en las columnas de la matriz
                    matLibros[i, 0] = vecLibro[0];
                    matLibros[i, 1] = vecLibro[1];
                    matLibros[i, 2] = vecLibro[2];
                    matLibros[i, 3] = vecLibro[3];
                    matLibros[i, 4] = vecLibro[4];

                    i++;
                }
                
            }

            srLibro.Close();

            txtNombre.Text = matLibros[0, 0];
            txtCodLibro.Text = matLibros[0, 1];
            txtCodEditorial.Text = matLibros[0, 2];
            txtCodAutor.Text = matLibros[0, 3];
            txtCodDistribuidor.Text = matLibros[0, 4];

            btnAnterior.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            contador++;

            txtNombre.Text = matLibros[contador, 0];
            txtCodLibro.Text = matLibros[contador, 1];
            txtCodEditorial.Text = matLibros[contador, 2];
            txtCodAutor.Text = matLibros[contador, 3];
            txtCodDistribuidor.Text = matLibros[contador, 4];

            btnAnterior.Enabled = true;

            if(contador == matLibros.GetLength(0) - 1) 
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            contador--;

            if (contador <= 0)
            {
                txtNombre.Text = matLibros[contador, 0];
                txtCodLibro.Text = matLibros[contador, 1];
                txtCodEditorial.Text = matLibros[contador, 2];
                txtCodAutor.Text = matLibros[contador, 3];
                txtCodDistribuidor.Text = matLibros[contador, 4];

                if (contador == 0)
                {
                    btnAnterior.Enabled = false;
                }
            }
            else
            {
                btnAnterior.Enabled = false;
            }

        }
    }
}
