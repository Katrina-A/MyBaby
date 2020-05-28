using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baby
{
    public partial class MoodFormAdd : Form
    {
        Mood mood;
        public MoodFormAdd(Mood mood)
        {
            InitializeComponent();
            this.mood = mood;
            textBox1.Text = mood.Name;
            textBox2.Text = mood.Time;
            textBox3.Text = mood.Comment;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mood.Name = textBox1.Text;
            mood.Time = textBox2.Text;
            mood.Comment = textBox3.Text;
        }
    }
}
