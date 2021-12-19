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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                button1.BackColor = Color.LightBlue;
                button3.BackColor = Color.LightGray;
                button2.BackColor = Color.LightGray;
            }
            else if (a == 2)
            {
                a = 0;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
               button1.BackColor = Color.LightGray;
            }
        }
        int b = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            b++;
            if (b == 1)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                button2.BackColor = Color.LightBlue;
                button1.BackColor = Color.LightGray;
                button3.BackColor = Color.LightGray;
            }
            else if (b == 2)
            {
                b = 0;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                button2.BackColor = Color.LightGray;
            }
        }
        int c = 0;
        private void button3_Click(object sender, EventArgs e)
        {
           c++;
            if (c == 1)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                button3.BackColor = Color.LightBlue;
                button1.BackColor = Color.LightGray;
                button2.BackColor = Color.LightGray;
            }
            else if (c == 2)
            {
                c = 0;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                button3.BackColor = Color.LightGray;
            }
        }
        int d = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            d++;
            if (d == 1)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, fontsizee, FontStyle.Bold);
                button4.BackColor = Color.LightBlue;
            }
            else if (d == 2)
            {
                d = 0;
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, fontsizee, FontStyle.Regular); 
                button4.BackColor = Color.LightGray;
            }
        }
        int f = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            f++;
            if (f == 1)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif,fontsizee, FontStyle.Underline);
                button5.BackColor = Color.LightBlue;
            }
            else if (f == 2)
            {
                f = 0;
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, fontsizee, FontStyle.Regular);
                button5.BackColor = Color.LightGray;
            }
        }
        int g = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            g++;
            if (g == 1)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, fontsizee, FontStyle.Italic);
                button6.BackColor = Color.LightBlue;
            }
            else if (g == 2)
            {
                g = 0;
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, fontsizee, FontStyle.Regular);
                button6.BackColor = Color.LightGray;
            }
        }
        int fontsizee;
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.FontFamily[] fontNames = System.Drawing.FontFamily.Families;
            for (int i = 0; i < fontNames.Length; i++)
            {
                comboBox2.Items.Add(fontNames[i].Name);

            }
            comboBox1.Text = "8";
            comboBox2.Text = "Tahoma";
            float[] fontSize = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            for (int aaa = 0; aaa <= fontSize.Length; aaa++)
                comboBox1.Items.Add(fontSize[aaa].ToString());
            System.IO.File.WriteAllText("C:\\ProgramData\\wordpad.txt","30");
            button5.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Underline);
            button6.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Italic);
            
            comboBox2.Text = fontNames[0].Name;

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "notepade+-bonak|*nb|*.txt|*.txt";
                openFileDialog1.ShowDialog();
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
            catch
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "notepade+-bonak|*nb|*.txt|*.txt";
                saveFileDialog1.ShowDialog();
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
            catch
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a=int.Parse(System.IO.File.ReadAllText("C:\\ProgramData\\wordpad.txt"));
            richTextBox1.BulletIndent =a;
            richTextBox1.SelectionBullet = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 h = new Form2();
            h.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox7.Visible = false;
            groupBox8.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            groupBox8.Top -= 1;
            if (groupBox8.Location == groupBox7.Location)
            {
                timer1.Stop();
                groupBox8.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
            groupBox8.Visible = false;
            groupBox8.Enabled = false;
            groupBox8.Top = 114;
            groupBox8.Left = 12;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap g = new Bitmap(openFileDialog1.FileName);
            Clipboard.SetDataObject(g);
            richTextBox1.Paste();
        }
        string copy;
        private void کپیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            جایگذاریToolStripMenuItem.Enabled = true;
            richTextBox1.Copy();
        }

        private void جایگذاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void انتقالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            جایگذاریToolStripMenuItem.Enabled = true;
            richTextBox1.Cut();
        }

        private void تنظیماتکلیفونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily j = new FontFamily(comboBox2.SelectedItem.ToString());
            Font q = new Font(j, int.Parse(comboBox1.Text.ToString()));
            richTextBox1.SelectionFont = q;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
