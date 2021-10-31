
using BancoFront.Forms.Componentes;

namespace AppBanco.Forms
{
    partial class FrmIngreso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.rjTxtPassword = new BancoFront.Forms.Componentes.RJTextBox();
            this.rjTxtUsername = new BancoFront.Forms.Componentes.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 412);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoFront.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(49, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(442, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingreso";
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Candara Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngreso.ForeColor = System.Drawing.Color.DarkGray;
            this.btnIngreso.Location = new System.Drawing.Point(294, 315);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(437, 50);
            this.btnIngreso.TabIndex = 4;
            this.btnIngreso.Text = "ACCEDER";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(747, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 31);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 28;
            this.btnMinimizar.Location = new System.Drawing.Point(720, 8);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 31);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // rjTxtPassword
            // 
            this.rjTxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rjTxtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTxtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTxtPassword.BorderSize = 2;
            this.rjTxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTxtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTxtPassword.Location = new System.Drawing.Point(294, 182);
            this.rjTxtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rjTxtPassword.Multiline = false;
            this.rjTxtPassword.Name = "rjTxtPassword";
            this.rjTxtPassword.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.rjTxtPassword.PasswordChar = false;
            this.rjTxtPassword.Size = new System.Drawing.Size(437, 39);
            this.rjTxtPassword.TabIndex = 2;
            this.rjTxtPassword.Texts = "PASSWORD";
            this.rjTxtPassword.UnderlinedStyle = true;
            this.rjTxtPassword.Enter += new System.EventHandler(this.rjTxtPassword_Enter);
            this.rjTxtPassword.Leave += new System.EventHandler(this.rjTxtPassword_Leave);
            // 
            // rjTxtUsername
            // 
            this.rjTxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rjTxtUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTxtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTxtUsername.BorderSize = 2;
            this.rjTxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTxtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTxtUsername.Location = new System.Drawing.Point(294, 111);
            this.rjTxtUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rjTxtUsername.Multiline = false;
            this.rjTxtUsername.Name = "rjTxtUsername";
            this.rjTxtUsername.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.rjTxtUsername.PasswordChar = false;
            this.rjTxtUsername.Size = new System.Drawing.Size(437, 39);
            this.rjTxtUsername.TabIndex = 1;
            this.rjTxtUsername.Texts = "USUARIO";
            this.rjTxtUsername.UnderlinedStyle = true;
            this.rjTxtUsername.Enter += new System.EventHandler(this.rjTxtUsername_Enter);
            this.rjTxtUsername.Leave += new System.EventHandler(this.rjTxtUsername_Leave);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 412);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjTxtPassword);
            this.Controls.Add(this.rjTxtUsername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmIngreso";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJTextBox rjTxtUsername;
        private RJTextBox rjTxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
    }
}