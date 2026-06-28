using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorLoteria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin loginForm = new FormLogin();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1(loginForm.NombreUsuario));
            }

        }
    }
}
