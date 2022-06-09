namespace SIP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lb_SIP = new System.Windows.Forms.Label();
            this.lb_autoriz = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_login1 = new System.Windows.Forms.Label();
            this.lb_parol1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_vhod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_SIP
            // 
            this.lb_SIP.AutoSize = true;
            this.lb_SIP.BackColor = System.Drawing.Color.HotPink;
            this.lb_SIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_SIP.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_SIP.Location = new System.Drawing.Point(12, 22);
            this.lb_SIP.Name = "lb_SIP";
            this.lb_SIP.Size = new System.Drawing.Size(77, 32);
            this.lb_SIP.TabIndex = 1;
            this.lb_SIP.Text = "СИП";
            this.lb_SIP.Click += new System.EventHandler(this.lb_SIP_Click);
            this.lb_SIP.MouseLeave += new System.EventHandler(this.lb_SIP_MouseLeave);
            this.lb_SIP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_SIP_MouseMove);
            // 
            // lb_autoriz
            // 
            this.lb_autoriz.AutoSize = true;
            this.lb_autoriz.BackColor = System.Drawing.SystemColors.Highlight;
            this.lb_autoriz.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_autoriz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_autoriz.Location = new System.Drawing.Point(803, 221);
            this.lb_autoriz.Name = "lb_autoriz";
            this.lb_autoriz.Size = new System.Drawing.Size(229, 39);
            this.lb_autoriz.TabIndex = 2;
            this.lb_autoriz.Text = "Авторизация";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.textBox1.Location = new System.Drawing.Point(813, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 36);
            this.textBox1.TabIndex = 3;
            // 
            // lb_login1
            // 
            this.lb_login1.AutoSize = true;
            this.lb_login1.BackColor = System.Drawing.SystemColors.Highlight;
            this.lb_login1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_login1.Location = new System.Drawing.Point(814, 343);
            this.lb_login1.Name = "lb_login1";
            this.lb_login1.Size = new System.Drawing.Size(54, 19);
            this.lb_login1.TabIndex = 4;
            this.lb_login1.Text = "Логин";
            // 
            // lb_parol1
            // 
            this.lb_parol1.AutoSize = true;
            this.lb_parol1.BackColor = System.Drawing.SystemColors.Highlight;
            this.lb_parol1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_parol1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_parol1.Location = new System.Drawing.Point(815, 433);
            this.lb_parol1.Name = "lb_parol1";
            this.lb_parol1.Size = new System.Drawing.Size(62, 19);
            this.lb_parol1.TabIndex = 5;
            this.lb_parol1.Text = "Пароль";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.textBox2.Location = new System.Drawing.Point(813, 454);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 36);
            this.textBox2.TabIndex = 6;
            // 
            // bt_vhod
            // 
            this.bt_vhod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_vhod.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.bt_vhod.Location = new System.Drawing.Point(864, 529);
            this.bt_vhod.Name = "bt_vhod";
            this.bt_vhod.Size = new System.Drawing.Size(114, 37);
            this.bt_vhod.TabIndex = 7;
            this.bt_vhod.Text = "Вход";
            this.bt_vhod.UseVisualStyleBackColor = true;
            this.bt_vhod.Click += new System.EventHandler(this.bt_vhod_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.bt_vhod);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_parol1);
            this.Controls.Add(this.lb_login1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_autoriz);
            this.Controls.Add(this.lb_SIP);
            this.Name = "Form2";
            this.Text = "SIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SIP;
        private System.Windows.Forms.Label lb_autoriz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_login1;
        private System.Windows.Forms.Label lb_parol1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_vhod;
    }
}