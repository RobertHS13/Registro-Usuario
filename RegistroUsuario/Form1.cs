using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace RegistroUsuario
{
    public partial class Form1 : Form
    {
        string conexiontexto = @"Server=localhost;Database=registro;Uid=root;Pwd=root;";

        int id;
        public Form1(int id2, int indicador)
        {
            InitializeComponent();
            id = id2;

            if (indicador == 1)
                llenado();
        }

        byte[] vecByte;
        byte[] vecByte2;
        private void llenado()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexiontexto))
            {
                mysqlCon.Open();

                MySqlCommand comando = new MySqlCommand("View", mysqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("id", id);

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(comando);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tabla = new DataTable();
                sqlDa.Fill(tabla);
                DataRow row = tabla.Rows[0];
                nombre.Text = row["nombre"].ToString();
                apellidoP.Text = row["apellidoPaterno"].ToString();
                apellidoM.Text = row["apellidoMaterno"].ToString();
                //sexo.Text = row["sexo"].ToString();
                pais.Text = row["pais"].ToString();
                //fecha.Text = row["fechaNacimiento"].ToString();
                curp.Text = row["curp"].ToString();
                rfc.Text = row["rfc"].ToString();
                cvu.Text = row["cvu"].ToString();
                contraseña.Text = row["contraseña"].ToString();
                telefono.Text = row["telefono"].ToString();
                correo.Text = row["correo"].ToString();

                if(row["sexo"].ToString() == "Masculino")
                    sexo.SelectedIndex = 0;
                else
                    sexo.SelectedIndex = 1;

                fecha.Format = DateTimePickerFormat.Custom;
                fecha.CustomFormat = row["fechaNacimiento"].ToString();

                vecByte = (byte[])row["titulo"];
                imagen1.Image = byteArrayToImage(vecByte);
                vecByte2 = (byte[])row["cedula"];
                imagen2.Image = byteArrayToImage(vecByte2);
            }
        }

        public Image byteArrayToImage(byte[] byteAvatar)
        {
            MemoryStream ms = new MemoryStream(byteAvatar);
            Image devolverImagen = Image.FromStream(ms);
            return devolverImagen;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using(MySqlConnection mysqlCon = new MySqlConnection(conexiontexto))
            {
                byte[] avatar = convertirAvatarAByte(imagen1.ImageLocation);
                byte[] avatar2 = convertirAvatarAByte(imagen2.ImageLocation);
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("id", id);
                mySqlCmd.Parameters.AddWithValue("nombre2", nombre.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("apellidoPaterno2", apellidoP.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("apellidoMaterno2", apellidoM.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("sexo2", sexo.SelectedItem.ToString().Trim());
                mySqlCmd.Parameters.AddWithValue("pais2",pais.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("fechaNacimiento2", fecha.Value);
                mySqlCmd.Parameters.AddWithValue("curp2", curp.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("rfc2", rfc.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("cvu2", cvu.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("contraseña2", contraseña.Text.Trim());
                
                mySqlCmd.Parameters.Add("titulo2", MySqlDbType.MediumBlob, avatar.Length).Value = avatar;
                mySqlCmd.Parameters.Add("cedula2", MySqlDbType.MediumBlob, avatar2.Length).Value = avatar2;


                mySqlCmd.Parameters.AddWithValue("telefono2", telefono.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("correo2", correo.Text.Trim());

                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
            }
        }

        public static byte[] convertirAvatarAByte(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] avatar = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return avatar;
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            DialogResult im = img.ShowDialog();
            if(im == DialogResult.OK)
            {
                imagen1.Load(img.FileName);
            }
            else
            {
                MessageBox.Show("Error al subir la imagen");
            }
        }

        private void cargar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            DialogResult im = img.ShowDialog();
            if (im == DialogResult.OK)
            {
                imagen2.Load(img.FileName);
            }
            else
            {
                MessageBox.Show("Error al subir la imagen");
            }
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }
    }
}
