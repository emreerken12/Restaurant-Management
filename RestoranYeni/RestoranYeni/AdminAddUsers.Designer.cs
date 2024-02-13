namespace RestoranYeni
{
    partial class AdminAddUsers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminAddUsers_importBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_imageView = new System.Windows.Forms.PictureBox();
            this.adminAddUsers_clearBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_deleteBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_updateBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_addBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_status = new System.Windows.Forms.ComboBox();
            this.adminAddUsers_role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminAddUsers_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminAddUsers_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminAddUsers_importBtn);
            this.panel1.Controls.Add(this.adminAddUsers_imageView);
            this.panel1.Controls.Add(this.adminAddUsers_clearBtn);
            this.panel1.Controls.Add(this.adminAddUsers_deleteBtn);
            this.panel1.Controls.Add(this.adminAddUsers_updateBtn);
            this.panel1.Controls.Add(this.adminAddUsers_addBtn);
            this.panel1.Controls.Add(this.adminAddUsers_status);
            this.panel1.Controls.Add(this.adminAddUsers_role);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.adminAddUsers_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adminAddUsers_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 599);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // adminAddUsers_importBtn
            // 
            this.adminAddUsers_importBtn.Location = new System.Drawing.Point(80, 83);
            this.adminAddUsers_importBtn.Name = "adminAddUsers_importBtn";
            this.adminAddUsers_importBtn.Size = new System.Drawing.Size(58, 34);
            this.adminAddUsers_importBtn.TabIndex = 16;
            this.adminAddUsers_importBtn.Text = "EKLE";
            this.adminAddUsers_importBtn.UseVisualStyleBackColor = true;
            this.adminAddUsers_importBtn.Click += new System.EventHandler(this.adminAddUsers_importBtn_Click);
            // 
            // adminAddUsers_imageView
            // 
            this.adminAddUsers_imageView.Image = global::RestoranYeni.Properties.Resources.Designer;
            this.adminAddUsers_imageView.Location = new System.Drawing.Point(59, 16);
            this.adminAddUsers_imageView.Name = "adminAddUsers_imageView";
            this.adminAddUsers_imageView.Size = new System.Drawing.Size(100, 61);
            this.adminAddUsers_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddUsers_imageView.TabIndex = 15;
            this.adminAddUsers_imageView.TabStop = false;
            // 
            // adminAddUsers_clearBtn
            // 
            this.adminAddUsers_clearBtn.Location = new System.Drawing.Point(122, 328);
            this.adminAddUsers_clearBtn.Name = "adminAddUsers_clearBtn";
            this.adminAddUsers_clearBtn.Size = new System.Drawing.Size(75, 49);
            this.adminAddUsers_clearBtn.TabIndex = 14;
            this.adminAddUsers_clearBtn.Text = "TEMİZLE";
            this.adminAddUsers_clearBtn.UseVisualStyleBackColor = true;
            this.adminAddUsers_clearBtn.Click += new System.EventHandler(this.adminAddUsers_clearBtn_Click);
            // 
            // adminAddUsers_deleteBtn
            // 
            this.adminAddUsers_deleteBtn.Location = new System.Drawing.Point(21, 328);
            this.adminAddUsers_deleteBtn.Name = "adminAddUsers_deleteBtn";
            this.adminAddUsers_deleteBtn.Size = new System.Drawing.Size(75, 49);
            this.adminAddUsers_deleteBtn.TabIndex = 13;
            this.adminAddUsers_deleteBtn.Text = "SİL";
            this.adminAddUsers_deleteBtn.UseVisualStyleBackColor = true;
            this.adminAddUsers_deleteBtn.Click += new System.EventHandler(this.adminAddUsers_deleteBtn_Click);
            // 
            // adminAddUsers_updateBtn
            // 
            this.adminAddUsers_updateBtn.Location = new System.Drawing.Point(122, 273);
            this.adminAddUsers_updateBtn.Name = "adminAddUsers_updateBtn";
            this.adminAddUsers_updateBtn.Size = new System.Drawing.Size(75, 49);
            this.adminAddUsers_updateBtn.TabIndex = 12;
            this.adminAddUsers_updateBtn.Text = "GÜNCELLE";
            this.adminAddUsers_updateBtn.UseVisualStyleBackColor = true;
            this.adminAddUsers_updateBtn.Click += new System.EventHandler(this.adminAddUsers_updateBtn_Click);
            // 
            // adminAddUsers_addBtn
            // 
            this.adminAddUsers_addBtn.Location = new System.Drawing.Point(21, 273);
            this.adminAddUsers_addBtn.Name = "adminAddUsers_addBtn";
            this.adminAddUsers_addBtn.Size = new System.Drawing.Size(75, 49);
            this.adminAddUsers_addBtn.TabIndex = 11;
            this.adminAddUsers_addBtn.Text = "EKLE";
            this.adminAddUsers_addBtn.UseVisualStyleBackColor = true;
            this.adminAddUsers_addBtn.Click += new System.EventHandler(this.adminAddUsers_addBtn_Click);
            // 
            // adminAddUsers_status
            // 
            this.adminAddUsers_status.FormattingEnabled = true;
            this.adminAddUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.adminAddUsers_status.Location = new System.Drawing.Point(59, 246);
            this.adminAddUsers_status.Name = "adminAddUsers_status";
            this.adminAddUsers_status.Size = new System.Drawing.Size(138, 21);
            this.adminAddUsers_status.TabIndex = 10;
            // 
            // adminAddUsers_role
            // 
            this.adminAddUsers_role.FormattingEnabled = true;
            this.adminAddUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.adminAddUsers_role.Location = new System.Drawing.Point(59, 211);
            this.adminAddUsers_role.Name = "adminAddUsers_role";
            this.adminAddUsers_role.Size = new System.Drawing.Size(138, 21);
            this.adminAddUsers_role.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rolü:";
            // 
            // adminAddUsers_password
            // 
            this.adminAddUsers_password.Location = new System.Drawing.Point(59, 174);
            this.adminAddUsers_password.Name = "adminAddUsers_password";
            this.adminAddUsers_password.Size = new System.Drawing.Size(138, 20);
            this.adminAddUsers_password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre:";
            // 
            // adminAddUsers_username
            // 
            this.adminAddUsers_username.Location = new System.Drawing.Point(59, 139);
            this.adminAddUsers_username.Name = "adminAddUsers_username";
            this.adminAddUsers_username.Size = new System.Drawing.Size(138, 20);
            this.adminAddUsers_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "K Adı:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(223, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 548);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(710, 501);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Users";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUsers";
            this.Size = new System.Drawing.Size(936, 605);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox adminAddUsers_status;
        private System.Windows.Forms.ComboBox adminAddUsers_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminAddUsers_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminAddUsers_username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button adminAddUsers_addBtn;
        private System.Windows.Forms.Button adminAddUsers_clearBtn;
        private System.Windows.Forms.Button adminAddUsers_deleteBtn;
        private System.Windows.Forms.Button adminAddUsers_updateBtn;
        private System.Windows.Forms.Button adminAddUsers_importBtn;
        private System.Windows.Forms.PictureBox adminAddUsers_imageView;
    }
}
