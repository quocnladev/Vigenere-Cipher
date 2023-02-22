namespace ProjectX
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Vigenere_btnClear = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Vigenere_btnChonKhoaFileBanma = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Vigenere_txtKhoaBanma = new System.Windows.Forms.TextBox();
            this.Vigenere_btnLuuFileBanma = new System.Windows.Forms.Button();
            this.Vigenere_btnChonFileBanma = new System.Windows.Forms.Button();
            this.Vigenere_txtBanma = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Vigenere_btnChonKhoafileBanro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Vigenere_txtKhoaBanro = new System.Windows.Forms.TextBox();
            this.Vigenere_btnLuuFileBanro = new System.Windows.Forms.Button();
            this.Vigenere_btnChonfileBanro = new System.Windows.Forms.Button();
            this.Vigenere_txtBanro = new System.Windows.Forms.TextBox();
            this.Vigenere_btnMahoa = new System.Windows.Forms.Button();
            this.Vigenere_btnGiaima = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Vigenere_btnClear);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.Vigenere_btnMahoa);
            this.tabPage5.Controls.Add(this.Vigenere_btnGiaima);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(932, 445);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Vigenère";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Vigenere_btnClear
            // 
            this.Vigenere_btnClear.Image = global::ProjectX.Properties.Resources.Refresh;
            this.Vigenere_btnClear.Location = new System.Drawing.Point(435, 133);
            this.Vigenere_btnClear.Name = "Vigenere_btnClear";
            this.Vigenere_btnClear.Size = new System.Drawing.Size(68, 68);
            this.Vigenere_btnClear.TabIndex = 6;
            this.Vigenere_btnClear.UseVisualStyleBackColor = true;
            this.Vigenere_btnClear.Click += new System.EventHandler(this.Vigenere_btnClear_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.Vigenere_btnChonKhoaFileBanma);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.Vigenere_txtKhoaBanma);
            this.groupBox6.Controls.Add(this.Vigenere_btnLuuFileBanma);
            this.groupBox6.Controls.Add(this.Vigenere_btnChonFileBanma);
            this.groupBox6.Controls.Add(this.Vigenere_txtBanma);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox6.Location = new System.Drawing.Point(509, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(420, 439);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bản mật mã";
            // 
            // Vigenere_btnChonKhoaFileBanma
            // 
            this.Vigenere_btnChonKhoaFileBanma.BackColor = System.Drawing.Color.Transparent;
            this.Vigenere_btnChonKhoaFileBanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Vigenere_btnChonKhoaFileBanma.Location = new System.Drawing.Point(9, 391);
            this.Vigenere_btnChonKhoaFileBanma.Name = "Vigenere_btnChonKhoaFileBanma";
            this.Vigenere_btnChonKhoaFileBanma.Size = new System.Drawing.Size(103, 36);
            this.Vigenere_btnChonKhoaFileBanma.TabIndex = 4;
            this.Vigenere_btnChonKhoaFileBanma.Text = "Chọn tập tin";
            this.Vigenere_btnChonKhoaFileBanma.UseVisualStyleBackColor = false;
            this.Vigenere_btnChonKhoaFileBanma.Click += new System.EventHandler(this.Vigenere_btnChonKhoaFileBanma_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(6, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Khóa:";
            // 
            // Vigenere_txtKhoaBanma
            // 
            this.Vigenere_txtKhoaBanma.Location = new System.Drawing.Point(118, 391);
            this.Vigenere_txtKhoaBanma.Multiline = true;
            this.Vigenere_txtKhoaBanma.Name = "Vigenere_txtKhoaBanma";
            this.Vigenere_txtKhoaBanma.Size = new System.Drawing.Size(164, 34);
            this.Vigenere_txtKhoaBanma.TabIndex = 2;
            // 
            // Vigenere_btnLuuFileBanma
            // 
            this.Vigenere_btnLuuFileBanma.BackColor = System.Drawing.Color.Silver;
            this.Vigenere_btnLuuFileBanma.Location = new System.Drawing.Point(332, 391);
            this.Vigenere_btnLuuFileBanma.Name = "Vigenere_btnLuuFileBanma";
            this.Vigenere_btnLuuFileBanma.Size = new System.Drawing.Size(82, 36);
            this.Vigenere_btnLuuFileBanma.TabIndex = 1;
            this.Vigenere_btnLuuFileBanma.Text = "Lưu";
            this.Vigenere_btnLuuFileBanma.UseVisualStyleBackColor = false;
            this.Vigenere_btnLuuFileBanma.Click += new System.EventHandler(this.Vigenere_btnLuuFileBanma_Click);
            // 
            // Vigenere_btnChonFileBanma
            // 
            this.Vigenere_btnChonFileBanma.BackColor = System.Drawing.Color.Transparent;
            this.Vigenere_btnChonFileBanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Vigenere_btnChonFileBanma.Location = new System.Drawing.Point(6, 305);
            this.Vigenere_btnChonFileBanma.Name = "Vigenere_btnChonFileBanma";
            this.Vigenere_btnChonFileBanma.Size = new System.Drawing.Size(103, 36);
            this.Vigenere_btnChonFileBanma.TabIndex = 1;
            this.Vigenere_btnChonFileBanma.Text = "Chọn tập tin";
            this.Vigenere_btnChonFileBanma.UseVisualStyleBackColor = false;
            this.Vigenere_btnChonFileBanma.Click += new System.EventHandler(this.Vigenere_btnChonFileBanma_Click);
            // 
            // Vigenere_txtBanma
            // 
            this.Vigenere_txtBanma.Location = new System.Drawing.Point(6, 19);
            this.Vigenere_txtBanma.Multiline = true;
            this.Vigenere_txtBanma.Name = "Vigenere_txtBanma";
            this.Vigenere_txtBanma.Size = new System.Drawing.Size(408, 280);
            this.Vigenere_txtBanma.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.Vigenere_btnChonKhoafileBanro);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.Vigenere_txtKhoaBanro);
            this.groupBox5.Controls.Add(this.Vigenere_btnLuuFileBanro);
            this.groupBox5.Controls.Add(this.Vigenere_btnChonfileBanro);
            this.groupBox5.Controls.Add(this.Vigenere_txtBanro);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 439);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bản rõ";
            // 
            // Vigenere_btnChonKhoafileBanro
            // 
            this.Vigenere_btnChonKhoafileBanro.BackColor = System.Drawing.Color.Transparent;
            this.Vigenere_btnChonKhoafileBanro.Location = new System.Drawing.Point(6, 391);
            this.Vigenere_btnChonKhoafileBanro.Name = "Vigenere_btnChonKhoafileBanro";
            this.Vigenere_btnChonKhoafileBanro.Size = new System.Drawing.Size(103, 36);
            this.Vigenere_btnChonKhoafileBanro.TabIndex = 4;
            this.Vigenere_btnChonKhoafileBanro.Text = "Chọn tập tin";
            this.Vigenere_btnChonKhoafileBanro.UseVisualStyleBackColor = false;
            this.Vigenere_btnChonKhoafileBanro.Click += new System.EventHandler(this.Vigenere_btnChonKhoafileBanro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khóa:";
            // 
            // Vigenere_txtKhoaBanro
            // 
            this.Vigenere_txtKhoaBanro.Location = new System.Drawing.Point(115, 393);
            this.Vigenere_txtKhoaBanro.Multiline = true;
            this.Vigenere_txtKhoaBanro.Name = "Vigenere_txtKhoaBanro";
            this.Vigenere_txtKhoaBanro.Size = new System.Drawing.Size(164, 34);
            this.Vigenere_txtKhoaBanro.TabIndex = 2;
            // 
            // Vigenere_btnLuuFileBanro
            // 
            this.Vigenere_btnLuuFileBanro.BackColor = System.Drawing.Color.Silver;
            this.Vigenere_btnLuuFileBanro.Location = new System.Drawing.Point(332, 393);
            this.Vigenere_btnLuuFileBanro.Name = "Vigenere_btnLuuFileBanro";
            this.Vigenere_btnLuuFileBanro.Size = new System.Drawing.Size(82, 36);
            this.Vigenere_btnLuuFileBanro.TabIndex = 1;
            this.Vigenere_btnLuuFileBanro.Text = "Lưu";
            this.Vigenere_btnLuuFileBanro.UseVisualStyleBackColor = false;
            this.Vigenere_btnLuuFileBanro.Click += new System.EventHandler(this.Vigenere_btnLuuFileBanro_Click);
            // 
            // Vigenere_btnChonfileBanro
            // 
            this.Vigenere_btnChonfileBanro.BackColor = System.Drawing.Color.Transparent;
            this.Vigenere_btnChonfileBanro.Location = new System.Drawing.Point(6, 305);
            this.Vigenere_btnChonfileBanro.Name = "Vigenere_btnChonfileBanro";
            this.Vigenere_btnChonfileBanro.Size = new System.Drawing.Size(103, 36);
            this.Vigenere_btnChonfileBanro.TabIndex = 1;
            this.Vigenere_btnChonfileBanro.Text = "Chọn tập tin";
            this.Vigenere_btnChonfileBanro.UseVisualStyleBackColor = false;
            this.Vigenere_btnChonfileBanro.Click += new System.EventHandler(this.Vigenere_btnChonfileBanro_Click);
            // 
            // Vigenere_txtBanro
            // 
            this.Vigenere_txtBanro.Location = new System.Drawing.Point(6, 19);
            this.Vigenere_txtBanro.Multiline = true;
            this.Vigenere_txtBanro.Name = "Vigenere_txtBanro";
            this.Vigenere_txtBanro.Size = new System.Drawing.Size(408, 280);
            this.Vigenere_txtBanro.TabIndex = 0;
            // 
            // Vigenere_btnMahoa
            // 
            this.Vigenere_btnMahoa.Image = global::ProjectX.Properties.Resources.Arrow_Left1;
            this.Vigenere_btnMahoa.Location = new System.Drawing.Point(434, 87);
            this.Vigenere_btnMahoa.Name = "Vigenere_btnMahoa";
            this.Vigenere_btnMahoa.Size = new System.Drawing.Size(68, 40);
            this.Vigenere_btnMahoa.TabIndex = 3;
            this.Vigenere_btnMahoa.UseVisualStyleBackColor = true;
            this.Vigenere_btnMahoa.Click += new System.EventHandler(this.Vigenere_btnMahoa_Click);
            // 
            // Vigenere_btnGiaima
            // 
            this.Vigenere_btnGiaima.Image = global::ProjectX.Properties.Resources.Arrow_Right;
            this.Vigenere_btnGiaima.Location = new System.Drawing.Point(435, 207);
            this.Vigenere_btnGiaima.Name = "Vigenere_btnGiaima";
            this.Vigenere_btnGiaima.Size = new System.Drawing.Size(68, 40);
            this.Vigenere_btnGiaima.TabIndex = 4;
            this.Vigenere_btnGiaima.Text = " ";
            this.Vigenere_btnGiaima.UseVisualStyleBackColor = true;
            this.Vigenere_btnGiaima.Click += new System.EventHandler(this.Vigenere_btnGiaima_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 471);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(961, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mật mã Vigenere ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button Vigenere_btnClear;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Vigenere_txtKhoaBanma;
        private System.Windows.Forms.Button Vigenere_btnLuuFileBanma;
        private System.Windows.Forms.Button Vigenere_btnChonFileBanma;
        private System.Windows.Forms.TextBox Vigenere_txtBanma;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Vigenere_txtKhoaBanro;
        private System.Windows.Forms.Button Vigenere_btnLuuFileBanro;
        private System.Windows.Forms.Button Vigenere_btnChonfileBanro;
        private System.Windows.Forms.TextBox Vigenere_txtBanro;
        private System.Windows.Forms.Button Vigenere_btnGiaima;
        private System.Windows.Forms.Button Vigenere_btnMahoa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Vigenere_btnChonKhoafileBanro;
        private System.Windows.Forms.Button Vigenere_btnChonKhoaFileBanma;
    }
}