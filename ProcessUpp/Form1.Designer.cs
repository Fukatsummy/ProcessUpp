namespace ProcessUpp
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label_st = new System.Windows.Forms.Label();
            this.label_pt = new System.Windows.Forms.Label();
            this.label_tc = new System.Windows.Forms.Label();
            this.label_pc = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_ptime = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_copy = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.tb_np = new System.Windows.Forms.TextBox();
            this.btn_np = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "20";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация о процессе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Processe ID";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(596, 80);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(0, 13);
            this.labelid.TabIndex = 5;
            // 
            // label_st
            // 
            this.label_st.AutoSize = true;
            this.label_st.Location = new System.Drawing.Point(481, 114);
            this.label_st.Name = "label_st";
            this.label_st.Size = new System.Drawing.Size(51, 13);
            this.label_st.TabIndex = 6;
            this.label_st.Text = "Start time";
            // 
            // label_pt
            // 
            this.label_pt.AutoSize = true;
            this.label_pt.Location = new System.Drawing.Point(481, 144);
            this.label_pt.Name = "label_pt";
            this.label_pt.Size = new System.Drawing.Size(83, 13);
            this.label_pt.TabIndex = 7;
            this.label_pt.Text = "Processor Time:";
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Location = new System.Drawing.Point(478, 176);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(69, 13);
            this.label_tc.TabIndex = 8;
            this.label_tc.Text = "ThreadCount";
            // 
            // label_pc
            // 
            this.label_pc.AutoSize = true;
            this.label_pc.Location = new System.Drawing.Point(481, 208);
            this.label_pc.Name = "label_pc";
            this.label_pc.Size = new System.Drawing.Size(72, 13);
            this.label_pc.TabIndex = 9;
            this.label_pc.Text = "Process Copy";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(572, 114);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 13);
            this.label_time.TabIndex = 10;
            // 
            // label_ptime
            // 
            this.label_ptime.AutoSize = true;
            this.label_ptime.Location = new System.Drawing.Point(572, 144);
            this.label_ptime.Name = "label_ptime";
            this.label_ptime.Size = new System.Drawing.Size(0, 13);
            this.label_ptime.TabIndex = 11;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(572, 176);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(0, 13);
            this.label_count.TabIndex = 12;
            // 
            // label_copy
            // 
            this.label_copy.AutoSize = true;
            this.label_copy.Location = new System.Drawing.Point(572, 208);
            this.label_copy.Name = "label_copy";
            this.label_copy.Size = new System.Drawing.Size(0, 13);
            this.label_copy.TabIndex = 13;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(477, 238);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(95, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tb_np
            // 
            this.tb_np.Location = new System.Drawing.Point(466, 307);
            this.tb_np.Name = "tb_np";
            this.tb_np.Size = new System.Drawing.Size(238, 20);
            this.tb_np.TabIndex = 15;
            this.tb_np.TextChanged += new System.EventHandler(this.tb_np_TextChanged);
            // 
            // btn_np
            // 
            this.btn_np.Enabled = false;
            this.btn_np.Location = new System.Drawing.Point(465, 347);
            this.btn_np.Name = "btn_np";
            this.btn_np.Size = new System.Drawing.Size(238, 23);
            this.btn_np.TabIndex = 16;
            this.btn_np.Text = "New Process";
            this.btn_np.UseVisualStyleBackColor = true;
            this.btn_np.Click += new System.EventHandler(this.btn_np_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 509);
            this.Controls.Add(this.btn_np);
            this.Controls.Add(this.tb_np);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label_copy);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_ptime);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_pc);
            this.Controls.Add(this.label_tc);
            this.Controls.Add(this.label_pt);
            this.Controls.Add(this.label_st);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label_st;
        private System.Windows.Forms.Label label_pt;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.Label label_pc;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_ptime;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_copy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tb_np;
        private System.Windows.Forms.Button btn_np;
    }
}

