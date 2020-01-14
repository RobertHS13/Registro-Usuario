namespace RegistroUsuario
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.correo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.acceder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.registrarse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.botonMinimizar);
            this.bunifuGradientPanel1.Controls.Add(this.botonCerrar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(540, 38);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.BackColor = System.Drawing.Color.Red;
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(471, 6);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonMinimizar.TabIndex = 10;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.BackColor = System.Drawing.Color.Red;
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(502, 6);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 25);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 9;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // contraseña
            // 
            this.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.contraseña.HintText = "";
            this.contraseña.isPassword = true;
            this.contraseña.LineFocusedColor = System.Drawing.Color.Red;
            this.contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.contraseña.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.contraseña.LineThickness = 3;
            this.contraseña.Location = new System.Drawing.Point(70, 134);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(274, 37);
            this.contraseña.TabIndex = 34;
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(67, 100);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(53, 17);
            this.bunifuCustomLabel12.TabIndex = 33;
            this.bunifuCustomLabel12.Text = "Correo";
            // 
            // correo
            // 
            this.correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.correo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.correo.HintForeColor = System.Drawing.Color.Empty;
            this.correo.HintText = "";
            this.correo.isPassword = false;
            this.correo.LineFocusedColor = System.Drawing.Color.Red;
            this.correo.LineIdleColor = System.Drawing.Color.Gray;
            this.correo.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.correo.LineThickness = 3;
            this.correo.Location = new System.Drawing.Point(70, 57);
            this.correo.Margin = new System.Windows.Forms.Padding(4);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(274, 39);
            this.correo.TabIndex = 32;
            this.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(67, 175);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(84, 17);
            this.bunifuCustomLabel10.TabIndex = 31;
            this.bunifuCustomLabel10.Text = "Contraseña";
            // 
            // acceder
            // 
            this.acceder.ActiveBorderThickness = 1;
            this.acceder.ActiveCornerRadius = 20;
            this.acceder.ActiveFillColor = System.Drawing.Color.Red;
            this.acceder.ActiveForecolor = System.Drawing.Color.White;
            this.acceder.ActiveLineColor = System.Drawing.Color.Red;
            this.acceder.BackColor = System.Drawing.Color.White;
            this.acceder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acceder.BackgroundImage")));
            this.acceder.ButtonText = "Acceder";
            this.acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceder.ForeColor = System.Drawing.Color.Red;
            this.acceder.IdleBorderThickness = 1;
            this.acceder.IdleCornerRadius = 20;
            this.acceder.IdleFillColor = System.Drawing.Color.White;
            this.acceder.IdleForecolor = System.Drawing.Color.Red;
            this.acceder.IdleLineColor = System.Drawing.Color.Red;
            this.acceder.Location = new System.Drawing.Point(137, 210);
            this.acceder.Margin = new System.Windows.Forms.Padding(5);
            this.acceder.Name = "acceder";
            this.acceder.Size = new System.Drawing.Size(142, 41);
            this.acceder.TabIndex = 35;
            this.acceder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acceder.Click += new System.EventHandler(this.acceder_Click);
            // 
            // registrarse
            // 
            this.registrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarse.FlatAppearance.BorderSize = 0;
            this.registrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.registrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarse.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.registrarse.Location = new System.Drawing.Point(12, 275);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(88, 25);
            this.registrarse.TabIndex = 36;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = true;
            this.registrarse.CursorChanged += new System.EventHandler(this.registrase_CursorChanged);
            this.registrarse.Click += new System.EventHandler(this.registrase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(321, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 260);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Registro Ciudadano";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 312);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.acceder);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contraseña;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox correo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuThinButton2 acceder;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}