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
    public partial class EventFormAdd : Form
    {
        Event @event;
        public EventFormAdd(Event @event)
        {
            InitializeComponent();
            this.@event = @event;
            textBox1.Text = @event.Name;
            textBox2.Text = @event.Time;
            textBox3.Text = @event.Comment;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            @event.Name = textBox1.Text;
            @event.Time = textBox2.Text;
            @event.Comment = textBox3.Text;
        }
    }
}
