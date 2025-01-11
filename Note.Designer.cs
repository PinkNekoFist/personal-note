namespace personal_note
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            this.rtbTitle = new System.Windows.Forms.RichTextBox();
            this.rtbDate = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.RichTextBox();
            this.lblTag = new System.Windows.Forms.RichTextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.rtbAdd = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.pBox5 = new System.Windows.Forms.PictureBox();
            this.lblTagText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbTitle
            // 
            this.rtbTitle.AutoWordSelection = true;
            this.rtbTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbTitle.Font = new System.Drawing.Font("PMingLiU", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbTitle.ForeColor = System.Drawing.Color.Gray;
            this.rtbTitle.Location = new System.Drawing.Point(36, 46);
            this.rtbTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTitle.Size = new System.Drawing.Size(503, 55);
            this.rtbTitle.TabIndex = 1;
            this.rtbTitle.Text = "Title";
            this.rtbTitle.TextChanged += new System.EventHandler(this.rtbTitle_TextChanged);
            this.rtbTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbTitle_KeyDown);
            // 
            // rtbDate
            // 
            this.rtbDate.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbDate.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbDate.Location = new System.Drawing.Point(91, 119);
            this.rtbDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbDate.Name = "rtbDate";
            this.rtbDate.Size = new System.Drawing.Size(437, 21);
            this.rtbDate.TabIndex = 4;
            this.rtbDate.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate.Location = new System.Drawing.Point(36, 119);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.ReadOnly = true;
            this.lblDate.Size = new System.Drawing.Size(41, 21);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Dates";
            // 
            // lblTag
            // 
            this.lblTag.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTag.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTag.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTag.Location = new System.Drawing.Point(36, 157);
            this.lblTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(33, 21);
            this.lblTag.TabIndex = 7;
            this.lblTag.Text = "Tags";
            // 
            // rtbNote
            // 
            this.rtbNote.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtbNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNote.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbNote.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbNote.ForeColor = System.Drawing.Color.Gray;
            this.rtbNote.Location = new System.Drawing.Point(36, 195);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(497, 370);
            this.rtbNote.TabIndex = 8;
            this.rtbNote.Text = "";
            this.rtbNote.TextChanged += new System.EventHandler(this.rtbNote_TextChanged);
            this.rtbNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // rtbAdd
            // 
            this.rtbAdd.BackColor = System.Drawing.Color.Gray;
            this.rtbAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbAdd.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbAdd.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtbAdd.Location = new System.Drawing.Point(93, 157);
            this.rtbAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbAdd.Name = "rtbAdd";
            this.rtbAdd.Size = new System.Drawing.Size(391, 21);
            this.rtbAdd.TabIndex = 9;
            this.rtbAdd.Text = "";
            this.rtbAdd.Visible = false;
            this.rtbAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbAdd_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(488, 157);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 21);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pBox1
            // 
            this.pBox1.Image = ((System.Drawing.Image)(resources.GetObject("pBox1.Image")));
            this.pBox1.Location = new System.Drawing.Point(354, 4);
            this.pBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(41, 38);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 11;
            this.pBox1.TabStop = false;
            this.pBox1.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox2
            // 
            this.pBox2.Image = ((System.Drawing.Image)(resources.GetObject("pBox2.Image")));
            this.pBox2.Location = new System.Drawing.Point(393, 4);
            this.pBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(41, 38);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 12;
            this.pBox2.TabStop = false;
            this.pBox2.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox3
            // 
            this.pBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pBox3.ErrorImage")));
            this.pBox3.Image = ((System.Drawing.Image)(resources.GetObject("pBox3.Image")));
            this.pBox3.Location = new System.Drawing.Point(431, 4);
            this.pBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(41, 38);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox3.TabIndex = 13;
            this.pBox3.TabStop = false;
            this.pBox3.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox4
            // 
            this.pBox4.Image = ((System.Drawing.Image)(resources.GetObject("pBox4.Image")));
            this.pBox4.Location = new System.Drawing.Point(470, 4);
            this.pBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(41, 38);
            this.pBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox4.TabIndex = 14;
            this.pBox4.TabStop = false;
            this.pBox4.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox5
            // 
            this.pBox5.Image = ((System.Drawing.Image)(resources.GetObject("pBox5.Image")));
            this.pBox5.Location = new System.Drawing.Point(508, 4);
            this.pBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox5.Name = "pBox5";
            this.pBox5.Size = new System.Drawing.Size(41, 38);
            this.pBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox5.TabIndex = 15;
            this.pBox5.TabStop = false;
            this.pBox5.Click += new System.EventHandler(this.pBox_Click);
            // 
            // lblTagText
            // 
            this.lblTagText.AutoSize = true;
            this.lblTagText.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTagText.Location = new System.Drawing.Point(88, 159);
            this.lblTagText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTagText.Name = "lblTagText";
            this.lblTagText.Size = new System.Drawing.Size(0, 16);
            this.lblTagText.TabIndex = 16;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(547, 588);
            this.Controls.Add(this.lblTagText);
            this.Controls.Add(this.pBox5);
            this.Controls.Add(this.pBox4);
            this.Controls.Add(this.pBox3);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbAdd);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rtbDate);
            this.Controls.Add(this.rtbTitle);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Note";
            this.Text = "Note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Note_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTitle;
        private System.Windows.Forms.RichTextBox rtbDate;
        private System.Windows.Forms.RichTextBox lblDate;
        private System.Windows.Forms.RichTextBox lblTag;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.RichTextBox rtbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.PictureBox pBox5;
        private System.Windows.Forms.Label lblTagText;
    }
}