
namespace JuegoMeloFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LinkRecContra = new System.Windows.Forms.LinkLabel();
            this.LinkRegistrar = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.BtnMin);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 36);
            this.panel1.TabIndex = 0;
            // 
            // BtnMin
            // 
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(283, 8);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(24, 24);
            this.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMin.TabIndex = 2;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(313, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(24, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 16);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(44, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(44, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.SystemColors.InfoText;
            this.TxtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtUser.Location = new System.Drawing.Point(48, 159);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(256, 27);
            this.TxtUser.TabIndex = 4;
            // 
            // TxtContra
            // 
            this.TxtContra.BackColor = System.Drawing.SystemColors.InfoText;
            this.TxtContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtContra.Location = new System.Drawing.Point(48, 225);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.PasswordChar = '°';
            this.TxtContra.Size = new System.Drawing.Size(256, 27);
            this.TxtContra.TabIndex = 5;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnIniciar.Location = new System.Drawing.Point(48, 301);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(256, 40);
            this.BtnIniciar.TabIndex = 6;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LinkRecContra
            // 
            this.LinkRecContra.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.LinkRecContra.AutoSize = true;
            this.LinkRecContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkRecContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRecContra.LinkColor = System.Drawing.Color.Gainsboro;
            this.LinkRecContra.Location = new System.Drawing.Point(93, 399);
            this.LinkRecContra.Name = "LinkRecContra";
            this.LinkRecContra.Size = new System.Drawing.Size(154, 17);
            this.LinkRecContra.TabIndex = 8;
            this.LinkRecContra.TabStop = true;
            this.LinkRecContra.Text = "Recuperar Contraseña";
            this.LinkRecContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRecContra_LinkClicked);
            // 
            // LinkRegistrar
            // 
            this.LinkRegistrar.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.LinkRegistrar.AutoSize = true;
            this.LinkRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRegistrar.LinkColor = System.Drawing.Color.Gainsboro;
            this.LinkRegistrar.Location = new System.Drawing.Point(127, 444);
            this.LinkRegistrar.Name = "LinkRegistrar";
            this.LinkRegistrar.Size = new System.Drawing.Size(84, 17);
            this.LinkRegistrar.TabIndex = 9;
            this.LinkRegistrar.TabStop = true;
            this.LinkRegistrar.Text = "Registrarme";
            this.LinkRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistrar_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(130, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(349, 506);
            this.Controls.Add(this.LinkRegistrar);
            this.Controls.Add(this.LinkRecContra);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel LinkRecContra;
        private System.Windows.Forms.LinkLabel LinkRegistrar;
    }
}

