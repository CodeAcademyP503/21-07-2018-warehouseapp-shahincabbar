namespace WindowsFormsApp11
{
    partial class Mango
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
            this.logout = new System.Windows.Forms.Button();
            this.svbtn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grade1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(657, 43);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(103, 39);
            this.logout.TabIndex = 23;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // svbtn
            // 
            this.svbtn.BackColor = System.Drawing.Color.Silver;
            this.svbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.svbtn.Location = new System.Drawing.Point(402, 371);
            this.svbtn.Name = "svbtn";
            this.svbtn.Size = new System.Drawing.Size(84, 36);
            this.svbtn.TabIndex = 22;
            this.svbtn.Text = "Save";
            this.svbtn.UseVisualStyleBackColor = false;
            this.svbtn.Click += new System.EventHandler(this.svbtn_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(387, 292);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(238, 22);
            this.textBox5.TabIndex = 21;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(387, 216);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 22);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 22);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 22);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // grade1
            // 
            this.grade1.AutoSize = true;
            this.grade1.Location = new System.Drawing.Point(399, 9);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(0, 17);
            this.grade1.TabIndex = 24;
            // 
            // Mango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grade1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.svbtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mango";
            this.Text = "Mango";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button svbtn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grade1;
        public System.Windows.Forms.TextBox textBox1;
    }
}