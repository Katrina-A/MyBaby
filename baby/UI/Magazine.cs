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
    public partial class Magazine : Form
    {
        EatDB db;
        ActivityDB activityDB;
        HealthDB healthDB;
        MoodDB moodDB;
        EventDB eventDB;
        public Magazine()
        {
            InitializeComponent();
            db = new EatDB();
            activityDB = new ActivityDB();
            healthDB = new HealthDB();
            moodDB = new MoodDB();
            eventDB = new EventDB();
            ShowEat();
            ShowActivity();
            ShowHealth();
            ShowMood();
            ShowEvent();
        }

        void ShowEat()
        {
            listView1.Items.Clear();
            
            foreach(Eat eat in db.allEats)
            {
                ListViewItem row = new ListViewItem(eat.EatEnum.ToString());
                row.SubItems.Add(eat.Time);
                row.SubItems.Add(eat.Comment);
                listView1.Items.Add(row);
            }
        }

        void ShowActivity()
        {
            listView2.Items.Clear();
            foreach(Activity activity in activityDB.allActivity)
            {
                ListViewItem row = new ListViewItem(activity.Name);
                row.SubItems.Add(activity.Time);
                row.SubItems.Add(activity.Comment);
                listView2.Items.Add(row);
            }
        }

        void ShowHealth()
        {
            listView3.Items.Clear();
            foreach(Health health in healthDB.allHealthes)
            {
                ListViewItem row = new ListViewItem(health.Vaccinations.ToString());
                row.SubItems.Add(health.Time);
                listView3.Items.Add(row);
            }
        }

        void ShowMood()
        {
            listView4.Items.Clear();
            foreach(Mood mood in moodDB.allMood)
            {
                ListViewItem row = new ListViewItem(mood.Name);
                row.SubItems.Add(mood.Time);
                row.SubItems.Add(mood.Comment);
                listView4.Items.Add(row);
            }
        }

        void ShowEvent()
        {
            listView5.Items.Clear();
            foreach(Event _event in eventDB.allEvent)
            {
                ListViewItem row = new ListViewItem(_event.Name);
                row.SubItems.Add(_event.Time);
                row.SubItems.Add(_event.Comment);
                listView5.Items.Add(row);
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void едаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EatFormAdd(db.AddEat()).ShowDialog();
            db.SaveEat();
            ShowEat();
        }

        private void здоровьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HealthformAdd(healthDB.AddHealth()).ShowDialog();
            healthDB.SaveHealth();
            ShowHealth();
        }

        private void активностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActivityFormAdd(activityDB.AddActivity()).ShowDialog();
            activityDB.SaveActivity();
            ShowActivity();
        }

        private void настроениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MoodFormAdd(moodDB.AddMood()).ShowDialog();
            moodDB.SaveMood();
            ShowMood();
        }

        private void важныеСобытияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EventFormAdd(eventDB.AddEvent()).ShowDialog();
            eventDB.SaveEvent();
            ShowEvent();
        }
    }
}
