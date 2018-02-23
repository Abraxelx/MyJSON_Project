namespace MyJSON_Project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtCarSeries = new System.Windows.Forms.TextBox();
            this.txtCarAge = new System.Windows.Forms.TextBox();
            this.txtCarColor = new System.Windows.Forms.TextBox();
            this.btnSaveDatas = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(174, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARABALAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araba Markası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Araba Serisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Araba Modeli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Araba Rengi";
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(153, 71);
            this.txtCarName.Multiline = true;
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(257, 20);
            this.txtCarName.TabIndex = 5;
            // 
            // txtCarSeries
            // 
            this.txtCarSeries.Location = new System.Drawing.Point(153, 134);
            this.txtCarSeries.Multiline = true;
            this.txtCarSeries.Name = "txtCarSeries";
            this.txtCarSeries.Size = new System.Drawing.Size(257, 20);
            this.txtCarSeries.TabIndex = 6;
            // 
            // txtCarAge
            // 
            this.txtCarAge.Location = new System.Drawing.Point(153, 186);
            this.txtCarAge.Multiline = true;
            this.txtCarAge.Name = "txtCarAge";
            this.txtCarAge.Size = new System.Drawing.Size(257, 19);
            this.txtCarAge.TabIndex = 7;
            // 
            // txtCarColor
            // 
            this.txtCarColor.Location = new System.Drawing.Point(153, 243);
            this.txtCarColor.Multiline = true;
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.Size = new System.Drawing.Size(257, 20);
            this.txtCarColor.TabIndex = 8;
            // 
            // btnSaveDatas
            // 
            this.btnSaveDatas.Location = new System.Drawing.Point(153, 278);
            this.btnSaveDatas.Name = "btnSaveDatas";
            this.btnSaveDatas.Size = new System.Drawing.Size(121, 44);
            this.btnSaveDatas.TabIndex = 9;
            this.btnSaveDatas.Text = "Save All Datas";
            this.btnSaveDatas.UseVisualStyleBackColor = true;
            this.btnSaveDatas.Click += new System.EventHandler(this.btnSaveDatas_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(280, 278);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(130, 44);
            this.btnLoadData.TabIndex = 10;
            this.btnLoadData.Text = "Load All Datas";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 348);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveDatas);
            this.Controls.Add(this.txtCarColor);
            this.Controls.Add(this.txtCarAge);
            this.Controls.Add(this.txtCarSeries);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtCarSeries;
        private System.Windows.Forms.TextBox txtCarAge;
        private System.Windows.Forms.TextBox txtCarColor;
        private System.Windows.Forms.Button btnSaveDatas;
        private System.Windows.Forms.Button btnLoadData;
    }
}

