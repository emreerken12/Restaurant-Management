namespace RestoranYeni
{
    partial class AdminDashBoardForm
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dashboard_TIn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dashboard_TI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashboard_TCust = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard_TC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(16, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 175);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dashboard_TIn);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(646, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 3;
            // 
            // dashboard_TIn
            // 
            this.dashboard_TIn.AutoSize = true;
            this.dashboard_TIn.Location = new System.Drawing.Point(3, 39);
            this.dashboard_TIn.Name = "dashboard_TIn";
            this.dashboard_TIn.Size = new System.Drawing.Size(13, 13);
            this.dashboard_TIn.TabIndex = 1;
            this.dashboard_TIn.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tüm Gelir";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dashboard_TI);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(440, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 2;
            // 
            // dashboard_TI
            // 
            this.dashboard_TI.AutoSize = true;
            this.dashboard_TI.Location = new System.Drawing.Point(3, 39);
            this.dashboard_TI.Name = "dashboard_TI";
            this.dashboard_TI.Size = new System.Drawing.Size(13, 13);
            this.dashboard_TI.TabIndex = 1;
            this.dashboard_TI.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Günlük Para";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dashboard_TCust);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(224, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 1;
            // 
            // dashboard_TCust
            // 
            this.dashboard_TCust.AutoSize = true;
            this.dashboard_TCust.Location = new System.Drawing.Point(3, 39);
            this.dashboard_TCust.Name = "dashboard_TCust";
            this.dashboard_TCust.Size = new System.Drawing.Size(13, 13);
            this.dashboard_TCust.TabIndex = 1;
            this.dashboard_TCust.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tüm Müşteriler";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard_TC);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(18, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // dashboard_TC
            // 
            this.dashboard_TC.AutoSize = true;
            this.dashboard_TC.Location = new System.Drawing.Point(3, 39);
            this.dashboard_TC.Name = "dashboard_TC";
            this.dashboard_TC.Size = new System.Drawing.Size(13, 13);
            this.dashboard_TC.TabIndex = 0;
            this.dashboard_TC.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Kasiyerler";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(16, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 368);
            this.panel2.TabIndex = 1;
            // 
            // AdminDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashBoardForm";
            this.Size = new System.Drawing.Size(890, 567);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label dashboard_TIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label dashboard_TI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dashboard_TCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label dashboard_TC;
        private System.Windows.Forms.Label label1;
    }
}
