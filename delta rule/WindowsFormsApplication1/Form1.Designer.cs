namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txtfilelocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_w2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_w1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_lr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_theta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_iteration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_accuracy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart2_errorperepoch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2_errorperepoch)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(552, 316);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dataset Plot";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(484, 25);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_browse);
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Controls.Add(this.txtfilelocation);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(405, 23);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtfilelocation
            // 
            this.txtfilelocation.Location = new System.Drawing.Point(62, 25);
            this.txtfilelocation.Name = "txtfilelocation";
            this.txtfilelocation.Size = new System.Drawing.Size(337, 20);
            this.txtfilelocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_accuracy);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lbl_w2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lbl_w1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lbl_lr);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lbl_theta);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lbl_iteration);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(582, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 78);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameters";
            // 
            // lbl_w2
            // 
            this.lbl_w2.AutoSize = true;
            this.lbl_w2.Location = new System.Drawing.Point(270, 52);
            this.lbl_w2.Name = "lbl_w2";
            this.lbl_w2.Size = new System.Drawing.Size(13, 13);
            this.lbl_w2.TabIndex = 25;
            this.lbl_w2.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "w2";
            // 
            // lbl_w1
            // 
            this.lbl_w1.AutoSize = true;
            this.lbl_w1.Location = new System.Drawing.Point(270, 28);
            this.lbl_w1.Name = "lbl_w1";
            this.lbl_w1.Size = new System.Drawing.Size(13, 13);
            this.lbl_w1.TabIndex = 23;
            this.lbl_w1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "w1";
            // 
            // lbl_lr
            // 
            this.lbl_lr.AutoSize = true;
            this.lbl_lr.Location = new System.Drawing.Point(196, 28);
            this.lbl_lr.Name = "lbl_lr";
            this.lbl_lr.Size = new System.Drawing.Size(13, 13);
            this.lbl_lr.TabIndex = 21;
            this.lbl_lr.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Learning Rate";
            // 
            // lbl_theta
            // 
            this.lbl_theta.AutoSize = true;
            this.lbl_theta.Location = new System.Drawing.Point(82, 52);
            this.lbl_theta.Name = "lbl_theta";
            this.lbl_theta.Size = new System.Drawing.Size(13, 13);
            this.lbl_theta.TabIndex = 19;
            this.lbl_theta.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Theta";
            // 
            // lbl_iteration
            // 
            this.lbl_iteration.AutoSize = true;
            this.lbl_iteration.Location = new System.Drawing.Point(82, 28);
            this.lbl_iteration.Name = "lbl_iteration";
            this.lbl_iteration.Size = new System.Drawing.Size(13, 13);
            this.lbl_iteration.TabIndex = 17;
            this.lbl_iteration.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "# iteration";
            // 
            // lbl_accuracy
            // 
            this.lbl_accuracy.AutoSize = true;
            this.lbl_accuracy.Location = new System.Drawing.Point(196, 52);
            this.lbl_accuracy.Name = "lbl_accuracy";
            this.lbl_accuracy.Size = new System.Drawing.Size(13, 13);
            this.lbl_accuracy.TabIndex = 27;
            this.lbl_accuracy.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Accuracy";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart2_errorperepoch);
            this.groupBox5.Location = new System.Drawing.Point(582, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(564, 342);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Error Plot";
            // 
            // chart2_errorperepoch
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2_errorperepoch.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2_errorperepoch.Legends.Add(legend2);
            this.chart2_errorperepoch.Location = new System.Drawing.Point(10, 14);
            this.chart2_errorperepoch.Name = "chart2_errorperepoch";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2_errorperepoch.Series.Add(series2);
            this.chart2_errorperepoch.Size = new System.Drawing.Size(548, 321);
            this.chart2_errorperepoch.TabIndex = 1;
            this.chart2_errorperepoch.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1156, 438);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2_errorperepoch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txtfilelocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_w2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_w1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_lr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_theta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_iteration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_accuracy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2_errorperepoch;
    }
}

