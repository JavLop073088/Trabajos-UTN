
namespace AppBanco.Forms
{
    partial class FrmGrafico
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
            this.gboGrafico = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gboGrafico
            // 
            this.gboGrafico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboGrafico.Location = new System.Drawing.Point(34, 41);
            this.gboGrafico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboGrafico.Name = "gboGrafico";
            this.gboGrafico.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboGrafico.Size = new System.Drawing.Size(741, 515);
            this.gboGrafico.TabIndex = 0;
            this.gboGrafico.TabStop = false;
            this.gboGrafico.Text = "Resumen";
            // 
            // FrmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.gboGrafico);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGrafico";
            this.Text = "FrmGrafico";
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox gboGrafico;
    }
}