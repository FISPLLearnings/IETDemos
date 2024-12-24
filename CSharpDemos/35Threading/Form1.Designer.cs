namespace _35Threading
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnStartT1 = new System.Windows.Forms.Button();
            this.btnStartT2 = new System.Windows.Forms.Button();
            this.btnPauseT1 = new System.Windows.Forms.Button();
            this.btnPauseT2 = new System.Windows.Forms.Button();
            this.btnResumeT1 = new System.Windows.Forms.Button();
            this.btnResumeT2 = new System.Windows.Forms.Button();
            this.btnAbortT1 = new System.Windows.Forms.Button();
            this.btnAbortT2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 604);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(593, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(278, 604);
            this.listBox2.TabIndex = 1;
            // 
            // btnStartT1
            // 
            this.btnStartT1.Location = new System.Drawing.Point(221, 3);
            this.btnStartT1.Name = "btnStartT1";
            this.btnStartT1.Size = new System.Drawing.Size(314, 75);
            this.btnStartT1.TabIndex = 2;
            this.btnStartT1.Text = "Start T 1";
            this.btnStartT1.UseVisualStyleBackColor = true;
            this.btnStartT1.Click += new System.EventHandler(this.btnStartT1_Click);
            // 
            // btnStartT2
            // 
            this.btnStartT2.Location = new System.Drawing.Point(221, 94);
            this.btnStartT2.Name = "btnStartT2";
            this.btnStartT2.Size = new System.Drawing.Size(314, 75);
            this.btnStartT2.TabIndex = 3;
            this.btnStartT2.Text = "Start T 2";
            this.btnStartT2.UseVisualStyleBackColor = true;
            this.btnStartT2.Click += new System.EventHandler(this.btnStartT2_Click);
            // 
            // btnPauseT1
            // 
            this.btnPauseT1.Location = new System.Drawing.Point(221, 175);
            this.btnPauseT1.Name = "btnPauseT1";
            this.btnPauseT1.Size = new System.Drawing.Size(314, 75);
            this.btnPauseT1.TabIndex = 4;
            this.btnPauseT1.Text = "Pause T 1";
            this.btnPauseT1.UseVisualStyleBackColor = true;
            this.btnPauseT1.Click += new System.EventHandler(this.btnPauseT1_Click);
            // 
            // btnPauseT2
            // 
            this.btnPauseT2.Location = new System.Drawing.Point(221, 256);
            this.btnPauseT2.Name = "btnPauseT2";
            this.btnPauseT2.Size = new System.Drawing.Size(314, 75);
            this.btnPauseT2.TabIndex = 5;
            this.btnPauseT2.Text = "Pause T 2";
            this.btnPauseT2.UseVisualStyleBackColor = true;
            this.btnPauseT2.Click += new System.EventHandler(this.btnPauseT2_Click);
            // 
            // btnResumeT1
            // 
            this.btnResumeT1.Location = new System.Drawing.Point(221, 337);
            this.btnResumeT1.Name = "btnResumeT1";
            this.btnResumeT1.Size = new System.Drawing.Size(314, 75);
            this.btnResumeT1.TabIndex = 6;
            this.btnResumeT1.Text = "Resume T 1";
            this.btnResumeT1.UseVisualStyleBackColor = true;
            this.btnResumeT1.Click += new System.EventHandler(this.btnResumeT1_Click);
            // 
            // btnResumeT2
            // 
            this.btnResumeT2.Location = new System.Drawing.Point(221, 418);
            this.btnResumeT2.Name = "btnResumeT2";
            this.btnResumeT2.Size = new System.Drawing.Size(314, 75);
            this.btnResumeT2.TabIndex = 7;
            this.btnResumeT2.Text = "Resume T 2";
            this.btnResumeT2.UseVisualStyleBackColor = true;
            this.btnResumeT2.Click += new System.EventHandler(this.btnResumeT2_Click);
            // 
            // btnAbortT1
            // 
            this.btnAbortT1.Location = new System.Drawing.Point(221, 508);
            this.btnAbortT1.Name = "btnAbortT1";
            this.btnAbortT1.Size = new System.Drawing.Size(314, 75);
            this.btnAbortT1.TabIndex = 8;
            this.btnAbortT1.Text = "Abort T 1";
            this.btnAbortT1.UseVisualStyleBackColor = true;
            this.btnAbortT1.Click += new System.EventHandler(this.btnAbortT1_Click);
            // 
            // btnAbortT2
            // 
            this.btnAbortT2.Location = new System.Drawing.Point(221, 589);
            this.btnAbortT2.Name = "btnAbortT2";
            this.btnAbortT2.Size = new System.Drawing.Size(314, 75);
            this.btnAbortT2.TabIndex = 9;
            this.btnAbortT2.Text = "Abort T 2";
            this.btnAbortT2.UseVisualStyleBackColor = true;
            this.btnAbortT2.Click += new System.EventHandler(this.btnAbortT2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 666);
            this.Controls.Add(this.btnAbortT2);
            this.Controls.Add(this.btnAbortT1);
            this.Controls.Add(this.btnResumeT2);
            this.Controls.Add(this.btnResumeT1);
            this.Controls.Add(this.btnPauseT2);
            this.Controls.Add(this.btnPauseT1);
            this.Controls.Add(this.btnStartT2);
            this.Controls.Add(this.btnStartT1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnStartT1;
        private System.Windows.Forms.Button btnStartT2;
        private System.Windows.Forms.Button btnPauseT1;
        private System.Windows.Forms.Button btnPauseT2;
        private System.Windows.Forms.Button btnResumeT1;
        private System.Windows.Forms.Button btnResumeT2;
        private System.Windows.Forms.Button btnAbortT1;
        private System.Windows.Forms.Button btnAbortT2;
    }
}

