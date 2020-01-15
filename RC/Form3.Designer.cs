namespace RC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numero = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.validar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.despues = new Bunifu.Framework.UI.BunifuThinButton2();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
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
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(399, 38);
            this.bunifuGradientPanel1.TabIndex = 1;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Validación de Cuenta";
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.BackColor = System.Drawing.Color.Yellow;
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(330, 6);
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
            this.botonCerrar.BackColor = System.Drawing.Color.Yellow;
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(361, 6);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 25);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 9;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(60, 128);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(168, 21);
            this.bunifuCustomLabel10.TabIndex = 32;
            this.bunifuCustomLabel10.Text = "Introduce tu código";
            // 
            // numero
            // 
            this.numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numero.HintForeColor = System.Drawing.Color.Empty;
            this.numero.HintText = "";
            this.numero.isPassword = false;
            this.numero.LineFocusedColor = System.Drawing.Color.Yellow;
            this.numero.LineIdleColor = System.Drawing.Color.Gray;
            this.numero.LineMouseHoverColor = System.Drawing.Color.Yellow;
            this.numero.LineThickness = 4;
            this.numero.Location = new System.Drawing.Point(64, 80);
            this.numero.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(265, 43);
            this.numero.TabIndex = 33;
            this.numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // validar
            // 
            this.validar.ActiveBorderThickness = 1;
            this.validar.ActiveCornerRadius = 20;
            this.validar.ActiveFillColor = System.Drawing.Color.Yellow;
            this.validar.ActiveForecolor = System.Drawing.Color.Black;
            this.validar.ActiveLineColor = System.Drawing.Color.Yellow;
            this.validar.BackColor = System.Drawing.Color.White;
            this.validar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("validar.BackgroundImage")));
            this.validar.ButtonText = "Validar";
            this.validar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validar.ForeColor = System.Drawing.Color.Yellow;
            this.validar.IdleBorderThickness = 1;
            this.validar.IdleCornerRadius = 20;
            this.validar.IdleFillColor = System.Drawing.Color.White;
            this.validar.IdleForecolor = System.Drawing.Color.Yellow;
            this.validar.IdleLineColor = System.Drawing.Color.Yellow;
            this.validar.Location = new System.Drawing.Point(214, 201);
            this.validar.Margin = new System.Windows.Forms.Padding(5);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(115, 41);
            this.validar.TabIndex = 36;
            this.validar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // despues
            // 
            this.despues.ActiveBorderThickness = 1;
            this.despues.ActiveCornerRadius = 20;
            this.despues.ActiveFillColor = System.Drawing.Color.Black;
            this.despues.ActiveForecolor = System.Drawing.Color.White;
            this.despues.ActiveLineColor = System.Drawing.Color.Black;
            this.despues.BackColor = System.Drawing.Color.White;
            this.despues.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("despues.BackgroundImage")));
            this.despues.ButtonText = "Más tarde";
            this.despues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.despues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despues.ForeColor = System.Drawing.Color.Black;
            this.despues.IdleBorderThickness = 1;
            this.despues.IdleCornerRadius = 20;
            this.despues.IdleFillColor = System.Drawing.Color.White;
            this.despues.IdleForecolor = System.Drawing.Color.Black;
            this.despues.IdleLineColor = System.Drawing.Color.Black;
            this.despues.Location = new System.Drawing.Point(64, 201);
            this.despues.Margin = new System.Windows.Forms.Padding(5);
            this.despues.Name = "despues";
            this.despues.Size = new System.Drawing.Size(115, 41);
            this.despues.TabIndex = 37;
            this.despues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.despues.Click += new System.EventHandler(this.despues_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 279);
            this.Controls.Add(this.despues);
            this.Controls.Add(this.validar);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox numero;
        private Bunifu.Framework.UI.BunifuThinButton2 validar;
        private Bunifu.Framework.UI.BunifuThinButton2 despues;
        private System.Windows.Forms.ErrorProvider error;
    }
}