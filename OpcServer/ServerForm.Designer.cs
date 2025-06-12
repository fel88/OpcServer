/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/


using Opc.Ua.Server.Controls;

namespace Opc.Ua.Sample
{
    partial class ServerForm 
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            TrayIcon = new System.Windows.Forms.NotifyIcon(components);
            ServerDiagnosticsCTRL = new ServerDiagnosticsCtrl();
            serverHeaderBranding1 = new HeaderBranding();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TrayIcon
            // 
            TrayIcon.Text = "TrayIcon";
            TrayIcon.Visible = true;
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;
            TrayIcon.MouseMove += TrayIcon_MouseMove;
            // 
            // ServerDiagnosticsCTRL
            // 
            ServerDiagnosticsCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
            ServerDiagnosticsCTRL.Location = new System.Drawing.Point(0, 128);
            ServerDiagnosticsCTRL.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            ServerDiagnosticsCTRL.Name = "ServerDiagnosticsCTRL";
            ServerDiagnosticsCTRL.Size = new System.Drawing.Size(820, 320);
            ServerDiagnosticsCTRL.TabIndex = 0;
            // 
            // serverHeaderBranding1
            // 
            serverHeaderBranding1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            serverHeaderBranding1.BackColor = System.Drawing.Color.White;
            serverHeaderBranding1.Dock = System.Windows.Forms.DockStyle.Top;
            serverHeaderBranding1.Location = new System.Drawing.Point(0, 24);
            serverHeaderBranding1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            serverHeaderBranding1.MaximumSize = new System.Drawing.Size(0, 115);
            serverHeaderBranding1.MinimumSize = new System.Drawing.Size(583, 104);
            serverHeaderBranding1.Name = "serverHeaderBranding1";
            serverHeaderBranding1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            serverHeaderBranding1.Size = new System.Drawing.Size(820, 104);
            serverHeaderBranding1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(820, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { contentsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            contentsToolStripMenuItem.Text = "&Contents";
            contentsToolStripMenuItem.Click += contentsToolStripMenuItem_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(820, 448);
            Controls.Add(ServerDiagnosticsCTRL);
            Controls.Add(serverHeaderBranding1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ServerForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quickstart Empty Server";
            FormClosed += ServerForm_FormClosed;
            Resize += ServerForm_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ServerDiagnosticsCtrl ServerDiagnosticsCTRL;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private HeaderBranding serverHeaderBranding1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;

    }
}
