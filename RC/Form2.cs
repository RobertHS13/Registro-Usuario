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

namespace RC
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
            if (correo.Text.Length == 0)
            {
                error.SetError(correo, "Introdusca su correo");
            }

            else if (contraseña.Text.Length == 0)
            {
                error.SetError(contraseña, "Introdusca su contraseña");
            }
            else
            {
                int id = 0;
                MySqlConnection conectar = new MySqlConnection("Server=localhost;Database=registro;Uid=root;Pwd=root;");
                conectar.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conectar;
                comando.CommandText = ("select idUsuario from datosusuario where correo = '" + correo.Text.ToString() + "' and" +
                    " contraseña = '" + contraseña.Text.ToString() + "'");
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    leer.Close();
                    MySqlCommand comando2 = new MySqlCommand("UsuarioExistente", conectar);
                    comando2.CommandType = CommandType.StoredProcedure;
                    comando2.Parameters.AddWithValue("correo2", correo.Text.Trim());
                    comando2.Parameters.AddWithValue("contraseña2", contraseña.Text.Trim());

                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(comando2);
                    DataTable tabla = new DataTable();
                    sqlDa.Fill(tabla);
                    DataRow row = tabla.Rows[0];
                    id = (int)row["idUsuario"];

                    MySqlCommand comando3 = new MySqlCommand("Registrado", conectar);
                    comando3.CommandType = CommandType.StoredProcedure;
                    comando3.Parameters.AddWithValue("id", id);

                    string bin;
                    string numero;
                    MySqlDataAdapter sqlDa2 = new MySqlDataAdapter(comando3);
                    DataTable tabla2 = new DataTable();
                    sqlDa2.Fill(tabla2);
                    DataRow row2 = tabla2.Rows[0];
                    bin = (string) row2["registrado"];
                    numero = (string)row2["numero"];

                    if (bin == "1")
                    {
                        this.Hide();
                        Form1 obj = new Form1(id, 1);
                        obj.Show();
                    }
                    else
                    {
                        this.Hide();
                        Form3 obj = new Form3(numero, id);
                        obj.Show();
                    }
                }
                else
                {
                    error.SetError(contraseña, "Usuario o Contraseña incorrecta");
                }
                conectar.Close();
            }
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void respaldo_Click(object sender, EventArgs e)
        {
            string conexion = "Server=localhost;Database=registro;Uid=root;Pwd=root;";

            DateTime fecha = DateTime.Now;

            string fecha2 = fecha.ToString("dd_MM_yyyy");

            //Console.WriteLine(fecha2);

            string file = "C:\\Users\\Usuario\\Desktop\\Tecnológico\\Administación BD\\Respaldo\\Respaldo"+fecha2+".sql";
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                using(MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        con.Open();
                        mb.ExportToFile(file);
                        con.Close();
                    }
                }
            }
            MessageBox.Show("Respaldo Realizado");
            Application.Exit();
        }
    }
}