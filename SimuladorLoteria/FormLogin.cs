using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimuladorLoteria
{
  
    public partial class FormLogin : Form
    {
        private SoundPlayer musica;
        public string NombreUsuario { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingresa su nombre de usuario.", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NombreUsuario = txtUsuario.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();

            musica = new SoundPlayer(@"musica\nintendo-game-boy-startup.wav");
            musica.Play();

            musica.Stop(); // Detener la musica de fondo al ingresar

           
            this.Hide(); // Ocultar el formulario de login
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
          
            musica = new SoundPlayer(@"musica\Música-de-suspenso-para-fondos-de-videos.wav");
            musica.PlayLooping();
        }
    }
}
