using System;
using System.Windows.Forms;
using e_ponto.Classes;
using e_ponto.Handlers;

namespace e_ponto.Forms
{
    public partial class MainForm : Form
    {
        private SchedHandler sh;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
        //
        // Events
        //
        private void _notification_DoubleClick(object Sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
                Hide();
            }
            Activate();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (sh == null)
            {
                StartWatcher();
            }
            else
            {
                EndWatcher();
            }
        }

        private void StartWatcher()
        {
            txbLogin.Enabled = txbSenha.Enabled = false;
            btnStart.Text = @"Finalizar";
            try
            {
                sh = new SchedHandler(new Conn(new Credentials { User = txbLogin.Text, Pass = txbSenha.Text }));
                sh.StartWatcher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EndWatcher();
            }
        }

        private void EndWatcher()
        {
            txbLogin.Enabled = txbSenha.Enabled = true;
            sh.StopWatcher();
            sh = null;
            btnStart.Text = @"Iniciar";
        }

        private void dispose(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion
    }
}
