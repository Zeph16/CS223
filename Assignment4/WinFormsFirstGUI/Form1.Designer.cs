namespace WinFormsFirstGUI
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
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_invnum = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_invnum = new System.Windows.Forms.TextBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_objname = new System.Windows.Forms.Label();
            this.txt_objname = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_num.Location = new System.Drawing.Point(26, 46);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(101, 27);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_date.Location = new System.Drawing.Point(157, 46);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(65, 27);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_invnum
            // 
            this.lbl_invnum.AutoSize = true;
            this.lbl_invnum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_invnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_invnum.Location = new System.Drawing.Point(505, 46);
            this.lbl_invnum.Name = "lbl_invnum";
            this.lbl_invnum.Size = new System.Drawing.Size(212, 27);
            this.lbl_invnum.TabIndex = 2;
            this.lbl_invnum.Text = "Inventory Number";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num.Location = new System.Drawing.Point(29, 79);
            this.txt_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 28);
            this.txt_num.TabIndex = 3;
            // 
            // txt_invnum
            // 
            this.txt_invnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_invnum.Location = new System.Drawing.Point(505, 81);
            this.txt_invnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_invnum.Name = "txt_invnum";
            this.txt_invnum.Size = new System.Drawing.Size(163, 28);
            this.txt_invnum.TabIndex = 4;
            // 
            // dt_date
            // 
            this.dt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_date.Location = new System.Drawing.Point(157, 79);
            this.dt_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(324, 28);
            this.dt_date.TabIndex = 5;
            // 
            // lbl_objname
            // 
            this.lbl_objname.AutoSize = true;
            this.lbl_objname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_objname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_objname.Location = new System.Drawing.Point(26, 144);
            this.lbl_objname.Name = "lbl_objname";
            this.lbl_objname.Size = new System.Drawing.Size(157, 27);
            this.lbl_objname.TabIndex = 6;
            this.lbl_objname.Text = "Object Name";
            // 
            // txt_objname
            // 
            this.txt_objname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_objname.Location = new System.Drawing.Point(26, 177);
            this.txt_objname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_objname.Name = "txt_objname";
            this.txt_objname.Size = new System.Drawing.Size(642, 28);
            this.txt_objname.TabIndex = 7;
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_count.Location = new System.Drawing.Point(29, 268);
            this.txt_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 28);
            this.txt_count.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_price.Location = new System.Drawing.Point(234, 268);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 28);
            this.txt_price.TabIndex = 9;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_count.Location = new System.Drawing.Point(29, 235);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(79, 27);
            this.lbl_count.TabIndex = 10;
            this.lbl_count.Text = "Count";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_price.Location = new System.Drawing.Point(234, 235);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(71, 27);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_add.Location = new System.Drawing.Point(157, 326);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 34);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancel.Location = new System.Drawing.Point(405, 326);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(133, 34);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 421);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_objname);
            this.Controls.Add(this.lbl_objname);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.txt_invnum);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_invnum);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_num);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_invnum;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_invnum;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label lbl_objname;
        private System.Windows.Forms.TextBox txt_objname;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
    }
}

