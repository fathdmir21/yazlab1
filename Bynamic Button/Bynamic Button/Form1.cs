using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bynamic_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int count=1;
        int X = 0;
        int Y = 0;
        List<Button> btn_list = new List<Button>();
        private void button1_Click(object sender, EventArgs e)
        {
            createBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void createBoard()
        {
            //List<Button> btn_list;
            int X = 0;
            int Y = 0;
            int x, y;
            x = Convert.ToInt32(xText.Text);
            y = Convert.ToInt32(yText.Text);
            X = x;
            Y = y;
            int top = 50;
            int left = 50;
            int right = 50;
            int count = 0;
            for (int k = 0; k < X; k++)
            {
                left = left + 50;
                for (int i = 0; i < Y; i++)
                {

                    Button button = new Button();
                    button.Left = left;
                    button.Size = new Size(35, 35);
                    button.Top = top;
                    this.Controls.Add(button);
                    top += button.Height + 2;
                    button.Name = count.ToString();
                    count++;
                    btn_list.Add(button);
                    label2.Text = count.ToString();
                }
                top = 50;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
