namespace WinForms_Dataviewer
{
    partial class Detail
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
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblSpd = new System.Windows.Forms.Label();
            this.lblSpcDef = new System.Windows.Forms.Label();
            this.lblSpcAtk = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.lblAtk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 158);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(164, 47);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(31, 20);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "HP";
            // 
            // lblSpd
            // 
            this.lblSpd.AutoSize = true;
            this.lblSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpd.Location = new System.Drawing.Point(164, 67);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(56, 20);
            this.lblSpd.TabIndex = 4;
            this.lblSpd.Text = "Speed";
            // 
            // lblSpcDef
            // 
            this.lblSpcDef.AutoSize = true;
            this.lblSpcDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpcDef.Location = new System.Drawing.Point(163, 90);
            this.lblSpcDef.Name = "lblSpcDef";
            this.lblSpcDef.Size = new System.Drawing.Size(126, 20);
            this.lblSpcDef.TabIndex = 5;
            this.lblSpcDef.Text = "Special Defense";
            // 
            // lblSpcAtk
            // 
            this.lblSpcAtk.AutoSize = true;
            this.lblSpcAtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpcAtk.Location = new System.Drawing.Point(163, 110);
            this.lblSpcAtk.Name = "lblSpcAtk";
            this.lblSpcAtk.Size = new System.Drawing.Size(111, 20);
            this.lblSpcAtk.TabIndex = 6;
            this.lblSpcAtk.Text = "Special Attack";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDef.Location = new System.Drawing.Point(163, 130);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(70, 20);
            this.lblDef.TabIndex = 7;
            this.lblDef.Text = "Defense";
            // 
            // lblAtk
            // 
            this.lblAtk.AutoSize = true;
            this.lblAtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtk.Location = new System.Drawing.Point(163, 150);
            this.lblAtk.Name = "lblAtk";
            this.lblAtk.Size = new System.Drawing.Size(55, 20);
            this.lblAtk.TabIndex = 8;
            this.lblAtk.Text = "Attack";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 243);
            this.Controls.Add(this.lblAtk);
            this.Controls.Add(this.lblDef);
            this.Controls.Add(this.lblSpcAtk);
            this.Controls.Add(this.lblSpcDef);
            this.Controls.Add(this.lblSpd);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblSpd;
        private System.Windows.Forms.Label lblSpcDef;
        private System.Windows.Forms.Label lblSpcAtk;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label lblAtk;
    }
}