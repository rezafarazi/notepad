using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication342
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int z = int.Parse(textBox1.Text);
                if (z < 0)
                    MessageBox.Show("عدد نمی تواند منفی باشد");
                if (e.KeyCode == Keys.Enter)
                {
                    System.IO.File.WriteAllText("C:\\ProgramData\\wordpad.txt", z.ToString());
                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
