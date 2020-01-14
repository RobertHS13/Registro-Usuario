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
using System.IO;

namespace RegistroUsuario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void registrase_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1(0, 0);
            obj.Show();
            this.Hide();
        }

        private void registrase_CursorChanged(object sender, EventArgs e)
        {
            registrarse.ForeColor = Color.Red;
        }

        private void acceder_Click(object sender, EventArgs e)
        {
            if (contraseña.Text.Length == 0)
            {
                error.SetError(contraseña, "Introdusca su correo");
            }

            else if (correo.Text.Length == 0)
            {
                error.SetError(correo, "Introdusca su contraseña");
            }
            else
            {
                int id = 0;
                MySqlConnection conectar = new MySqlConnection("Server=localhost;Database=registro;Uid=root;Pwd=root;");
                conectar.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conectar;
                comando.CommandText = ("select idUsuario from datosusuario where correo = '" + contraseña.Text.ToString() + "' and" +
                    " contraseña = '" + correo.Text.ToString() + "'");
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();
                    MySqlCommand comando2 = new MySqlCommand("UsuarioExistente", conectar);
                    comando2.CommandType = CommandType.StoredProcedure;
                    comando2.Parameters.AddWithValue("correo2", contraseña.Text.Trim());
                    comando2.Parameters.AddWithValue("contraseña2", correo.Text.Trim());

                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(comando2);
                    /*sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.InsertCommand.Parameters.AddWithValue("correo2", correo.Text.ToString());
                    sqlDa.InsertCommand.Parameters.AddWithValue("contraseña2", contraseña.Text.ToString());*/
                    DataTable tabla = new DataTable();
                    sqlDa.Fill(tabla);
                    DataRow row = tabla.Rows[0];
                    id = (int)row["idUsuario"];
                    this.Hide();
                    Form1 obj = new Form1(id, 1);
                    obj.Show();
                    MessageBox.Show("Si funciono");
                }
                else
                {
                    error.SetError(correo, "Usuario o Contraseña incorrecta");
                }
                conectar.Close();
            }
        }
    }
}
