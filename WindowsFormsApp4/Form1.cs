using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {

                Random random = new Random();
                int R, G, B;
                R = random.Next(0, 255);
                G = random.Next(0, 255);
                B = random.Next(0, 255);
                this.BackColor = Color.FromArgb(R, G, B);

                bt.Dispose();

                Button button = new Button();
                button.Font = new Font("Minecrafter", 20, FontStyle.Regular);
                button.Text = "Catch\nMe";
                button.ForeColor = Color.Red;
                button.BackColor = Color.Aqua;
                button.AutoSize = true;
                button.MouseHover += button1_MouseHover;

                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                button.Location = new Point(randomX, randomY);

                this.Controls.Add(button);
            }
        }
    }
}
