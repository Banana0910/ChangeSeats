namespace ChangeSeats
{
    partial class Seats
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
            this.seats_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seats_count = new System.Windows.Forms.MaskedTextBox();
            this.seats_count_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seats_panel
            // 
            this.seats_panel.BackColor = System.Drawing.Color.Transparent;
            this.seats_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.seats_panel.Location = new System.Drawing.Point(8, 114);
            this.seats_panel.Name = "seats_panel";
            this.seats_panel.Size = new System.Drawing.Size(532, 457);
            this.seats_panel.TabIndex = 0;
            this.seats_panel.TabStop = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "교탁";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "칠판";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seats_count
            // 
            this.seats_count.BackColor = System.Drawing.Color.White;
            this.seats_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seats_count.Enabled = false;
            this.seats_count.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.seats_count.Location = new System.Drawing.Point(516, 79);
            this.seats_count.Mask = "00";
            this.seats_count.Name = "seats_count";
            this.seats_count.PromptChar = '0';
            this.seats_count.RejectInputOnFirstFailure = true;
            this.seats_count.ResetOnPrompt = false;
            this.seats_count.ResetOnSpace = false;
            this.seats_count.Size = new System.Drawing.Size(25, 29);
            this.seats_count.SkipLiterals = false;
            this.seats_count.TabIndex = 0;
            this.seats_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seats_count.TextChanged += new System.EventHandler(this.seats_count_TextChanged);
            // 
            // seats_count_btn
            // 
            this.seats_count_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seats_count_btn.FlatAppearance.BorderSize = 0;
            this.seats_count_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seats_count_btn.Location = new System.Drawing.Point(461, 85);
            this.seats_count_btn.Margin = new System.Windows.Forms.Padding(0);
            this.seats_count_btn.Name = "seats_count_btn";
            this.seats_count_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.seats_count_btn.Size = new System.Drawing.Size(52, 23);
            this.seats_count_btn.TabIndex = 3;
            this.seats_count_btn.TabStop = false;
            this.seats_count_btn.Text = "자릿수";
            this.seats_count_btn.UseVisualStyleBackColor = false;
            this.seats_count_btn.Click += new System.EventHandler(this.seats_count_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.seats_count);
            this.panel1.Controls.Add(this.seats_count_btn);
            this.panel1.Controls.Add(this.seats_panel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 578);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Seats
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(563, 591);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seats";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Seats_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox seats_count;
        public System.Windows.Forms.FlowLayoutPanel seats_panel;
        private System.Windows.Forms.Button seats_count_btn;
        private System.Windows.Forms.Panel panel1;
    }
}