using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace RC
{
    public partial class Form3 : Form
    {
        string codigo2;
        int id2;
        public Form3(string codigo, int id)
        {
            InitializeComponent();
            codigo2 = codigo;
            id2 = id;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void validar_Click(object sender, EventArgs e)
        {
            if (numero.Text.ToString() == codigo2)
            {
                error.Clear();

                MySqlConnection conectar = new MySqlConnection("Server=localhost;Database=registro;Uid=root;Pwd=root;");
                conectar.Open();
                MySqlCommand comando = new MySqlCommand("Validar", conectar);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", id2);
                comando.ExecuteNonQuery();

                MessageBox.Show("Validación Realizada", "Exito", MessageBoxButtons.OK);
                conectar.Close();
                Form2 obj = new Form2();
                obj.Show();
                this.Hide();
            }
            else
            {
                error.SetError(numero, "Código incorrecto");
            }
        }

        private void despues_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }
    }
}