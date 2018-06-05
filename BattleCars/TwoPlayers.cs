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
    public partial class TwoPlayers : Form
    {
        public String PalyerOne;
        public String PlayerTwo;
        public TwoPlayers()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            var pos = this.PointToScreen(lblPlayerName.Location);
            pos = pictureBox1.PointToClient(pos);
            lblPlayerName.Parent = pictureBox1;
            lblPlayerName.Location = pos;
            lblPlayerName.BackColor = Color.Transparent;
            var pos1 = this.PointToScreen(lblPlayer1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            lblPlayer1.Parent = pictureBox1;
            lblPlayer1.Location = pos1;
            lblPlayer1.BackColor = Color.Transparent;
            var pos2 = this.PointToScreen(lblPlayer2.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            lblPlayer2.Parent = pictureBox1;
            lblPlayer2.Location = pos2;
            lblPlayer2.BackColor = Color.Transparent;
        }

        private void TwoPlayers_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
