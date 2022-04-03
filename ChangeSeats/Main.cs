using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading;
using System.Runtime.InteropServices;

namespace ChangeSeats
{
    public partial class Main : Form
    {
        Seats seats;
        public Main() { 
            InitializeComponent();
            seats = new Seats() {
                Visible = false
            };
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != MouseButtons.Left)
                return;
            
            s.Parent.Left = Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }

        private List<int> get_remain() {
            List<int> temp = new List<int>();
            for (int i = 0; i < seats.seats_panel.Controls.Count; i++) {
                if (seats.seats_panel.Controls[i].Text == "") {
                    temp.Add(i);
                }
            }
            return temp;
        }

        private int mix_num(List<int> remain) {
            int num = remain[new Random().Next(0, remain.Count)]+1;
            Thread t = new Thread(() => {
                for (int i = 0; i < 15; i++) {
                    int _num = new Random().Next(1, seats.seats_panel.Controls.Count);
                    num_label.Text = _num.ToString().PadLeft(2, '0');
                    Thread.Sleep(50);
                }
                num_label.Text = num.ToString().PadLeft(2, '0');
            });
            t.Start();
            t.Join();
            return num;
        }

        private void draw_btn_Click(object sender, EventArgs e)
        {
            if (seats.seats_panel.Controls.Count <= 0) {
                MessageBox.Show("좌석 수를 한개이상 설정 해주세요", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> remain = get_remain();
            if (remain.Count <= 0) {
                MessageBox.Show("남은 자석이 없습니다..?", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student_name = user_name_box.Text;
            user_name_box.Clear();
            if (student_name.Length < 0) {
                MessageBox.Show("학생 이름을 입력해주세요", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user_name_box.Focus();
                return;
            }
            foreach (Control label in seats.seats_panel.Controls) {
                if (student_name == label.Text) {
                    MessageBox.Show("이미 추첨을 하셨습니다.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int num = mix_num(remain);
            seats.seats_panel.Controls[num-1].Text = student_name;
            MessageBox.Show($"학생 {student_name}님의 자리는 {num}번이 되겠습니다!");
        }

        private void open_table_btn_Click(object sender, EventArgs e)
        {
            if (open_table_btn.Text == "자리표보기") {
                seats.Show();
                open_table_btn.Text = "자리표끄기";
            } else {
                seats.Hide();
                open_table_btn.Text = "자리표보기";
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (double i = 0; i < 1.00; i += 0.01) {
                this.Opacity = i;
                Delay(1);
            }
            this.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (double i = 1.00; i > 0.00; i -= 0.01) {
                this.Opacity = i;
                Delay(1);
            }
        }
    }
}
