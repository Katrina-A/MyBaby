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
    public partial class ActivityFormAdd : Form
    {
        Activity activity;

        public ActivityFormAdd(Activity activity)
        {
            InitializeComponent();
            this.activity = activity;
            textBox3.Text = activity.Name;
            textBox1.Text = activity.Time;
            textBox2.Text = activity.Comment;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activity.Name = textBox3.Text;
            activity.Time = textBox1.Text;
            activity.Comment = textBox2.Text;
        }
    }
}
