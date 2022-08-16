namespace WinFormsFirstGUI
{
    partial class HelpForm
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
            this.lbl_helpadd = new System.Windows.Forms.Label();
            this.lbl_helphelp = new System.Windows.Forms.Label();
            this.lbl_helpexit = new System.Windows.Forms.Label();
            this.lbl_helpview = new System.Windows.Forms.Label();
            this.lbl_helptitle = new System.Windows.Forms.Label();
            this.lbl_descadd = new System.Windows.Forms.Label();
            this.lbl_descview = new System.Windows.Forms.Label();
            this.lvl_deschelp = new System.Windows.Forms.Label();
            this.lbl_descexit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_helpadd
            // 
            this.lbl_helpadd.AutoSize = true;
            this.lbl_helpadd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_helpadd.Location = new System.Drawing.Point(70, 209);
            this.lbl_helpadd.Name = "lbl_helpadd";
            this.lbl_helpadd.Size = new System.Drawing.Size(196, 32);
            this.lbl_helpadd.TabIndex = 0;
            this.lbl_helpadd.Text = "Add Product:";
            // 
            // lbl_helphelp
            // 
            this.lbl_helphelp.AutoSize = true;
            this.lbl_helphelp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_helphelp.Location = new System.Drawing.Point(179, 313);
            this.lbl_helphelp.Name = "lbl_helphelp";
            this.lbl_helphelp.Size = new System.Drawing.Size(87, 32);
            this.lbl_helphelp.TabIndex = 1;
            this.lbl_helphelp.Text = "Help:";
            // 
            // lbl_helpexit
            // 
            this.lbl_helpexit.AutoSize = true;
            this.lbl_helpexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_helpexit.Location = new System.Drawing.Point(191, 363);
            this.lbl_helpexit.Name = "lbl_helpexit";
            this.lbl_helpexit.Size = new System.Drawing.Size(75, 32);
            this.lbl_helpexit.TabIndex = 2;
            this.lbl_helpexit.Text = "Exit:";
            // 
            // lbl_helpview
            // 
            this.lbl_helpview.AutoSize = true;
            this.lbl_helpview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_helpview.Location = new System.Drawing.Point(59, 263);
            this.lbl_helpview.Name = "lbl_helpview";
            this.lbl_helpview.Size = new System.Drawing.Size(207, 32);
            this.lbl_helpview.TabIndex = 3;
            this.lbl_helpview.Text = "View Product:";
            // 
            // lbl_helptitle
            // 
            this.lbl_helptitle.AutoSize = true;
            this.lbl_helptitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_helptitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_helptitle.Location = new System.Drawing.Point(19, 77);
            this.lbl_helptitle.Name = "lbl_helptitle";
            this.lbl_helptitle.Size = new System.Drawing.Size(712, 39);
            this.lbl_helptitle.TabIndex = 4;
            this.lbl_helptitle.Text = "Welcome to the Product Management App";
            // 
            // lbl_descadd
            // 
            this.lbl_descadd.AutoSize = true;
            this.lbl_descadd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_descadd.Location = new System.Drawing.Point(280, 205);
            this.lbl_descadd.Name = "lbl_descadd";
            this.lbl_descadd.Size = new System.Drawing.Size(453, 54);
            this.lbl_descadd.TabIndex = 5;
            this.lbl_descadd.Text = "The product admission form\r\nForm will be reset if you leave the menu\r\n";
            // 
            // lbl_descview
            // 
            this.lbl_descview.AutoSize = true;
            this.lbl_descview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_descview.Location = new System.Drawing.Point(280, 267);
            this.lbl_descview.Name = "lbl_descview";
            this.lbl_descview.Size = new System.Drawing.Size(323, 27);
            this.lbl_descview.TabIndex = 6;
            this.lbl_descview.Text = "Search or View all Products";
            // 
            // lvl_deschelp
            // 
            this.lvl_deschelp.AutoSize = true;
            this.lvl_deschelp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvl_deschelp.Location = new System.Drawing.Point(280, 317);
            this.lvl_deschelp.Name = "lvl_deschelp";
            this.lvl_deschelp.Size = new System.Drawing.Size(242, 27);
            this.lvl_deschelp.TabIndex = 7;
            this.lvl_deschelp.Text = "Show this help menu";
            // 
            // lbl_descexit
            // 
            this.lbl_descexit.AutoSize = true;
            this.lbl_descexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_descexit.Location = new System.Drawing.Point(280, 366);
            this.lbl_descexit.Name = "lbl_descexit";
            this.lbl_descexit.Size = new System.Drawing.Size(198, 27);
            this.lbl_descexit.TabIndex = 8;
            this.lbl_descexit.Text = "Exit the Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(159, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "(Use this guide to help you navigate)";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_descexit);
            this.Controls.Add(this.lvl_deschelp);
            this.Controls.Add(this.lbl_descview);
            this.Controls.Add(this.lbl_descadd);
            this.Controls.Add(this.lbl_helptitle);
            this.Controls.Add(this.lbl_helpview);
            this.Controls.Add(this.lbl_helpexit);
            this.Controls.Add(this.lbl_helphelp);
            this.Controls.Add(this.lbl_helpadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_helpadd;
        private Label lbl_helphelp;
        private Label lbl_helpexit;
        private Label lbl_helpview;
        private Label lbl_helptitle;
        private Label lbl_descadd;
        private Label lbl_descview;
        private Label lvl_deschelp;
        private Label lbl_descexit;
        private Label label1;
    }
}