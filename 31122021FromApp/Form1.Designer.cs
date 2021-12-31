
namespace _31122021FromApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btnKalanlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1Sinav = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2Sinav = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.btn_Basarili = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(25, 242);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(75, 23);
            this.btn_Listele.TabIndex = 1;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btnKalanlar
            // 
            this.btnKalanlar.Location = new System.Drawing.Point(123, 242);
            this.btnKalanlar.Name = "btnKalanlar";
            this.btnKalanlar.Size = new System.Drawing.Size(75, 23);
            this.btnKalanlar.TabIndex = 1;
            this.btnKalanlar.Text = "Kalanlar";
            this.btnKalanlar.UseVisualStyleBackColor = true;
            this.btnKalanlar.Click += new System.EventHandler(this.btnKalanlar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci No";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(821, 24);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(119, 20);
            this.txtOgrenciNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(821, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(119, 20);
            this.txtAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(821, 76);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(119, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "1.Sınav";
            // 
            // txt1Sinav
            // 
            this.txt1Sinav.Location = new System.Drawing.Point(821, 102);
            this.txt1Sinav.Name = "txt1Sinav";
            this.txt1Sinav.Size = new System.Drawing.Size(119, 20);
            this.txt1Sinav.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(766, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "2.Sınav";
            // 
            // txt2Sinav
            // 
            this.txt2Sinav.Location = new System.Drawing.Point(821, 128);
            this.txt2Sinav.Name = "txt2Sinav";
            this.txt2Sinav.Size = new System.Drawing.Size(119, 20);
            this.txt2Sinav.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(760, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ortalama";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(821, 154);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(119, 20);
            this.txtOrtalama.TabIndex = 3;
            // 
            // btn_Basarili
            // 
            this.btn_Basarili.Location = new System.Drawing.Point(222, 242);
            this.btn_Basarili.Name = "btn_Basarili";
            this.btn_Basarili.Size = new System.Drawing.Size(75, 23);
            this.btn_Basarili.TabIndex = 1;
            this.btn_Basarili.Text = "Başarılı Olanlar";
            this.btn_Basarili.UseVisualStyleBackColor = true;
            this.btn_Basarili.Click += new System.EventHandler(this.btn_Basarili_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 303);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt2Sinav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt1Sinav);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Basarili);
            this.Controls.Add(this.btnKalanlar);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btnKalanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1Sinav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2Sinav;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button btn_Basarili;
    }
}

