using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Reportes;


namespace AppBanco.Forms
{
    public partial class FrmPrincipal : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formHijoActual;

        // Constructor
        public FrmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // Iniciar en Home
            ActivateButton(btnHome, RGBColors.color1);
            AbrirFormHijo(new FrmInicio());
        }

        // Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        // Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DissableButton();

                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icono y Label Formulario Actual
                iconFormActual.IconChar = currentBtn.IconChar;
                iconFormActual.IconColor = color;
                lblTituloFormActual.Text = currentBtn.Text;
            }
        }

        private void DissableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 122, 204);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        // Botones Aside Izquierda
        private void btnHome_Click(object sender, EventArgs e)
        {
            // formHijoActual.Close();
            ActivateButton(sender, RGBColors.color1);
            AbrirFormHijo(new FrmInicio());
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormHijo(new FrmConsulaCliente());
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormHijo(new FrmAltaCliente());
        }

        private void btnAjustesCuenta_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormHijo(new FrmAjustesCuenta());
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirFormHijo(new FrmGrafico());
        }

        // Abrir formularios hijos dentro
        private void AbrirFormHijo(Form formHijo)
        {
            if(formHijoActual != null)
            {
                formHijoActual.Close();
            }

            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(formHijo);
            panelDesktop.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }


        // Barra de Menu Superior
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposCuentas tipoCuenta = new FrmTiposCuentas();
            tipoCuenta.ShowDialog();
        }

        private void desarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntegrantes integrantes = new FrmIntegrantes();
            integrantes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
