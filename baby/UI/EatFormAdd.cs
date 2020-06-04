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
    public partial class EatFormAdd : Form
    {
        Eat eat;
        public EatFormAdd(Eat eat)
        {
            InitializeComponent();
            this.eat = eat;
            comboBox1.DataSource = typeof(EatEnum).GetEnumValues();
            comboBox1.DisplayMember = "Name";
            textBox1.Text = eat.Time;
            textBox2.Text = eat.Comment;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eat.EatEnum = (EatEnum)comboBox1.SelectedItem;
            eat.Time = textBox1.Text;
            eat.Comment = textBox2.Text;
            Close();
        }
    }
}
