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
using System.Net;

namespace Mecanografia
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        //Boton de SALIDA del Programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //GLOBALES:

        List<char> listaLetras;
        int score = 0; //Score
        int contador = 10; //Inicio del Temporizador

        private void Palabra()
        {
            string texto = lblPalabra.Text;
            listaLetras = texto.ToList();
        }

        
        private void centralLBL(Label lbl, int y)
        {
            // Calcular la posición X para centrar el Label en el Panel
            int x = (panelContendor.Width - lbl.Width) / 2;
            lbl.Location = new Point(x,y);
        }


        private void ControlTexto()
        {
            //texto actual en la caja de texto
            string textoActual = txtPalabra.Text;

            bool esCorrecto = true;
            for (int i = 0; i < textoActual.Length; i++)
            {
                // Si el texto es más largo que la lista de caracteres o los caracteres no coinciden
                if (i >= listaLetras.Count || textoActual[i] != listaLetras[i])
                {
                    esCorrecto = false;
                    break;
                }
            }

            //Control del Temporizador y cambiar palabra
            if(Convert.ToInt32(textoActual.Length) == listaLetras.Count && textoActual == lblPalabra.Text)
            {
                //Si es True aumenta 7s
                Control();
                contador += 2;
            }

            // Cambiar el color y verificar si es correcto
            if (esCorrecto)
            {
                txtPalabra.ForeColor = Color.Black; // Texto en negro si coincide
            }
            else
            {
                txtPalabra.ForeColor = Color.Red; // Texto en rojo si no coincide
            }
        }

        private void Control()
        {
            txtPalabra.Clear();
            txtPalabra.Focus();

            score += 10;
            lblScore.Text = $"Score:{score}";

            lblPalabra.Text = LeerTxT();
            Palabra();
            centralLBL(lblPalabra, 137);
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblPalabra.Text = LeerTxT();
            Palabra();
            centralLBL(lblPalabra,137);
            Mejor();
            lblMejor.Text = clsMejor.mejor.ToString();
            tiempo.Start();
        }

        public void Mejor()
        {
            try
            {
                string mejor;
                // Leer todo el contenido del archivo
                StreamReader leer = new StreamReader("./TXT/Mejor.txt");
                if ((mejor = leer.ReadLine()) != null)
                {
                    clsMejor.mejor = Convert.ToInt32(mejor);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Guardar(int i)
        {
            StreamWriter escribir = new StreamWriter("./TXT/Mejor.txt");
            try
            {
                if(i > clsMejor.mejor)
                {
                    escribir.WriteLine(i.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            escribir.Close();
        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {
            ControlTexto();
        }

        public string LeerTxT()
        {
            string palabra = "";

            try
            {
                // Leer todas las líneas del archivo
                string[] palabras = File.ReadAllLines("./TXT/ListaPalabras.txt");

                // Contar el número total de palabras
                int totalPalabras = palabras.Length;

                if (totalPalabras > 0)
                {
                    // Seleccionar una palabra aleatoria
                    Random random = new Random();
                    palabra = palabras[random.Next(totalPalabras)];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return palabra;
        }

        
        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
            }
            else
            {
                txtPalabra.Font = new Font("Century Gothic",30);
                txtPalabra.Text = "Juego Finalzado";
                txtPalabra.Enabled = false;
                Guardar(score);
            }
            lblTempo.Text = $"Tiempo restante: {contador} segundos";
            centralLBL(lblTempo, 19);
        }
    }
}
