namespace ChangeSeats
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.draw_btn = new System.Windows.Forms.Button();
            this.num_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.user_name_box = new System.Windows.Forms.TextBox();
            this.open_table_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw_btn
            // 
            this.draw_btn.BackColor = System.Drawing.Color.Gray;
            this.draw_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.draw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draw_btn.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.draw_btn.ForeColor = System.Drawing.Color.White;
            this.draw_btn.Location = new System.Drawing.Point(0, 200);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(476, 36);
            this.draw_btn.TabIndex = 0;
            this.draw_btn.Text = "추첨하기";
            this.draw_btn.UseVisualStyleBackColor = false;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.Font = new System.Drawing.Font("맑은 고딕", 40F);
            this.num_label.Location = new System.Drawing.Point(184, 92);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(90, 72);
            this.num_label.TabIndex = 1;
            this.num_label.Text = "00";
            this.num_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_name_box
            // 
            this.user_name_box.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.user_name_box.Location = new System.Drawing.Point(78, 21);
            this.user_name_box.Name = "user_name_box";
            this.user_name_box.Size = new System.Drawing.Size(109, 43);
            this.user_name_box.TabIndex = 2;
            this.user_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // open_table_btn
            // 
            this.open_table_btn.BackColor = System.Drawing.Color.Gray;
            this.open_table_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.open_table_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_table_btn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.open_table_btn.ForeColor = System.Drawing.Color.White;
            this.open_table_btn.Location = new System.Drawing.Point(440, 22);
            this.open_table_btn.Name = "open_table_btn";
            this.open_table_btn.Size = new System.Drawing.Size(36, 178);
            this.open_table_btn.TabIndex = 3;
            this.open_table_btn.Text = "자리표보기";
            this.open_table_btn.UseVisualStyleBackColor = false;
            this.open_table_btn.Click += new System.EventHandler(this.open_table_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 22F);
            this.label1.Location = new System.Drawing.Point(181, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "님의 자리는??";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.user_name_box);
            this.panel1.Controls.Add(this.open_table_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.draw_btn);
            this.panel1.Controls.Add(this.num_label);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 236);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.label2.Location = new System.Drawing.Point(254, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "번";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Gray;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(440, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(36, 24);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(484, 243);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자리 바꾸기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw_btn;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox user_name_box;
        private System.Windows.Forms.Button open_table_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label2;
    }
}

