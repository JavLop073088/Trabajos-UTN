
using BancoFront.Forms.Componentes;

namespace AppBanco.Forms
{
    partial class FrmAjustesCuenta
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
            this.gboCuenta = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new BancoFront.Forms.Componentes.RJButton();
            this.txtPasswordConfirm = new BancoFront.Forms.Componentes.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new BancoFront.Forms.Componentes.RJTextBox();
            this.txtUsername = new BancoFront.Forms.Componentes.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboCuenta
            // 
            this.gboCuenta.Controls.Add(this.btnConfirmar);
            this.gboCuenta.Controls.Add(this.txtPasswordConfirm);
            this.gboCuenta.Controls.Add(this.label3);
            this.gboCuenta.Controls.Add(this.txtPassword);
            this.gboCuenta.Controls.Add(this.txtUsername);
            this.gboCuenta.Controls.Add(this.label2);
            this.gboCuenta.Controls.Add(this.label1);
            this.gboCuenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboCuenta.Location = new System.Drawing.Point(180, 76);
            this.gboCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboCuenta.Name = "gboCuenta";
            this.gboCuenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboCuenta.Size = new System.Drawing.Size(315, 415);
            this.gboCuenta.TabIndex = 0;
            this.gboCuenta.TabStop = false;
            this.gboCuenta.Text = "Datos de la Cuenta";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmar.BorderRadius = 0;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(32, 344);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(250, 50);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswordConfirm.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPasswordConfirm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPasswordConfirm.BorderSize = 2;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordConfirm.Location = new System.Drawing.Point(32, 276);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPasswordConfirm.Multiline = false;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtPasswordConfirm.PasswordChar = true;
            this.txtPasswordConfirm.Size = new System.Drawing.Size(250, 39);
            this.txtPasswordConfirm.TabIndex = 5;
            this.txtPasswordConfirm.Texts = "";
            this.txtPasswordConfirm.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(32, 170);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 39);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(32, 75);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.Size = new System.Drawing.Size(250, 39);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // FrmAjustesCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 562);
            this.Controls.Add(this.gboCuenta);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAjustesCuenta";
            this.Text = "FrmAjustesCuenta";
            this.gboCuenta.ResumeLayout(false);
            this.gboCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboCuenta;
        private RJTextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJTextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private RJTextBox txtPasswordConfirm;
        private RJButton btnConfirmar;
    }
}