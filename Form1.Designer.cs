namespace Hangman3
{
    partial class homepage
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
            this.lbl_word = new System.Windows.Forms.Label();
            this.pcb_man = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_spoken = new System.Windows.Forms.Label();
            this.btn_try = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.strt_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_man)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_word.Location = new System.Drawing.Point(113, 105);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(0, 23);
            this.lbl_word.TabIndex = 0;
            this.lbl_word.Visible = false;
            // 
            // pcb_man
            // 
            this.pcb_man.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcb_man.Location = new System.Drawing.Point(652, 17);
            this.pcb_man.Name = "pcb_man";
            this.pcb_man.Size = new System.Drawing.Size(258, 530);
            this.pcb_man.TabIndex = 1;
            this.pcb_man.TabStop = false;
            this.pcb_man.Visible = false;
            this.pcb_man.Paint += new System.Windows.Forms.PaintEventHandler(this.pcb_man_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_spoken);
            this.panel1.Controls.Add(this.btn_try);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_category);
            this.panel1.Controls.Add(this.strt_btn);
            this.panel1.Controls.Add(this.pcb_man);
            this.panel1.Controls.Add(this.lbl_word);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 561);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_spoken
            // 
            this.lbl_spoken.AutoSize = true;
            this.lbl_spoken.Location = new System.Drawing.Point(39, 393);
            this.lbl_spoken.Name = "lbl_spoken";
            this.lbl_spoken.Size = new System.Drawing.Size(0, 13);
            this.lbl_spoken.TabIndex = 6;
            this.lbl_spoken.Visible = false;
            // 
            // btn_try
            // 
            this.btn_try.Location = new System.Drawing.Point(224, 285);
            this.btn_try.Name = "btn_try";
            this.btn_try.Size = new System.Drawing.Size(75, 23);
            this.btn_try.TabIndex = 5;
            this.btn_try.Text = "Try";
            this.btn_try.UseVisualStyleBackColor = true;
            this.btn_try.Visible = false;
            this.btn_try.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 285);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(39, 29);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(35, 13);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "label1";
            this.lbl_category.Visible = false;
            // 
            // strt_btn
            // 
            this.strt_btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.strt_btn.Location = new System.Drawing.Point(406, 285);
            this.strt_btn.Name = "strt_btn";
            this.strt_btn.Size = new System.Drawing.Size(91, 38);
            this.strt_btn.TabIndex = 2;
            this.strt_btn.Text = "START";
            this.strt_btn.UseVisualStyleBackColor = true;
            this.strt_btn.Click += new System.EventHandler(this.strt_btn_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 585);
            this.Controls.Add(this.panel1);
            this.Name = "homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.homepage_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_man)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.PictureBox pcb_man;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button strt_btn;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Button btn_try;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_spoken;
    }
}

