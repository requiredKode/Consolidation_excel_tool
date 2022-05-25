namespace FolderWatcher
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Txt_Watcher = new System.Windows.Forms.TextBox();
            this.btn_checkfiles = new System.Windows.Forms.Button();
            this.txt_processed = new System.Windows.Forms.TextBox();
            this.btn_processed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_monitor_folder = new System.Windows.Forms.TextBox();
            this.btn_monitoring = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btndest = new System.Windows.Forms.Button();
            this.txt_not_appl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fbd2 = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd3 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_masterbook_route = new System.Windows.Forms.TextBox();
            this.btn_masterbook_route = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fbd4 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // Txt_Watcher
            // 
            this.Txt_Watcher.Location = new System.Drawing.Point(12, 227);
            this.Txt_Watcher.Multiline = true;
            this.Txt_Watcher.Name = "Txt_Watcher";
            this.Txt_Watcher.Size = new System.Drawing.Size(550, 241);
            this.Txt_Watcher.TabIndex = 0;
            // 
            // btn_checkfiles
            // 
            this.btn_checkfiles.Location = new System.Drawing.Point(202, 191);
            this.btn_checkfiles.Name = "btn_checkfiles";
            this.btn_checkfiles.Size = new System.Drawing.Size(121, 30);
            this.btn_checkfiles.TabIndex = 1;
            this.btn_checkfiles.Text = "Check files";
            this.btn_checkfiles.UseVisualStyleBackColor = true;
            this.btn_checkfiles.Click += new System.EventHandler(this.btn_checkfiles_Click);
            // 
            // txt_processed
            // 
            this.txt_processed.Location = new System.Drawing.Point(173, 50);
            this.txt_processed.Name = "txt_processed";
            this.txt_processed.Size = new System.Drawing.Size(249, 20);
            this.txt_processed.TabIndex = 2;
            // 
            // btn_processed
            // 
            this.btn_processed.Location = new System.Drawing.Point(428, 48);
            this.btn_processed.Name = "btn_processed";
            this.btn_processed.Size = new System.Drawing.Size(134, 23);
            this.btn_processed.TabIndex = 3;
            this.btn_processed.Text = "Select folder";
            this.btn_processed.UseVisualStyleBackColor = true;
            this.btn_processed.Click += new System.EventHandler(this.btn_root_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Processed Folder";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // txt_monitor_folder
            // 
            this.txt_monitor_folder.Location = new System.Drawing.Point(173, 15);
            this.txt_monitor_folder.Name = "txt_monitor_folder";
            this.txt_monitor_folder.Size = new System.Drawing.Size(249, 20);
            this.txt_monitor_folder.TabIndex = 5;
            // 
            // btn_monitoring
            // 
            this.btn_monitoring.Location = new System.Drawing.Point(428, 12);
            this.btn_monitoring.Name = "btn_monitoring";
            this.btn_monitoring.Size = new System.Drawing.Size(134, 23);
            this.btn_monitoring.TabIndex = 6;
            this.btn_monitoring.Text = "Select Folder";
            this.btn_monitoring.UseVisualStyleBackColor = true;
            this.btn_monitoring.Click += new System.EventHandler(this.btn_watch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monitoring Folder:";
            // 
            // btndest
            // 
            this.btndest.Location = new System.Drawing.Point(428, 85);
            this.btndest.Name = "btndest";
            this.btndest.Size = new System.Drawing.Size(134, 23);
            this.btndest.TabIndex = 8;
            this.btndest.Text = "Select Folder";
            this.btndest.UseVisualStyleBackColor = true;
            this.btndest.Click += new System.EventHandler(this.btndest_Click);
            // 
            // txt_not_appl
            // 
            this.txt_not_appl.Location = new System.Drawing.Point(173, 87);
            this.txt_not_appl.Name = "txt_not_appl";
            this.txt_not_appl.Size = new System.Drawing.Size(249, 20);
            this.txt_not_appl.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Not Applicable Folder";
            // 
            // txt_masterbook_route
            // 
            this.txt_masterbook_route.Location = new System.Drawing.Point(173, 123);
            this.txt_masterbook_route.Name = "txt_masterbook_route";
            this.txt_masterbook_route.Size = new System.Drawing.Size(249, 20);
            this.txt_masterbook_route.TabIndex = 11;
            // 
            // btn_masterbook_route
            // 
            this.btn_masterbook_route.Location = new System.Drawing.Point(429, 121);
            this.btn_masterbook_route.Name = "btn_masterbook_route";
            this.btn_masterbook_route.Size = new System.Drawing.Size(134, 23);
            this.btn_masterbook_route.TabIndex = 12;
            this.btn_masterbook_route.Text = "Select Folder";
            this.btn_masterbook_route.UseVisualStyleBackColor = true;
            this.btn_masterbook_route.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select the MasterBook route";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_masterbook_route);
            this.Controls.Add(this.txt_masterbook_route);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_not_appl);
            this.Controls.Add(this.btndest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_monitoring);
            this.Controls.Add(this.txt_monitor_folder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_processed);
            this.Controls.Add(this.txt_processed);
            this.Controls.Add(this.btn_checkfiles);
            this.Controls.Add(this.Txt_Watcher);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox Txt_Watcher;
        private System.Windows.Forms.Button btn_checkfiles;
        private System.Windows.Forms.Button btn_monitoring;
        private System.Windows.Forms.TextBox txt_monitor_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_processed;
        private System.Windows.Forms.TextBox txt_processed;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndest;
        private System.Windows.Forms.TextBox txt_not_appl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fbd2;
        private System.Windows.Forms.FolderBrowserDialog fbd3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_masterbook_route;
        private System.Windows.Forms.TextBox txt_masterbook_route;
        private System.Windows.Forms.FolderBrowserDialog fbd4;
    }
}

