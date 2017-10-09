using System;
using System.Windows.Forms;

namespace e_ponto.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenu();
            this.notificationMenu = new System.Windows.Forms.MenuItem();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkSaveCred = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _notification
            // 
            this._notification.ContextMenu = this.trayContextMenu;
            this._notification.Icon = ((System.Drawing.Icon)(resources.GetObject("_notification.Icon")));
            this._notification.Text = "e-ponto";
            this._notification.Visible = true;
            this._notification.DoubleClick += new System.EventHandler(this._notification_DoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.notificationMenu});
            // 
            // notificationMenu
            // 
            this.notificationMenu.Index = 0;
            this.notificationMenu.Text = "Sair";
            this.notificationMenu.Click += new System.EventHandler(this.dispose);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(12, 30);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(237, 20);
            this.txbLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(13, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(13, 55);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(12, 72);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(237, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(174, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkSaveCred
            // 
            this.chkSaveCred.AutoSize = true;
            this.chkSaveCred.Location = new System.Drawing.Point(12, 99);
            this.chkSaveCred.Name = "chkSaveCred";
            this.chkSaveCred.Size = new System.Drawing.Size(113, 17);
            this.chkSaveCred.TabIndex = 5;
            this.chkSaveCred.Text = "Salvar credenciais";
            this.chkSaveCred.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 134);
            this.Controls.Add(this.chkSaveCred);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "e-ponto";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbLogin;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txbSenha;
        private Button btnStart;
        private CheckBox chkSaveCred;
        private NotifyIcon _notification;
        private MenuItem notificationMenu;
        private ContextMenu trayContextMenu;
    }
}

