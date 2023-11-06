using prim5_lek6.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prim5_lek6
{
    public partial class Form1 : Form
    {
        string patch = "teacher.xml";
        Teacher_list teacher=new Teacher_list();
        public void show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Teacher p in teacher.people)
            {
                dg.Rows.Add(p.FirstName, p.LastName,p.Degree ,p.Experience);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new Teacher(textBox1.Text, 
                textBox2.Text, 
                Convert.ToInt16(textBox3.Text)) ;
            var s=comboBox1.SelectedItem.ToString();
            t.Degree =  s;
            teacher.add(t);
            dataGridView1.Rows.Add(
                    teacher.people[teacher.people.Count - 1].FirstName,
                    teacher.people[teacher.people.Count - 1].LastName,
                    teacher.people[teacher.people.Count - 1].Degree,
                    teacher.people[teacher.people.Count - 1].Experience
                    );
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            dataGridView1.Rows.Clear();
        }
       private void button2_Click(object sender, EventArgs e)
        {
            teacher.writeFile(patch);
            MessageBox.Show("Дані записані");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            teacher.readFile(patch);
            show(dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            teacher.people.Sort();
            show(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var i = dataGridView1.CurrentRow.Index;
            teacher.remove(i);
            show(dataGridView1);
        }
    }
}
