using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media; // Para reproducir sonidos didacticos
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Para usar Task.Delay y simular el tiempo de espera del sorteo
using System.Windows.Forms;
using Microsoft.VisualBasic; // Para usar Interaction.InputBox si se desea implementar una entrada alternativa para los números del jugador

namespace SimuladorLoteria
{
    
    public partial class Form1 : Form
    {
      
        // Reglas del juego
        private const int CantidadNumeros = 6;
        private const int Minimo = 1;
        private const int Maximo = 49;

        // Instancias de Jugador y Sorteo
        private Jugador _jugador;
        private Sorteo _sorteo;
        private List<TextBox> _listaCampos;
        private string _usuarioActual;

        public Form1(string nombreUsuario) // Constructor que recibe el nombre de usuario desde el FormLogin
        {
            InitializeComponent();
            _usuarioActual = nombreUsuario;
            _jugador = new Jugador();
            _sorteo = new Sorteo();

            _listaCampos = new List<TextBox> { txtNum1, txtNum2, txtNum3, txtNum4, txtNum5, txtNum6 };
        }
        private async void btnJugar_Click(object sender, EventArgs e) // Async para permitir la animacion visual de espera
        {
            musica = new SoundPlayer(@"musica\nintendo-game-boy-startup.wav");
            musica.Play();
            _jugador.LimpiarJugada();
            foreach (TextBox campo in _listaCampos)
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    SystemSounds.Question.Play();
                    MessageBox.Show("¡Por favor, completa todos las casillas con tus numeros de la suerte!", "Dato Faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campo.Focus();
                    return;
                }
                if (int.TryParse(campo.Text, out int numeroIngresado))
                {
                    string error = _jugador.RegistrarNumero(numeroIngresado, Minimo, Maximo);
                    if (!string.IsNullOrEmpty(error))
                    {
                        SystemSounds.Beep.Play(); // Sonido didactico de advertencia
                        MessageBox.Show(error, "Validacion de Logica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        campo.Focus(); // Enfocar el campo con error para facilitar la correccion
                        //campo.SelectAll(); // Seleccionar el texto del campo para facilitar la correccion
                        return;
                    }
                }
                else
                {
                    SystemSounds.Exclamation.Play(); // Sonido didactico de advertencia
                    MessageBox.Show($"¡El valor '{campo.Text}' no es un numero valido! Por favor, ingresa un numero entre {Minimo} y {Maximo}.", "Dato Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campo.Focus(); // Enfocar el campo con error para facilitar la correccion
                    //campo.SelectAll(); // Seleccionar el texto del campo para facilitar la correccion
                    return;
                }
            }
            btnJugar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics durante la entrada de datos
            btnJugar.Text = "Corriendo Sorteo...";
            SystemSounds.Asterisk.Play();
            await Task.Delay(1500); // Simula el tiempo de espera del sorteo 1.5 segundo

            // Ejecucion del sorteo oficial
            HashSet<int> resultadosSorteo = _sorteo.RealizarSorteo(CantidadNumeros, Minimo, Maximo);
            HashSet<int> aciertos = new HashSet<int>(_jugador.NumerosElegidos);
            aciertos.IntersectWith(resultadosSorteo);

            // Ordenamos los valores para una mejor visualizacion en el boleto digital
            List<int> seleccionUsuario = new List<int>(_jugador.NumerosElegidos);
            List<int> sorteoOficial = new List<int>(resultadosSorteo);
            seleccionUsuario.Sort();
            sorteoOficial.Sort();

            btnJugar.Text = "Generar numeros";
            btnJugar.Enabled = true; // Rehabilitar el botón para permitir jugar nuevamente

            string tituloPantalla = aciertos.Count >= 3 ? "¡Gran Sorteo!" : "Sorteo Finalizado";
            Color colorCabecera = aciertos.Count >= 3 ? Color.Gold : Color.Silver;

            string boletoDigital =
                "**********************************************\r\n" +
                "   Boleto Digital de Loteria Electronico       \r\n" +
                "---------------------------------------------\r\n" +
                $" Jugador Usuario:{_usuarioActual.ToUpper()}         \r\n" +
                $" Fecha:{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} \r\n" +
                "----------------------------------------------\r\n" +
                $" Tus Numeros: {string.Join("-", seleccionUsuario)}  \r\n" +
                $" Numeros Sorteados: {string.Join("-", sorteoOficial)} \r\n" +
                $" Cantidad de Aciertos: {aciertos.Count()}    \r\n" +
                "***********************************************\r\n";

            if (aciertos.Count > 0)
            {
                boletoDigital += $"Numeros Acertados: {string.Join(", ", aciertos)}\n";
            }
            FormResultados pantallaFinal = new FormResultados(tituloPantalla, boletoDigital, colorCabecera);
            pantallaFinal.ShowDialog();
            musica = new SoundPlayer(@"musica\super-mario-coin-sound.wav");
            musica.Play();
        } 
        private SoundPlayer musica;

        private void txtNum1_TextChanged(object sender, EventArgs e) 
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }
        private void txtNum3_TextChanged(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }
        private void txtNum4_TextChanged(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }
        private void txtNum5_TextChanged(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }
        private void txtNum6_TextChanged(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }

        private void txtNum4_TextChanged_1(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }

        private void txtNum6_TextChanged_1(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }

        private void txtNum3_TextChanged_1(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }

        private void txtNum2_TextChanged_1(object sender, EventArgs e)
        {
            musica = new SoundPlayer(@"musica\gta-v-notification.wav");
            musica.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    // PANTALLA DE RESULTADOS AUTOMÁTICA (No necesitas diseñarla visualmente)
    public class FormResultados : Form
    {
        private Label lblTitulo;
        private TextBox txtBoleto;
        private Button btnCerrar;

        public FormResultados(string titulo, string contenido, Color colorTexto)
        {
            this.Text = titulo;
            this.Size = new Size(480, 500);
            this.BackColor = Color.Black;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.ForeColor = colorTexto;
            lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Size = new Size(420, 30);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            txtBoleto = new TextBox();
            txtBoleto.Multiline = true;
            txtBoleto.ReadOnly = true;
            txtBoleto.BackColor = Color.FromArgb(15, 15, 15);
            txtBoleto.ForeColor = Color.Lime;
            txtBoleto.Font = new Font("Consolas", 10);
            txtBoleto.Location = new Point(20, 60);
            txtBoleto.Size = new Size(424, 320);
            txtBoleto.Text = contenido;

            btnCerrar = new Button();
            btnCerrar.Text = "CERRAR TICKET";
            btnCerrar.BackColor = Color.FromArgb(30, 30, 30);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(160, 400);
            btnCerrar.Size = new Size(150, 40);
            btnCerrar.Click += (s, e) => this.Close();

            this.Controls.Add(lblTitulo);
            this.Controls.Add(txtBoleto);
            this.Controls.Add(btnCerrar);
        }
    }
}