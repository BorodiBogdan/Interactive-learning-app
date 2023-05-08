
namespace Aplicatii_Algorimul_lui_Lee
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
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(21, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(38, 151);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(190, 26);
            this.password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(376, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "LEE ALGORITHM EXPLAINED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(72, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(72, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "If you do not have an account, don\' t be depressed, create an account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(766, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "here";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.user_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(435, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 284);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.White;
            this.user_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(38, 54);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(190, 26);
            this.user_name.TabIndex = 2;
            this.user_name.TextChanged += new System.EventHandler(this.user_name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1086, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox user_name;
    }
}

