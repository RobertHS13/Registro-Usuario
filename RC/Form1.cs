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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RC
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

                if (row["sexo"].ToString() == "Masculino")
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
            try
            {
                error.Clear();
                if (camposVacios() == 0)
                {
                    if (correoBienEscrito(correo.Text.ToString()) == true)
                    {
                        using (MySqlConnection mysqlCon = new MySqlConnection(conexiontexto))
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
                            mySqlCmd.Parameters.AddWithValue("pais2", pais.Text.Trim());
                            mySqlCmd.Parameters.AddWithValue("fechaNacimiento2", fecha.Value);
                            mySqlCmd.Parameters.AddWithValue("curp2", curp.Text.Trim());
                            mySqlCmd.Parameters.AddWithValue("rfc2", rfc.Text.Trim());
                            mySqlCmd.Parameters.AddWithValue("cvu2", cvu.Text.Trim());
                            mySqlCmd.Parameters.AddWithValue("contraseña2", contraseña.Text.Trim());

                            mySqlCmd.Parameters.Add("titulo2", MySqlDbType.MediumBlob, avatar.Length).Value = avatar;
                            mySqlCmd.Parameters.Add("cedula2", MySqlDbType.MediumBlob, avatar2.Length).Value = avatar2;

                            mySqlCmd.Parameters.AddWithValue("telefono2", telefono.Text.Trim());
                            mySqlCmd.Parameters.AddWithValue("correo2", correo.Text.Trim());
                            mySqlCmd.Parameters.AddWithValue("registrado2", "0");

                            if (id == 0)
                            {
                                verificacion();
                                mySqlCmd.Parameters.AddWithValue("numero2", codigo);
                                mySqlCmd.ExecuteNonQuery();

                                MySqlCommand comando2 = new MySqlCommand("UsuarioExistente", mysqlCon);
                                comando2.CommandType = CommandType.StoredProcedure;
                                comando2.Parameters.AddWithValue("correo2", correo.Text.Trim());
                                comando2.Parameters.AddWithValue("contraseña2", contraseña.Text.Trim());
                                comando2.ExecuteNonQuery();
                                int id3;
                                MySqlDataAdapter sqlDa = new MySqlDataAdapter(comando2);
                                DataTable tabla = new DataTable();
                                sqlDa.Fill(tabla);
                                DataRow row = tabla.Rows[0];
                                id3 = (int)row["idUsuario"];

                                Form3 obj2 = new Form3(codigo, id3);
                                obj2.Show();
                                this.Hide();
                            }
                            else
                            {
                                mySqlCmd.Parameters.AddWithValue("numero2", codigo);
                                mySqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Datos Guardados");
                            }
                        }
                    }
                }
                else
                {
                    correoBienEscrito(correo.Text.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un inconveniente, intente nuevamente ");
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
            if (im == DialogResult.OK)
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
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void verificacion()
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(new MailAddress(correo.Text.ToString()));
                mail.From = new MailAddress("robertohs13000@gmail.com");
                mail.Subject = "Código de Validación";
                mail.Body = "Tu código es "+generarCodigo();
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("robertohs13000@gmail.com", "17034otrebor");
                //string output = null;
                client.Send(mail);
                mail.Dispose();
                //MessageBox.Show("Mensaje enviado", "Exito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje NO enviado" + ex, "NO Exito", MessageBoxButtons.OK);
            }
        }

        string codigo="";
        private string generarCodigo()
        {
            Random numero = new Random();
            int num = numero.Next(100000, 999999);
            codigo = num.ToString();
            return codigo;
        }

        private int camposVacios()
        {
            int indicador = 0;
            if(nombre.Text.Length == 0)
            {
                error.SetError(nombre, "Campo vacío");
                indicador++;
            }
            if(apellidoP.Text.Length == 0)
            {
                error.SetError(apellidoP, "Campo vacío");
                indicador++;
            }
            if (apellidoM.Text.Length == 0)
            {
                error.SetError(apellidoM, "Campo vacío");
                indicador++;
            }
            if (sexo.Text.Length == 0)
            {
                error.SetError(sexo, "Campo vacío");
                indicador++;
            }
            if (pais.Text.Length == 0)
            {
                error.SetError(pais, "Campo vacío");
                indicador++;
            }
            if (curp.Text.Length == 0)
            {
                error.SetError(curp, "Campo vacío");
                indicador++;
            }
            if (rfc.Text.Length == 0)
            {
                error.SetError(rfc, "Campo vacío");
                indicador++;
            }
            if (cvu.Text.Length == 0)
            {
                error.SetError(cvu, "Campo vacío");
                indicador++;
            }
            if (telefono.Text.Length == 0)
            {
                error.SetError(telefono, "Campo vacío");
                indicador++;
            }
            if (correo.Text.Length == 0)
            {
                error.SetError(correo, "Campo vacío");
                indicador++;
            }
            if (contraseña.Text.Length == 0)
            {
                error.SetError(contraseña, "Campo vacío");
                indicador++;
            }
            if (imagen1.Image == null)
            {
                error.SetError(cargar1, "No ha cargado una imagen");
                indicador++;
            }
            if (imagen2.Image == null)
            {
                error.SetError(cargar2, "No ha cargado una imagen");
                indicador++;
            }

            return indicador;
        }

        private Boolean correoBienEscrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    error.SetError(correo, "No contiene formato de correo");
                    return false;

                }
            }
            else
            {
                error.SetError(correo, "No contiene formato de correo");
                return false;
            }
        }
    }
}
