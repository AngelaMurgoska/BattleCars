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
        public SinglePlayer()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            var pos = this.PointToScreen(lblPlayerName.Location);
            pos = pictureBox1.PointToClient(pos);
            lblPlayerName.Parent = pictureBox1;
            lblPlayerName.Location = pos;
            lblPlayerName.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
