
namespace EÖğrenci
{
    partial class FrmKulüpİslemleri
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
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonekle.ForeColor = System.Drawing.Color.White;
            this.buttonekle.Location = new System.Drawing.Point(179, 322);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(119, 39);
            this.buttonekle.TabIndex = 0;
            this.buttonekle.Text = "EKLE";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsil.ForeColor = System.Drawing.Color.White;
            this.buttonsil.Location = new System.Drawing.Point(179, 394);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(119, 39);
            this.buttonsil.TabIndex = 1;
            this.buttonsil.Text = "SİL";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.BackColor = System.Drawing.Color.SandyBrown;
            this.buttongüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttongüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongüncelle.ForeColor = System.Drawing.Color.White;
            this.buttongüncelle.Location = new System.Drawing.Point(348, 322);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(119, 39);
            this.buttongüncelle.TabIndex = 2;
            this.buttongüncelle.Text = "GÜNCELLE";
            this.buttongüncelle.UseVisualStyleBackColor = false;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.BackColor = System.Drawing.Color.SandyBrown;
            this.buttontemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttontemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontemizle.ForeColor = System.Drawing.Color.White;
            this.buttontemizle.Location = new System.Drawing.Point(348, 394);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(119, 39);
            this.buttontemizle.TabIndex = 3;
            this.buttontemizle.Text = "TEMİZLE";
            this.buttontemizle.UseVisualStyleBackColor = false;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(318, 202);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(120, 22);
            this.textBoxid.TabIndex = 4;
            // 
            // textBoxisim
            // 
            this.textBoxisim.Location = new System.Drawing.Point(318, 245);
            this.textBoxisim.Name = "textBoxisim";
            this.textBoxisim.Size = new System.Drawing.Size(120, 22);
            this.textBoxisim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kulüp İd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kulüp İsmi :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(198, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(249, 95);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "KULÜP İSLEMLERİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::EÖğrenci.Properties.Resources.icons8_close_96px;
            this.pictureBox2.Location = new System.Drawing.Point(587, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EÖğrenci.Properties.Resources.icons8_booking_96px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmKulüpİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 445);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxisim);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.buttontemizle);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKulüpİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKulüpİslemleri";
            this.Load += new System.EventHandler(this.FrmKulüpİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttongüncelle;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}