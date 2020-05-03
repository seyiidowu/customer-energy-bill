namespace Customer_Energy_Bill
{
    partial class frmCalculateEnergyBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculateEnergyBill));
            this.lblNumofKWh = new System.Windows.Forms.Label();
            this.txtNumofKWh = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cmbenergyUser = new System.Windows.Forms.ComboBox();
            this.lblPHKWh = new System.Windows.Forms.Label();
            this.lblOPHKWh = new System.Windows.Forms.Label();
            this.txtPHKWh = new System.Windows.Forms.TextBox();
            this.txtOPHKWh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumofKWh
            // 
            this.lblNumofKWh.AutoSize = true;
            this.lblNumofKWh.BackColor = System.Drawing.Color.Linen;
            this.lblNumofKWh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNumofKWh.Location = new System.Drawing.Point(16, 131);
            this.lblNumofKWh.Name = "lblNumofKWh";
            this.lblNumofKWh.Size = new System.Drawing.Size(62, 13);
            this.lblNumofKWh.TabIndex = 0;
            this.lblNumofKWh.Text = "NumofKWh";
            // this.lblNumofKWh.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumofKWh
            // 
            this.txtNumofKWh.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNumofKWh.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNumofKWh.Location = new System.Drawing.Point(124, 131);
            this.txtNumofKWh.Name = "txtNumofKWh";
            this.txtNumofKWh.Size = new System.Drawing.Size(69, 20);
            this.txtNumofKWh.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Linen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCalculate.Location = new System.Drawing.Point(37, 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 43);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Linen;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReset.Location = new System.Drawing.Point(199, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 43);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Linen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(353, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Linen;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBalance.Location = new System.Drawing.Point(248, 127);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(77, 24);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBalance.Location = new System.Drawing.Point(342, 131);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(107, 21);
            this.txtBalance.TabIndex = 6;
            // 
            // cmbenergyUser
            // 
            this.cmbenergyUser.BackColor = System.Drawing.Color.FloralWhite;
            this.cmbenergyUser.DropDownWidth = 330;
            this.cmbenergyUser.FormattingEnabled = true;
            this.cmbenergyUser.Items.AddRange(new object[] {
            "Select user type",
            "Residential",
            "Commercial",
            "Industrial"});
            this.cmbenergyUser.Location = new System.Drawing.Point(91, 23);
            this.cmbenergyUser.Name = "cmbenergyUser";
            this.cmbenergyUser.Size = new System.Drawing.Size(330, 21);
            this.cmbenergyUser.TabIndex = 7;
            this.cmbenergyUser.SelectedIndexChanged += new System.EventHandler(this.cmbenergyUser_SelectedIndexChanged);
            // 
            // lblPHKWh
            // 
            this.lblPHKWh.AutoSize = true;
            this.lblPHKWh.BackColor = System.Drawing.Color.Linen;
            this.lblPHKWh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPHKWh.Location = new System.Drawing.Point(16, 118);
            this.lblPHKWh.Name = "lblPHKWh";
            this.lblPHKWh.Size = new System.Drawing.Size(85, 13);
            this.lblPHKWh.TabIndex = 8;
            this.lblPHKWh.Text = "Peak Hour KWh";
            // 
            // lblOPHKWh
            // 
            this.lblOPHKWh.AutoSize = true;
            this.lblOPHKWh.BackColor = System.Drawing.Color.Linen;
            this.lblOPHKWh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOPHKWh.Location = new System.Drawing.Point(16, 151);
            this.lblOPHKWh.Name = "lblOPHKWh";
            this.lblOPHKWh.Size = new System.Drawing.Size(102, 13);
            this.lblOPHKWh.TabIndex = 9;
            this.lblOPHKWh.Text = "Off Peak Hour KWh";
            this.lblOPHKWh.UseMnemonic = false;
            // 
            // txtPHKWh
            // 
            this.txtPHKWh.BackColor = System.Drawing.Color.FloralWhite;
            this.txtPHKWh.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPHKWh.Location = new System.Drawing.Point(124, 118);
            this.txtPHKWh.Name = "txtPHKWh";
            this.txtPHKWh.Size = new System.Drawing.Size(69, 20);
            this.txtPHKWh.TabIndex = 10;
            // 
            // txtOPHKWh
            // 
            this.txtOPHKWh.BackColor = System.Drawing.Color.FloralWhite;
            this.txtOPHKWh.ForeColor = System.Drawing.Color.DarkRed;
            this.txtOPHKWh.Location = new System.Drawing.Point(124, 148);
            this.txtOPHKWh.Name = "txtOPHKWh";
            this.txtOPHKWh.Size = new System.Drawing.Size(69, 20);
            this.txtOPHKWh.TabIndex = 11;
            // 
            // frmCalculateEnergyBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 316);
            this.Controls.Add(this.txtOPHKWh);
            this.Controls.Add(this.txtPHKWh);
            this.Controls.Add(this.lblOPHKWh);
            this.Controls.Add(this.lblPHKWh);
            this.Controls.Add(this.cmbenergyUser);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumofKWh);
            this.Controls.Add(this.lblNumofKWh);
            this.Name = "frmCalculateEnergyBill";
            this.Text = "Calculate Energy Bill";
            this.Load += new System.EventHandler(this.frmCalculateEnergyBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumofKWh;
        private System.Windows.Forms.TextBox txtNumofKWh;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox cmbenergyUser;
        private System.Windows.Forms.Label lblPHKWh;
        private System.Windows.Forms.Label lblOPHKWh;
        private System.Windows.Forms.TextBox txtPHKWh;
        private System.Windows.Forms.TextBox txtOPHKWh;
    }
}

