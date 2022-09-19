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

namespace pryMoralesBiblioteca
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public string[,] matLibros = new string[21, 5];
        public int contSigiente = 0;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");

            StreamReader srLibro = new StreamReader("../../../LIBRO.txt");

            while (!srLibro.EndOfStream)
            {

                for (int i = 0; i <= matLibros.GetLength(0); i++)
                {

                    //Guardar la informacion de cada libro en el vector
                    string[] vecLibro = srLibro.ReadLine().Split(separador);

                    //Uso el vector para cargar la info del libro en las columnas de la matriz
                    matLibros[i, 0] = vecLibro[0];
                    matLibros[i, 1] = vecLibro[1];
                    matLibros[i, 2] = vecLibro[2];
                    matLibros[i, 3] = vecLibro[3];
                    matLibros[i, 4] = vecLibro[4];
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
            contSigiente++;

            txtNombre.Text = matLibros[contSigiente, 0];
            txtCodLibro.Text = matLibros[contSigiente, 1];
            txtCodEditorial.Text = matLibros[contSigiente, 2];
            txtCodAutor.Text = matLibros[contSigiente, 3];
            txtCodDistribuidor.Text = matLibros[contSigiente, 4];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            contSigiente--;

            if (contSigiente != 0)
            {
                txtNombre.Text = matLibros[contSigiente, 0];
                txtCodLibro.Text = matLibros[contSigiente, 1];
                txtCodEditorial.Text = matLibros[contSigiente, 2];
                txtCodAutor.Text = matLibros[contSigiente, 3];
                txtCodDistribuidor.Text = matLibros[contSigiente, 4];
            }
            else
            {
                btnAnterior.Enabled = false;
            }

        }
    }
}
