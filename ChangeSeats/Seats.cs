using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChangeSeats
{
    public partial class Seats : Form
    {
        public Seats()
        {
            InitializeComponent();
        }

        int selected_index = -1;

        private class Data {
            public string[] seat { get; set; }
        }

        //Control -> Your ControlType
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

        private void seat_click(object sender, EventArgs e) {
            if (selected_index != -1) {
                string target1 = seats_panel.Controls[selected_index].Text;
                string target2 = ((Seat)sender).Text;
                DialogResult d = MessageBox.Show($"{target1}님과 {target2}님의 자리를 바꾸시겠습니까? ");
                if (d == DialogResult.OK) {
                    string temp = target1;
                    seats_panel.Controls[selected_index].Text = target2;
                    ((Seat)sender).Text = temp;
                }
            } else {
                if (selected_index == seats_panel.Controls.IndexOf(((Seat)sender))) {
                    ((Seat)sender).BorderSize = 1;
                    ((Seat)sender).BorderColor = Color.Black;
                    selected_index = -1;
                } else {
                    ((Seat)sender).BorderSize = 3;
                    ((Seat)sender).BorderColor = Color.Red;
                    selected_index = seats_panel.Controls.IndexOf(((Seat)sender));
                }
            }
        }

        private void seats_count_TextChanged(object sender, EventArgs e)
        {
            seats_panel.Controls.Clear();
            int count = (seats_count.Text.Length > 0) ? int.Parse(seats_count.Text) : 0;
            for (int i = 0; i < count; i++) {
                Seat seat = new Seat() {
                    Size = new Size(100,60),
                    BorderRadius = 20,
                    Name = $"seat{i+1}",
                    Text = "",
                    Margin = new Padding(20,10,10,10),
                    TextAlign = ContentAlignment.MiddleCenter,
                    // BackgroundColor = Color.SandyBrown,
                    BackgroundColor = Color.FromArgb(255,192, 208, 208),
                    BorderColor = Color.Black,
                    BorderSize = 1,
                    Font = new Font("맑은 고딕", 15, FontStyle.Bold),
                    ForeColor = Color.Black,
                    TabStop = false,
                };
                seat.Click += seat_click;
                seats_panel.Controls.Add(seat);
            }
        }

        private void seats_count_btn_Click(object sender, EventArgs e)
        {
            if (seats_count_btn.Text == "자릿수") {
                seats_count_btn.Text = "변경";
                seats_count.Enabled = true;
                label1.Focus();
            } else {
                seats_count_btn.Text = "자릿수";
                seats_count.Enabled = false;
                label1.Focus();
            }
        }

        private void Seats_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
