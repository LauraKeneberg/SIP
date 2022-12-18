namespace SIP
{
    partial class FStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_SIP = new System.Windows.Forms.Label();
            this.bt_autoriz = new System.Windows.Forms.Button();
            this.bt_registr = new System.Windows.Forms.Button();
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
            this.lb_SIP.TabIndex = 0;
            this.lb_SIP.Text = "СИП";
            this.lb_SIP.MouseLeave += new System.EventHandler(this.lb_SIP_MouseLeave);
            this.lb_SIP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_SIP_MouseMove);
            // 
            // bt_autoriz
            // 
            this.bt_autoriz.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_autoriz.Location = new System.Drawing.Point(818, 394);
            this.bt_autoriz.Name = "bt_autoriz";
            this.bt_autoriz.Size = new System.Drawing.Size(185, 37);
            this.bt_autoriz.TabIndex = 1;
            this.bt_autoriz.Text = "Авторизация";
            this.bt_autoriz.UseVisualStyleBackColor = true;
            this.bt_autoriz.Click += new System.EventHandler(this.bt_vhod_Click);
            this.bt_autoriz.MouseLeave += new System.EventHandler(this.bt_autoriz_MouseLeave);
            this.bt_autoriz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_autoriz_MouseMove);
            // 
            // bt_registr
            // 
            this.bt_registr.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.bt_registr.Location = new System.Drawing.Point(818, 470);
            this.bt_registr.Name = "bt_registr";
            this.bt_registr.Size = new System.Drawing.Size(185, 37);
            this.bt_registr.TabIndex = 2;
            this.bt_registr.Text = "Регистрация";
            this.bt_registr.UseVisualStyleBackColor = true;
            this.bt_registr.Click += new System.EventHandler(this.bt_registr_Click);
            this.bt_registr.MouseLeave += new System.EventHandler(this.bt_registr_MouseLeave);
            this.bt_registr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_registr_MouseMove);
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIP.Properties.Resources.фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.bt_registr);
            this.Controls.Add(this.bt_autoriz);
            this.Controls.Add(this.lb_SIP);
            this.Name = "FStart";
            this.Text = "SIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SIP;
        private System.Windows.Forms.Button bt_autoriz;
        private System.Windows.Forms.Button bt_registr;
    }
}

