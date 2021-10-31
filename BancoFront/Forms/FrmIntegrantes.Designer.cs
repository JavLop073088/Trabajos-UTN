
using BancoFront.Forms.Componentes;

namespace AppBanco.Forms
{
    partial class FrmIntegrantes
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
            this.gboIntegrantes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new BancoFront.Forms.Componentes.RJButton();
            this.gboIntegrantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboIntegrantes
            // 
            this.gboIntegrantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboIntegrantes.Controls.Add(this.btnAceptar);
            this.gboIntegrantes.Controls.Add(this.label5);
            this.gboIntegrantes.Controls.Add(this.label4);
            this.gboIntegrantes.Controls.Add(this.label3);
            this.gboIntegrantes.Controls.Add(this.label2);
            this.gboIntegrantes.Controls.Add(this.label1);
            this.gboIntegrantes.Location = new System.Drawing.Point(243, 68);
            this.gboIntegrantes.Name = "gboIntegrantes";
            this.gboIntegrantes.Size = new System.Drawing.Size(330, 261);
            this.gboIntegrantes.TabIndex = 0;
            this.gboIntegrantes.TabStop = false;
            this.gboIntegrantes.Text = "Integrantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lo Presti Fabrizzio - 112713";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lopez Javier - 112704";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kuba Carolina - 112927";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Irusta Federico - 113102";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo Nro: 13";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 0;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(36, 207);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(260, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboIntegrantes);
            this.Name = "FrmIntegrantes";
            this.Text = "FrmIntegrantes";
            this.gboIntegrantes.ResumeLayout(false);
            this.gboIntegrantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboIntegrantes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJButton btnAceptar;
    }
}