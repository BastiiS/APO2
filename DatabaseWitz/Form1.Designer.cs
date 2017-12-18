namespace DatabaseWitz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnection = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.Anzeigen = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(13, 13);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(133, 33);
            this.buttonConnection.TabIndex = 0;
            this.buttonConnection.Text = "Connection";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1050, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(13, 53);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(133, 40);
            this.buttonCommand.TabIndex = 2;
            this.buttonCommand.Text = "Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // Anzeigen
            // 
            this.Anzeigen.Location = new System.Drawing.Point(13, 100);
            this.Anzeigen.Name = "Anzeigen";
            this.Anzeigen.Size = new System.Drawing.Size(133, 40);
            this.Anzeigen.TabIndex = 3;
            this.Anzeigen.Text = "Reader";
            this.Anzeigen.UseVisualStyleBackColor = true;
            this.Anzeigen.Click += new System.EventHandler(this.Anzeigen_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(153, 13);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(206, 394);
            this.listBoxAusgabe.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(33, 178);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 551);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.Anzeigen);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonConnection);
            this.Name = "Form1";
            this.Text = "OleDb-Zugriff";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button Anzeigen;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

