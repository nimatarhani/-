using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                _ = x <= 20;
                switch (x)
                {
                    case 0:
                        label1.Text = "false";
                        break;
                    case 1:
                        label1.Text = "false";
                        break;
                    case 2:
                        label1.Text = "false";
                        break;
                    case 3:
                        label1.Text = "false";
                        break;
                    case 4:
                        label1.Text = "false";
                        break;
                    case 5:
                        label1.Text = "false";
                        break;
                    case 6:
                        label1.Text = "false";
                        break;
                    case 7:
                        label1.Text = "false";
                        break;
                    case 8:
                        label1.Text = "false";
                        break;
                    case 9:
                        label1.Text = "false";
                        break;
                    case 10:
                        label1.Text = "false";
                        break;
                    case 11:
                        label1.Text = "C";
                        break;
                    case 12:
                        label1.Text = "C";
                        break;
                    case 13:
                        label1.Text = "C";
                        break;
                    case 14:
                        label1.Text = "C";
                        break;
                    case 15:
                        label1.Text = "C";
                        break;

                    case 16:
                        label1.Text = "B";
                        break;
                    case 17:
                        label1.Text = "B";
                        break;
                    case 18:
                        label1.Text = "A";
                        break;
                    case 19:
                        label1.Text = "A";
                        break;
                    case 20:
                        label1.Text = "A";
                        break;
                    default: MessageBox.Show("عدد بالای 20 وارد نکنید");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("در وارد کردن اعداد دقت کنید");
            }
            }
    }
}
