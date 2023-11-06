using prim6_lek6.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prim6_lek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < library.Length; i++)
            {
                dataGridView1.Rows.Add(library[i].Avtor, library[i].Name);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Library2 library = new Library2();
            dataGridView1.Rows.Clear();
            foreach (Book b in library)
            {
                dataGridView1.Rows.Add(b.Avtor, b.Name);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Library3 library = new Library3();
            dataGridView1.Rows.Clear();

            foreach (Book b in library.GetBooks())
            {
                dataGridView1.Rows.Add(b.Avtor, b.Name);
            }

        }
    }
}
