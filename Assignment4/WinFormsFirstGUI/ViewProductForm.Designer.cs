namespace WinFormsFirstGUI
{
    partial class ViewProductForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_showall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 118);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(701, 252);
            this.dgv.TabIndex = 15;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(384, 62);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(202, 34);
            this.txt_search.TabIndex = 16;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_search.Location = new System.Drawing.Point(592, 62);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 34);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(258, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(187, 32);
            this.lbl_title.TabIndex = 18;
            this.lbl_title.Text = "Products list";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_search.Location = new System.Drawing.Point(12, 88);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(0, 23);
            this.lbl_search.TabIndex = 19;
            // 
            // btn_showall
            // 
            this.btn_showall.Enabled = false;
            this.btn_showall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_showall.Location = new System.Drawing.Point(12, 377);
            this.btn_showall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(120, 34);
            this.btn_showall.TabIndex = 20;
            this.btn_showall.Text = "Show All";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // ViewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 424);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.ViewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private TextBox txt_search;
        private Button btn_search;
        private Label lbl_title;
        private Label lbl_search;
        private Button btn_showall;
    }
}