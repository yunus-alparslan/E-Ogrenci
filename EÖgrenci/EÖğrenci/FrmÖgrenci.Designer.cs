
namespace EÖğrenci
{
    partial class FrmÖgrenci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxisim = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxKulüp = new System.Windows.Forms.ComboBox();
            this.textBoxara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(53, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(570, 95);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "ÖĞRENCİ İSLEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Öğrenci İsmi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Öğrenci İd :";
            // 
            // textBoxisim
            // 
            this.textBoxisim.Location = new System.Drawing.Point(191, 240);
            this.textBoxisim.Name = "textBoxisim";
            this.textBoxisim.Size = new System.Drawing.Size(134, 22);
            this.textBoxisim.TabIndex = 29;
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(191, 197);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(134, 22);
            this.textBoxid.TabIndex = 28;
            // 
            // buttontemizle
            // 
            this.buttontemizle.BackColor = System.Drawing.Color.SandyBrown;
            this.buttontemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttontemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontemizle.ForeColor = System.Drawing.Color.White;
            this.buttontemizle.Location = new System.Drawing.Point(352, 437);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(134, 39);
            this.buttontemizle.TabIndex = 27;
            this.buttontemizle.Text = "TEMİZLE";
            this.buttontemizle.UseVisualStyleBackColor = false;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.BackColor = System.Drawing.Color.SandyBrown;
            this.buttongüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttongüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongüncelle.ForeColor = System.Drawing.Color.White;
            this.buttongüncelle.Location = new System.Drawing.Point(352, 365);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(134, 39);
            this.buttongüncelle.TabIndex = 26;
            this.buttongüncelle.Text = "GÜNCELLE";
            this.buttongüncelle.UseVisualStyleBackColor = false;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsil.ForeColor = System.Drawing.Color.White;
            this.buttonsil.Location = new System.Drawing.Point(161, 437);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(134, 39);
            this.buttonsil.TabIndex = 25;
            this.buttonsil.Text = "SİL";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonekle.ForeColor = System.Drawing.Color.White;
            this.buttonekle.Location = new System.Drawing.Point(161, 365);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(134, 39);
            this.buttonekle.TabIndex = 24;
            this.buttonekle.Text = "EKLE";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Öğrenci SoyAd :";
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(495, 197);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(134, 22);
            this.textBoxsoyad.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Öğrenci Kulüp:";
            // 
            // comboBoxcinsiyet
            // 
            this.comboBoxcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcinsiyet.FormattingEnabled = true;
            this.comboBoxcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxcinsiyet.Location = new System.Drawing.Point(193, 281);
            this.comboBoxcinsiyet.Name = "comboBoxcinsiyet";
            this.comboBoxcinsiyet.Size = new System.Drawing.Size(130, 24);
            this.comboBoxcinsiyet.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Öğrenci Cinsiyet :";
            // 
            // comboBoxKulüp
            // 
            this.comboBoxKulüp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKulüp.FormattingEnabled = true;
            this.comboBoxKulüp.Location = new System.Drawing.Point(495, 236);
            this.comboBoxKulüp.Name = "comboBoxKulüp";
            this.comboBoxKulüp.Size = new System.Drawing.Size(134, 24);
            this.comboBoxKulüp.TabIndex = 38;
            // 
            // textBoxara
            // 
            this.textBoxara.Location = new System.Drawing.Point(495, 280);
            this.textBoxara.Name = "textBoxara";
            this.textBoxara.Size = new System.Drawing.Size(134, 22);
            this.textBoxara.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(517, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 40;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ara";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EÖğrenci.Properties.Resources.icons8_close_96px;
            this.pictureBox3.Location = new System.Drawing.Point(578, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EÖğrenci.Properties.Resources.icons8_literature_96px;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmÖgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 514);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxara);
            this.Controls.Add(this.comboBoxKulüp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxcinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxisim);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.buttontemizle);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmÖgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmÖgrenci";
            this.Load += new System.EventHandler(this.FrmÖgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxisim;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.Button buttongüncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxKulüp;
        private System.Windows.Forms.TextBox textBoxara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}