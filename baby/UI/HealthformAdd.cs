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
    public partial class HealthformAdd : Form
    {
        Health health;

        public HealthformAdd(Health health)
        {
            InitializeComponent();
            this.health = health;
            comboBox1.DataSource = typeof(Vaccinations).GetEnumValues();
            textBox1.Text = health.Time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            health.Vaccinations = (Vaccinations)comboBox1.SelectedItem;
            health.Time = textBox1.Text;
        }
    }
}
