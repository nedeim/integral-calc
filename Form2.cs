using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Интегралы
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void неопределенныйИнтегралToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Неопределенный интеграл";
            richTextBox2.Visible = true;
            richTextBox1.Visible = false;
            richTextBox3.Visible = false;
        }

        private void определенныйИнтегралToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Определенный интеграл";
            richTextBox3.Visible = true;
            richTextBox2.Visible = false;
            richTextBox1.Visible = false;

        }

        private void определениеtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Определение интеграла";
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Visible = true;
            base.Close();
        }
    }
}
