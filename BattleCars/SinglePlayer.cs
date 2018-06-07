using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SinglePlayer : Form
    {
        public String Name;
        public Form f { get; set; }
        public SinglePlayer(Form f)
        {
            InitializeComponent();
            this.f = f;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            var pos = this.PointToScreen(lblPlayerName.Location);
            pos = pictureBox1.PointToClient(pos);
            lblPlayerName.Parent = pictureBox1;
            lblPlayerName.Location = pos;
            lblPlayerName.BackColor = Color.Transparent;

            lblPlayerName.Location = new Point(this.Width / 2 - lblPlayerName.Width / 2, this.Height / 10);
            txtPlayer.Location = new Point(this.Width / 2 - txtPlayer.Width / 2, this.Height *2/ 10);
            bBack.Location = new Point(this.Width / 2 - bBack.Width - 10, this.Height * 3 / 10);
            btnStart.Location = new Point(this.Width / 2 + 10, this.Height * 3 / 10);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void bBack_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }
    }
}
