namespace veri_madenciligi
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
            this.lb_veri_kumesi = new System.Windows.Forms.ListBox();
            this.tb_kume_sayisi = new System.Windows.Forms.TextBox();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.txt_veri_sayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_kumeler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_veri_kumesi
            // 
            this.lb_veri_kumesi.FormattingEnabled = true;
            this.lb_veri_kumesi.Location = new System.Drawing.Point(28, 12);
            this.lb_veri_kumesi.Name = "lb_veri_kumesi";
            this.lb_veri_kumesi.Size = new System.Drawing.Size(150, 290);
            this.lb_veri_kumesi.TabIndex = 2;
            // 
            // tb_kume_sayisi
            // 
            this.tb_kume_sayisi.Location = new System.Drawing.Point(78, 443);
            this.tb_kume_sayisi.Name = "tb_kume_sayisi";
            this.tb_kume_sayisi.Size = new System.Drawing.Size(100, 20);
            this.tb_kume_sayisi.TabIndex = 3;
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(78, 469);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(100, 23);
            this.btn_hesap.TabIndex = 4;
            this.btn_hesap.Text = "Hesapla";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // txt_veri_sayisi
            // 
            this.txt_veri_sayisi.Location = new System.Drawing.Point(78, 417);
            this.txt_veri_sayisi.Name = "txt_veri_sayisi";
            this.txt_veri_sayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_veri_sayisi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "veri sayisi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "kume sayisi : ";
            // 
            // lb_kumeler
            // 
            this.lb_kumeler.FormattingEnabled = true;
            this.lb_kumeler.Location = new System.Drawing.Point(28, 308);
            this.lb_kumeler.Name = "lb_kumeler";
            this.lb_kumeler.Size = new System.Drawing.Size(150, 95);
            this.lb_kumeler.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(960, 506);
            this.Controls.Add(this.lb_kumeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_veri_sayisi);
            this.Controls.Add(this.btn_hesap);
            this.Controls.Add(this.tb_kume_sayisi);
            this.Controls.Add(this.lb_veri_kumesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_veri_kumesi;
        private System.Windows.Forms.TextBox tb_kume_sayisi;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.TextBox txt_veri_sayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_kumeler;
    }
}

