namespace WinFormsFirstGUI
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
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
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.chk_ship = new System.Windows.Forms.CheckBox();
            this.lbl_ship = new System.Windows.Forms.Label();
            this.rb_plane = new System.Windows.Forms.RadioButton();
            this.rb_ship = new System.Windows.Forms.RadioButton();
            this.rb_truck = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_num.Location = new System.Drawing.Point(10, 83);
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
            this.lbl_date.Location = new System.Drawing.Point(327, 171);
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
            this.lbl_invnum.Location = new System.Drawing.Point(327, 81);
            this.lbl_invnum.Name = "lbl_invnum";
            this.lbl_invnum.Size = new System.Drawing.Size(212, 27);
            this.lbl_invnum.TabIndex = 2;
            this.lbl_invnum.Text = "Inventory Number";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num.Location = new System.Drawing.Point(117, 84);
            this.txt_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(186, 28);
            this.txt_num.TabIndex = 3;
            // 
            // txt_invnum
            // 
            this.txt_invnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_invnum.Location = new System.Drawing.Point(545, 84);
            this.txt_invnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_invnum.Name = "txt_invnum";
            this.txt_invnum.Size = new System.Drawing.Size(163, 28);
            this.txt_invnum.TabIndex = 4;
            // 
            // dt_date
            // 
            this.dt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_date.Location = new System.Drawing.Point(398, 171);
            this.dt_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(310, 28);
            this.dt_date.TabIndex = 5;
            // 
            // lbl_objname
            // 
            this.lbl_objname.AutoSize = true;
            this.lbl_objname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_objname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_objname.Location = new System.Drawing.Point(10, 127);
            this.lbl_objname.Name = "lbl_objname";
            this.lbl_objname.Size = new System.Drawing.Size(157, 27);
            this.lbl_objname.TabIndex = 6;
            this.lbl_objname.Text = "Object Name";
            // 
            // txt_objname
            // 
            this.txt_objname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_objname.Location = new System.Drawing.Point(173, 126);
            this.txt_objname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_objname.Name = "txt_objname";
            this.txt_objname.Size = new System.Drawing.Size(130, 28);
            this.txt_objname.TabIndex = 7;
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_count.Location = new System.Drawing.Point(98, 170);
            this.txt_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(205, 28);
            this.txt_count.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_price.Location = new System.Drawing.Point(396, 128);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(312, 28);
            this.txt_price.TabIndex = 9;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_count.Location = new System.Drawing.Point(13, 169);
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
            this.lbl_price.Location = new System.Drawing.Point(327, 126);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(71, 27);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_add.Location = new System.Drawing.Point(98, 375);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 34);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_clear.Location = new System.Drawing.Point(536, 375);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 34);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(187, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(352, 32);
            this.lbl_title.TabIndex = 16;
            this.lbl_title.Text = "Product Admission Form";
            // 
            // chk_ship
            // 
            this.chk_ship.AutoSize = true;
            this.chk_ship.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_ship.Location = new System.Drawing.Point(267, 219);
            this.chk_ship.Name = "chk_ship";
            this.chk_ship.Size = new System.Drawing.Size(131, 31);
            this.chk_ship.TabIndex = 18;
            this.chk_ship.Text = "Shipping";
            this.chk_ship.UseVisualStyleBackColor = true;
            this.chk_ship.CheckedChanged += new System.EventHandler(this.chk_ship_CheckedChanged);
            this.chk_ship.CheckStateChanged += new System.EventHandler(this.chk_ship_CheckedChanged);
            // 
            // lbl_ship
            // 
            this.lbl_ship.AutoSize = true;
            this.lbl_ship.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_ship.Location = new System.Drawing.Point(229, 268);
            this.lbl_ship.Name = "lbl_ship";
            this.lbl_ship.Size = new System.Drawing.Size(96, 27);
            this.lbl_ship.TabIndex = 19;
            this.lbl_ship.Text = "Ship By";
            // 
            // rb_plane
            // 
            this.rb_plane.AutoSize = true;
            this.rb_plane.Enabled = false;
            this.rb_plane.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_plane.Location = new System.Drawing.Point(346, 269);
            this.rb_plane.Name = "rb_plane";
            this.rb_plane.Size = new System.Drawing.Size(85, 27);
            this.rb_plane.TabIndex = 20;
            this.rb_plane.TabStop = true;
            this.rb_plane.Text = "Plane";
            this.rb_plane.UseVisualStyleBackColor = true;
            // 
            // rb_ship
            // 
            this.rb_ship.AutoSize = true;
            this.rb_ship.Enabled = false;
            this.rb_ship.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_ship.Location = new System.Drawing.Point(346, 302);
            this.rb_ship.Name = "rb_ship";
            this.rb_ship.Size = new System.Drawing.Size(140, 27);
            this.rb_ship.TabIndex = 21;
            this.rb_ship.TabStop = true;
            this.rb_ship.Text = "Cargo Ship";
            this.rb_ship.UseVisualStyleBackColor = true;
            // 
            // rb_truck
            // 
            this.rb_truck.AutoSize = true;
            this.rb_truck.Enabled = false;
            this.rb_truck.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_truck.Location = new System.Drawing.Point(346, 335);
            this.rb_truck.Name = "rb_truck";
            this.rb_truck.Size = new System.Drawing.Size(88, 27);
            this.rb_truck.TabIndex = 22;
            this.rb_truck.TabStop = true;
            this.rb_truck.Text = "Truck";
            this.rb_truck.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 422);
            this.ControlBox = false;
            this.Controls.Add(this.rb_truck);
            this.Controls.Add(this.rb_ship);
            this.Controls.Add(this.rb_plane);
            this.Controls.Add(this.lbl_ship);
            this.Controls.Add(this.chk_ship);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_clear);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
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
        private ErrorProvider err;
        private Button btn_clear;
        private Label lbl_title;
        private RadioButton rb_ship;
        private RadioButton rb_plane;
        private Label lbl_ship;
        private CheckBox chk_ship;
        private RadioButton rb_truck;
    }
}

