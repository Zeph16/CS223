namespace Product_Management
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ram = new System.Windows.Forms.Button();
            this.btn_mysql = new System.Windows.Forms.Button();
            this.btn_mssql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ram
            // 
            this.btn_ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.btn_ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ram.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btn_ram.Location = new System.Drawing.Point(445, 184);
            this.btn_ram.Name = "btn_ram";
            this.btn_ram.Size = new System.Drawing.Size(184, 60);
            this.btn_ram.TabIndex = 0;
            this.btn_ram.Text = "RAM (Lists)";
            this.btn_ram.UseVisualStyleBackColor = false;
            this.btn_ram.Click += new System.EventHandler(this.btn_ram_Click);
            this.btn_ram.MouseEnter += new System.EventHandler(this.btn_ram_MouseEnter);
            this.btn_ram.MouseLeave += new System.EventHandler(this.btn_ram_MouseLeave);
            // 
            // btn_mysql
            // 
            this.btn_mysql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.btn_mysql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mysql.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mysql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btn_mysql.Location = new System.Drawing.Point(242, 184);
            this.btn_mysql.Name = "btn_mysql";
            this.btn_mysql.Size = new System.Drawing.Size(184, 61);
            this.btn_mysql.TabIndex = 1;
            this.btn_mysql.Text = "MySQL Server";
            this.btn_mysql.UseVisualStyleBackColor = false;
            this.btn_mysql.Click += new System.EventHandler(this.btn_mysql_Click);
            this.btn_mysql.MouseEnter += new System.EventHandler(this.btn_mysql_MouseEnter);
            this.btn_mysql.MouseLeave += new System.EventHandler(this.btn_mysql_MouseLeave);
            // 
            // btn_mssql
            // 
            this.btn_mssql.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mssql.AutoSize = true;
            this.btn_mssql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.btn_mssql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mssql.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mssql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btn_mssql.Location = new System.Drawing.Point(32, 184);
            this.btn_mssql.Name = "btn_mssql";
            this.btn_mssql.Size = new System.Drawing.Size(190, 61);
            this.btn_mssql.TabIndex = 2;
            this.btn_mssql.Text = "MSSQL Server";
            this.btn_mssql.UseVisualStyleBackColor = false;
            this.btn_mssql.Click += new System.EventHandler(this.btn_mssql_Click);
            this.btn_mssql.MouseEnter += new System.EventHandler(this.btn_mssql_MouseEnter);
            this.btn_mssql.MouseLeave += new System.EventHandler(this.btn_mssql_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a means of storage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(635, 87);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Management";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(242, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Requires a Local MySQL Server";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(32, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 53);
            this.label4.TabIndex = 6;
            this.label4.Text = "Requires a Local MSSQL Server";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(445, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 64);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saved products will be discarded once you exit the program";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lbl_status.Location = new System.Drawing.Point(12, 323);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(635, 30);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(659, 358);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mssql);
            this.Controls.Add(this.btn_mysql);
            this.Controls.Add(this.btn_ram);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Storage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ram;
        private Button btn_mysql;
        private Button btn_mssql;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lbl_status;
    }
}