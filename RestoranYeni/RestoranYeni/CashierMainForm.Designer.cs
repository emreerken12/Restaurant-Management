namespace RestoranYeni
{
    partial class CashierMainForm
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cashierOrder1 = new RestoranYeni.CashierOrder();
            this.adminAddProducts1 = new RestoranYeni.AdminAddProducts();
            this.adminDashBoardForm1 = new RestoranYeni.AdminDashBoardForm();
            this.cashierCustomerForm1 = new RestoranYeni.CashierCustomerForm();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(12, 385);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(91, 40);
            this.logout_btn.TabIndex = 19;
            this.logout_btn.Text = "Giriş Yapa Dön";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(12, 211);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(91, 40);
            this.order_btn.TabIndex = 18;
            this.order_btn.Text = "Siparişler";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.Location = new System.Drawing.Point(12, 165);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(91, 40);
            this.addProducts_btn.TabIndex = 17;
            this.addProducts_btn.Text = "Ürün Ekle";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Location = new System.Drawing.Point(11, 119);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(91, 40);
            this.dashboard_btn.TabIndex = 15;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(73, 81);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(41, 13);
            this.username.TabIndex = 14;
            this.username.Text = "Kasiyer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "k Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kafe Yönetim Sistemi";
            // 
            // customer_btn
            // 
            this.customer_btn.Location = new System.Drawing.Point(12, 257);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(91, 40);
            this.customer_btn.TabIndex = 20;
            this.customer_btn.Text = "Müşteriler";
            this.customer_btn.UseVisualStyleBackColor = true;
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminDashBoardForm1);
            this.panel1.Controls.Add(this.cashierOrder1);
            this.panel1.Controls.Add(this.cashierCustomerForm1);
            this.panel1.Controls.Add(this.adminAddProducts1);
            this.panel1.Location = new System.Drawing.Point(120, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 768);
            this.panel1.TabIndex = 21;
            // 
            // cashierOrder1
            // 
            this.cashierOrder1.Location = new System.Drawing.Point(0, -3);
            this.cashierOrder1.Name = "cashierOrder1";
            this.cashierOrder1.Size = new System.Drawing.Size(1025, 760);
            this.cashierOrder1.TabIndex = 2;
            this.cashierOrder1.Load += new System.EventHandler(this.cashierOrder1_Load);
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(14, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1029, 768);
            this.adminAddProducts1.TabIndex = 1;
            this.adminAddProducts1.Load += new System.EventHandler(this.adminAddProducts1_Load);
            // 
            // adminDashBoardForm1
            // 
            this.adminDashBoardForm1.Location = new System.Drawing.Point(14, -3);
            this.adminDashBoardForm1.Name = "adminDashBoardForm1";
            this.adminDashBoardForm1.Size = new System.Drawing.Size(1029, 649);
            this.adminDashBoardForm1.TabIndex = 0;
            this.adminDashBoardForm1.Load += new System.EventHandler(this.adminDashBoardForm1_Load);
            // 
            // cashierCustomerForm1
            // 
            this.cashierCustomerForm1.Location = new System.Drawing.Point(0, -3);
            this.cashierCustomerForm1.Name = "cashierCustomerForm1";
            this.cashierCustomerForm1.Size = new System.Drawing.Size(1043, 768);
            this.cashierCustomerForm1.TabIndex = 3;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 848);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.addProducts_btn);
            this.Controls.Add(this.dashboard_btn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashierMainForm";
            this.Text = "CashierMainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Panel panel1;
        private AdminAddProducts adminAddProducts1;
        private AdminDashBoardForm adminDashBoardForm1;
        private CashierOrder cashierOrder1;
        private CashierCustomerForm cashierCustomerForm1;
    }
}