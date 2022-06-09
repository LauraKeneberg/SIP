namespace SIP
{
    partial class Form5
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_scl3 = new System.Windows.Forms.Button();
            this.bt_scl2 = new System.Windows.Forms.Button();
            this.bt_scl1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(374, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_scl3
            // 
            this.bt_scl3.Location = new System.Drawing.Point(194, 12);
            this.bt_scl3.Name = "bt_scl3";
            this.bt_scl3.Size = new System.Drawing.Size(75, 23);
            this.bt_scl3.TabIndex = 7;
            this.bt_scl3.Text = "Склад3";
            this.bt_scl3.UseVisualStyleBackColor = true;
            // 
            // bt_scl2
            // 
            this.bt_scl2.Location = new System.Drawing.Point(103, 12);
            this.bt_scl2.Name = "bt_scl2";
            this.bt_scl2.Size = new System.Drawing.Size(75, 23);
            this.bt_scl2.TabIndex = 6;
            this.bt_scl2.Text = "Склад2";
            this.bt_scl2.UseVisualStyleBackColor = true;
            // 
            // bt_scl1
            // 
            this.bt_scl1.Location = new System.Drawing.Point(12, 12);
            this.bt_scl1.Name = "bt_scl1";
            this.bt_scl1.Size = new System.Drawing.Size(75, 23);
            this.bt_scl1.TabIndex = 5;
            this.bt_scl1.Text = "Склад1";
            this.bt_scl1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Count,
            this.Tara});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(958, 955);
            this.dataGridView1.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdCol";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Names
            // 
            this.Names.HeaderText = "NameCol";
            this.Names.Name = "Names";
            // 
            // Count
            // 
            this.Count.HeaderText = "CountCol";
            this.Count.Name = "Count";
            // 
            // Tara
            // 
            this.Tara.HeaderText = "TaraCol";
            this.Tara.Name = "Tara";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_scl3);
            this.Controls.Add(this.bt_scl2);
            this.Controls.Add(this.bt_scl1);
            this.Name = "Form5";
            this.Text = "SIP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_scl3;
        private System.Windows.Forms.Button bt_scl2;
        private System.Windows.Forms.Button bt_scl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tara;
    }
}