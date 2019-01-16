namespace WindowsFormsApplication1
{
    partial class Old
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
            this.selected_item = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Count = new System.Windows.Forms.Button();
            this.Avg = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Loads = new System.Windows.Forms.Button();
            this.FilesName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SumRes = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AvgRes = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MaxRes = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MinRes = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CountRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // selected_item
            // 
            this.selected_item.FormattingEnabled = true;
            this.selected_item.Location = new System.Drawing.Point(317, 382);
            this.selected_item.Name = "selected_item";
            this.selected_item.Size = new System.Drawing.Size(121, 21);
            this.selected_item.TabIndex = 0;
            this.selected_item.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.selected_item.Click += new System.EventHandler(this.selected_item_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.Color.AliceBlue;
            this.Count.Location = new System.Drawing.Point(22, 67);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(71, 29);
            this.Count.TabIndex = 19;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = false;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Avg
            // 
            this.Avg.BackColor = System.Drawing.Color.AliceBlue;
            this.Avg.Location = new System.Drawing.Point(27, 64);
            this.Avg.Name = "Avg";
            this.Avg.Size = new System.Drawing.Size(69, 32);
            this.Avg.TabIndex = 18;
            this.Avg.Text = "Avg";
            this.Avg.UseVisualStyleBackColor = false;
            this.Avg.Click += new System.EventHandler(this.Avg_Click);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.AliceBlue;
            this.Min.Location = new System.Drawing.Point(23, 64);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(72, 32);
            this.Min.TabIndex = 17;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.Color.AliceBlue;
            this.Max.Location = new System.Drawing.Point(22, 64);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(71, 32);
            this.Max.TabIndex = 16;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.Color.AliceBlue;
            this.Sum.Location = new System.Drawing.Point(22, 64);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(71, 32);
            this.Sum.TabIndex = 15;
            this.Sum.Text = "Sum";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Loads
            // 
            this.Loads.BackColor = System.Drawing.Color.AliceBlue;
            this.Loads.Cursor = System.Windows.Forms.Cursors.Default;
            this.Loads.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loads.Location = new System.Drawing.Point(79, 30);
            this.Loads.Name = "Loads";
            this.Loads.Size = new System.Drawing.Size(166, 30);
            this.Loads.TabIndex = 20;
            this.Loads.Text = "Load File Name";
            this.Loads.UseVisualStyleBackColor = false;
            this.Loads.Click += new System.EventHandler(this.Loads_Click);
            // 
            // FilesName
            // 
            this.FilesName.FormattingEnabled = true;
            this.FilesName.Location = new System.Drawing.Point(284, 37);
            this.FilesName.Name = "FilesName";
            this.FilesName.Size = new System.Drawing.Size(121, 21);
            this.FilesName.TabIndex = 21;
            this.FilesName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(708, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Get Posation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.SumRes);
            this.groupBox1.Controls.Add(this.Sum);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(518, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 102);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sum";
            // 
            // SumRes
            // 
            this.SumRes.AutoSize = true;
            this.SumRes.Location = new System.Drawing.Point(50, 35);
            this.SumRes.Name = "SumRes";
            this.SumRes.Size = new System.Drawing.Size(17, 19);
            this.SumRes.TabIndex = 24;
            this.SumRes.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.AvgRes);
            this.groupBox2.Controls.Add(this.Avg);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(695, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avg";
            // 
            // AvgRes
            // 
            this.AvgRes.AutoSize = true;
            this.AvgRes.Location = new System.Drawing.Point(47, 35);
            this.AvgRes.Name = "AvgRes";
            this.AvgRes.Size = new System.Drawing.Size(17, 19);
            this.AvgRes.TabIndex = 25;
            this.AvgRes.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox3.Controls.Add(this.MaxRes);
            this.groupBox3.Controls.Add(this.Max);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(518, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 102);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Max";
            // 
            // MaxRes
            // 
            this.MaxRes.AutoSize = true;
            this.MaxRes.Location = new System.Drawing.Point(41, 35);
            this.MaxRes.Name = "MaxRes";
            this.MaxRes.Size = new System.Drawing.Size(17, 19);
            this.MaxRes.TabIndex = 26;
            this.MaxRes.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox4.Controls.Add(this.MinRes);
            this.groupBox4.Controls.Add(this.Min);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(696, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 102);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Min";
            // 
            // MinRes
            // 
            this.MinRes.AutoSize = true;
            this.MinRes.Location = new System.Drawing.Point(29, 35);
            this.MinRes.Name = "MinRes";
            this.MinRes.Size = new System.Drawing.Size(17, 19);
            this.MinRes.TabIndex = 27;
            this.MinRes.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox5.Controls.Add(this.CountRes);
            this.groupBox5.Controls.Add(this.Count);
            this.groupBox5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(518, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(121, 102);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Count";
            // 
            // CountRes
            // 
            this.CountRes.AutoSize = true;
            this.CountRes.Location = new System.Drawing.Point(32, 38);
            this.CountRes.Name = "CountRes";
            this.CountRes.Size = new System.Drawing.Size(17, 19);
            this.CountRes.TabIndex = 28;
            this.CountRes.Text = "0";
            this.CountRes.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Column Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(708, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(24, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 26;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Old
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.seamless_illustration_formulas_charts_topic_mathematics_education_background_light_marker_blue_background_84279961;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 445);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilesName);
            this.Controls.Add(this.Loads);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selected_item);
            this.Name = "Old";
            this.Text = "Old";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Old_FormClosing);
            this.Load += new System.EventHandler(this.Old_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selected_item;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Avg;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Loads;
        private System.Windows.Forms.ComboBox FilesName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SumRes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AvgRes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label MaxRes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label MinRes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label CountRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}