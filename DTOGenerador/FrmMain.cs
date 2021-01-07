using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DTOGenerador
{
    public partial class FrmMain : Form
    {
        private string server;
        private string user;
        private string pass;
        private string bd;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
          int nLeftRect,        // Coordenada x de la esquina superior izquierda
          int nTopRect,         // Coordenada y de la esquina superior izquierda
          int nRightRect,       // Coordenada x de la esquina inferior derecha 
          int nBottomRect,      // Coordenada y de la esquina inferior derecha 
          int nWidthEllipse,    // Altura de la elipse
          int nHeightEllipse    // Anchura de la elipse 
         );

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public FrmMain()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(Width, Height, 0, 0, 20, 20));

            cboTipo.SelectedIndex = 0;
        }

        private void PanelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            server = txtServidor.Text.Trim();
            user   = txtUsuario.Text.Trim();
            pass   = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(server))
            {
                MessageBox.Show("Ingrese el servidor", lblTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServidor.Focus();
                return;
            }

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Ingrese el usuario", lblTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Ingrese la contraseña", lblTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            if (btnConectar.Text.Equals("Conectar"))
            {
                this.Cursor = Cursors.WaitCursor;

                AddText("public class", Color.Purple);
                AddText(user, Color.Yellow);
                AddText(pass, Color.Green);

                lstBDs.Items.Clear();
                lstTablas.Items.Clear();
                txtResultado.Clear();

                ControlEstatus(true);
                
                DTOUtils utils = new DTOUtils(cboTipo.SelectedIndex);

                var databases = utils.GetDatabases(server, user, pass);
                if (databases.Item1.Equals(0))
                {
                    DataTable dtDBs = (DataTable)databases.Item2;

                    foreach (DataRow row in dtDBs.Rows)
                    {
                        lstBDs.Items.Add(row["name"], false);
                    }

                    btnConectar.Enabled = true;
                    btnConectar.Text = "Desconectar";
                    
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    ControlEstatus(false);
                    btnConectar.Text = "Conectar";
                    this.Cursor = Cursors.Default;
                    MessageBox.Show((string)databases.Item2, lblTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lstBDs.Items.Clear();
                lstTablas.Items.Clear();
                txtResultado.Clear();

                ControlEstatus(false);
                btnConectar.Text = "Conectar";
            }
        }

        private void ControlEstatus(bool estatus)
        {
            cboTipo.Enabled        = !estatus;
            txtServidor.ReadOnly   = estatus;
            txtUsuario.ReadOnly    = estatus;
            txtContrasena.ReadOnly = estatus;
            btnConectar.Enabled    = !estatus;

            if (estatus)
            {
                cboTipo.BackColor       = Color.FromArgb(28, 40, 51);
                txtServidor.BackColor   = Color.FromArgb(28, 40, 51);
                txtUsuario.BackColor    = Color.FromArgb(28, 40, 51);
                txtContrasena.BackColor = Color.FromArgb(28, 40, 51);
            }
        }

        private void LstBDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            lstTablas.Items.Clear();
            txtResultado.Clear();

            bd = lstBDs.Text.Trim();
            
            for (int i = 0; i < lstBDs.Items.Count; i++)
            {
                string item = lstBDs.Items[i].ToString();

                lstBDs.SetItemChecked(i, (bd == item));
            }

            DTOUtils utils = new DTOUtils(cboTipo.SelectedIndex);

            var tables = utils.GetTables(server, user, pass, bd);
            if (tables.Item1.Equals(0))
            {
                DataTable dtDBs = (DataTable)tables.Item2;

                foreach (DataRow row in dtDBs.Rows)
                {
                    lstTablas.Items.Add(row["name"], false);
                }

                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show((string)tables.Item2, lblTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txtResultado.Clear();

            string table = lstTablas.Text.Trim();

            for (int i = 0; i < lstTablas.Items.Count; i++)
            {
                string item = lstTablas.Items[i].ToString();

                lstTablas.SetItemChecked(i, (table == item));
            }
            
            DTOUtils utils = new DTOUtils(cboTipo.SelectedIndex);

            var tables = utils.GetEstruc(server, user, pass, bd, table);
            if (tables.Item1.Equals(0))
            {
                EstrucFormat(table, (DataTable)tables.Item2);

                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show((string)tables.Item2, lblTitulo.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstrucFormat(string table, DataTable dtDatos)
        {
            DTOUtils utils = new DTOUtils(cboTipo.SelectedIndex);

            if (dtDatos.Rows.Count > 0)
            {
                Color colorName = Color.FromArgb(212, 172, 13);
                Color colorLine = Color.FromArgb(125, 60, 152);
                Color colorDef  = Color.FromArgb(208, 211, 212);

                AddText("public class ", colorLine);
                AddText(utils.FormatName(table) + Environment.NewLine, colorName);
                AddText("{" + Environment.NewLine, colorDef);
                
                foreach (DataRow row in dtDatos.Rows)
                {
                    AddText("    public " + utils.FormatType((string)row["type"]) + " ", colorLine);
                    AddText(utils.FormatName((string)row["name"]) + " { ", colorDef);
                    AddText("get", colorLine);
                    AddText("; ", colorDef);
                    AddText("set", colorLine);
                    AddText("; }" + Environment.NewLine, colorDef);
                }
                AddText("" + Environment.NewLine, colorDef);
                AddText("    public ", colorLine);
                AddText(utils.FormatName(table), colorName);
                AddText("() { }" + Environment.NewLine, colorDef);
                AddText("}", colorDef);
            }
        }

        public void AddText(string text, Color color)
        {
            txtResultado.SelectionStart = txtResultado.TextLength;
            txtResultado.SelectionLength = 0;

            txtResultado.SelectionColor = color;
            txtResultado.AppendText(text);
            txtResultado.SelectionColor = txtResultado.ForeColor;
        }
    }
}
