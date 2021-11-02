
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
            this.btnAceptar = new BancoFront.Forms.Componentes.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.gboIntegrantes.Location = new System.Drawing.Point(213, 64);
            this.gboIntegrantes.Name = "gboIntegrantes";
            this.gboIntegrantes.Size = new System.Drawing.Size(289, 245);
            this.gboIntegrantes.TabIndex = 0;
            this.gboIntegrantes.TabStop = false;
            this.gboIntegrantes.Text = "Integrantes";
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
            this.btnAceptar.Location = new System.Drawing.Point(32, 194);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(228, 38);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lo Presti Fabrizzio - 112713";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lopez Javier - 112704";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kuba Carolina - 112927";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Irusta Federico - 113102";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo Nro: 13";
            // 
            // FrmIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.gboIntegrantes);
            this.Name = "FrmIntegrantes";
            this.Text = "FrmIntegrantes";
            this.Load += new System.EventHandler(this.FrmIntegrantes_Load);
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