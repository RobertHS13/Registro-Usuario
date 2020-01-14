using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace RegistroUsuario
{
    public partial class Verificacion : Form
    {
        public Verificacion()
        {
            InitializeComponent();
        }

        private void Verificacion_Load(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(new MailAddress("hernandez.santana.17034@itsmante.edu.mx"));
                mail.From = new MailAddress("robertohs13000@gmail.com");
                mail.Subject = "Validación por correo";
                mail.Body = "You can´t see mee";
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
                MessageBox.Show("Mensaje enviado", "Exito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje NO enviado" + ex, "NO Exito", MessageBoxButtons.OK);
            }
            
        }
    }
}
