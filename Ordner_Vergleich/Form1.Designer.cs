namespace Ordner_Vergleich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_folder_A = new System.Windows.Forms.Label();
            this.lbl_folder_B = new System.Windows.Forms.Label();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.cb_AnotB = new System.Windows.Forms.CheckBox();
            this.cb_AandB = new System.Windows.Forms.CheckBox();
            this.cb_BnotA = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_copyDest = new System.Windows.Forms.Label();
            this.browseCopy = new System.Windows.Forms.Button();
            this.cb_write_log = new System.Windows.Forms.CheckBox();
            this.tb_copy = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browseA = new System.Windows.Forms.Button();
            this.browseB = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.cb_subfolder_A = new System.Windows.Forms.CheckBox();
            this.cb_subfolder_B = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_abort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_folder_A
            // 
            this.lbl_folder_A.AutoSize = true;
            this.lbl_folder_A.Location = new System.Drawing.Point(6, 22);
            this.lbl_folder_A.Name = "lbl_folder_A";
            this.lbl_folder_A.Size = new System.Drawing.Size(49, 13);
            this.lbl_folder_A.TabIndex = 0;
            this.lbl_folder_A.Text = "Ordner A";
            // 
            // lbl_folder_B
            // 
            this.lbl_folder_B.AutoSize = true;
            this.lbl_folder_B.Location = new System.Drawing.Point(6, 79);
            this.lbl_folder_B.Name = "lbl_folder_B";
            this.lbl_folder_B.Size = new System.Drawing.Size(49, 13);
            this.lbl_folder_B.TabIndex = 1;
            this.lbl_folder_B.Text = "Ordner B";
            // 
            // tb_A
            // 
            this.tb_A.Location = new System.Drawing.Point(61, 19);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(253, 20);
            this.tb_A.TabIndex = 2;
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(61, 76);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(253, 20);
            this.tb_B.TabIndex = 3;
            // 
            // cb_AnotB
            // 
            this.cb_AnotB.AutoSize = true;
            this.cb_AnotB.Location = new System.Drawing.Point(15, 83);
            this.cb_AnotB.Name = "cb_AnotB";
            this.cb_AnotB.Size = new System.Drawing.Size(80, 17);
            this.cb_AnotB.TabIndex = 4;
            this.cb_AnotB.Text = "in A nicht B";
            this.cb_AnotB.UseVisualStyleBackColor = true;
            // 
            // cb_AandB
            // 
            this.cb_AandB.AutoSize = true;
            this.cb_AandB.Location = new System.Drawing.Point(239, 83);
            this.cb_AandB.Name = "cb_AandB";
            this.cb_AandB.Size = new System.Drawing.Size(75, 17);
            this.cb_AandB.TabIndex = 5;
            this.cb_AandB.Text = "in A und B";
            this.cb_AandB.UseVisualStyleBackColor = true;
            // 
            // cb_BnotA
            // 
            this.cb_BnotA.AutoSize = true;
            this.cb_BnotA.Location = new System.Drawing.Point(121, 83);
            this.cb_BnotA.Name = "cb_BnotA";
            this.cb_BnotA.Size = new System.Drawing.Size(80, 17);
            this.cb_BnotA.TabIndex = 6;
            this.cb_BnotA.Text = "in B nicht A";
            this.cb_BnotA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_copyDest);
            this.groupBox1.Controls.Add(this.browseCopy);
            this.groupBox1.Controls.Add(this.cb_write_log);
            this.groupBox1.Controls.Add(this.tb_copy);
            this.groupBox1.Controls.Add(this.cb_BnotA);
            this.groupBox1.Controls.Add(this.cb_AandB);
            this.groupBox1.Controls.Add(this.cb_AnotB);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktionen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dateien kopieren:";
            // 
            // lbl_copyDest
            // 
            this.lbl_copyDest.AutoSize = true;
            this.lbl_copyDest.Location = new System.Drawing.Point(12, 108);
            this.lbl_copyDest.Name = "lbl_copyDest";
            this.lbl_copyDest.Size = new System.Drawing.Size(34, 13);
            this.lbl_copyDest.TabIndex = 12;
            this.lbl_copyDest.Text = "nach:";
            // 
            // browseCopy
            // 
            this.browseCopy.Location = new System.Drawing.Point(320, 122);
            this.browseCopy.Name = "browseCopy";
            this.browseCopy.Size = new System.Drawing.Size(87, 23);
            this.browseCopy.TabIndex = 11;
            this.browseCopy.Text = "Durchsuchen";
            this.browseCopy.UseVisualStyleBackColor = true;
            this.browseCopy.Click += new System.EventHandler(this.browseCopy_Click);
            // 
            // cb_write_log
            // 
            this.cb_write_log.AutoSize = true;
            this.cb_write_log.Checked = true;
            this.cb_write_log.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_write_log.Location = new System.Drawing.Point(15, 24);
            this.cb_write_log.Name = "cb_write_log";
            this.cb_write_log.Size = new System.Drawing.Size(186, 17);
            this.cb_write_log.TabIndex = 13;
            this.cb_write_log.Text = "schreibe _Ergebnis.txt in Ordner A";
            this.cb_write_log.UseVisualStyleBackColor = true;
            // 
            // tb_copy
            // 
            this.tb_copy.Location = new System.Drawing.Point(15, 124);
            this.tb_copy.Name = "tb_copy";
            this.tb_copy.Size = new System.Drawing.Size(299, 20);
            this.tb_copy.TabIndex = 10;
            // 
            // browseA
            // 
            this.browseA.Location = new System.Drawing.Point(320, 17);
            this.browseA.Name = "browseA";
            this.browseA.Size = new System.Drawing.Size(87, 23);
            this.browseA.TabIndex = 8;
            this.browseA.Text = "Durchsuchen";
            this.browseA.UseVisualStyleBackColor = true;
            this.browseA.Click += new System.EventHandler(this.browseA_Click);
            // 
            // browseB
            // 
            this.browseB.Location = new System.Drawing.Point(320, 74);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(87, 23);
            this.browseB.TabIndex = 9;
            this.browseB.Text = "Durchsuchen";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(332, 362);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(87, 28);
            this.btn_go.TabIndex = 10;
            this.btn_go.Text = "Los";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter";
            // 
            // tb_filter
            // 
            this.tb_filter.Location = new System.Drawing.Point(61, 135);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(56, 20);
            this.tb_filter.TabIndex = 12;
            this.tb_filter.Text = "*.pdf";
            // 
            // cb_subfolder_A
            // 
            this.cb_subfolder_A.AutoSize = true;
            this.cb_subfolder_A.Location = new System.Drawing.Point(61, 46);
            this.cb_subfolder_A.Name = "cb_subfolder_A";
            this.cb_subfolder_A.Size = new System.Drawing.Size(239, 17);
            this.cb_subfolder_A.TabIndex = 14;
            this.cb_subfolder_A.Text = "Unterverzeichnisse miteinbeziehen (Vorsicht!)";
            this.cb_subfolder_A.UseVisualStyleBackColor = true;
            // 
            // cb_subfolder_B
            // 
            this.cb_subfolder_B.AutoSize = true;
            this.cb_subfolder_B.Location = new System.Drawing.Point(61, 102);
            this.cb_subfolder_B.Name = "cb_subfolder_B";
            this.cb_subfolder_B.Size = new System.Drawing.Size(239, 17);
            this.cb_subfolder_B.TabIndex = 15;
            this.cb_subfolder_B.Text = "Unterverzeichnisse miteinbeziehen (Vorsicht!)";
            this.cb_subfolder_B.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_info);
            this.groupBox2.Controls.Add(this.cb_subfolder_B);
            this.groupBox2.Controls.Add(this.browseB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.browseA);
            this.groupBox2.Controls.Add(this.cb_subfolder_A);
            this.groupBox2.Controls.Add(this.tb_filter);
            this.groupBox2.Controls.Add(this.lbl_folder_A);
            this.groupBox2.Controls.Add(this.lbl_folder_B);
            this.groupBox2.Controls.Add(this.tb_A);
            this.groupBox2.Controls.Add(this.tb_B);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 168);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dateien";
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(332, 135);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(75, 23);
            this.btn_info.TabIndex = 16;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(0, 392);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(34, 13);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Bereit";
            // 
            // btn_abort
            // 
            this.btn_abort.Enabled = false;
            this.btn_abort.Location = new System.Drawing.Point(239, 362);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(87, 28);
            this.btn_abort.TabIndex = 18;
            this.btn_abort.Text = "abbrechen";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 406);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inhaltsvergleich";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_folder_A;
        private System.Windows.Forms.Label lbl_folder_B;
        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.CheckBox cb_AnotB;
        private System.Windows.Forms.CheckBox cb_AandB;
        private System.Windows.Forms.CheckBox cb_BnotA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browseA;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.Label lbl_copyDest;
        private System.Windows.Forms.Button browseCopy;
        private System.Windows.Forms.TextBox tb_copy;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.CheckBox cb_write_log;
        private System.Windows.Forms.CheckBox cb_subfolder_A;
        private System.Windows.Forms.CheckBox cb_subfolder_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_abort;
    }
}

