using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HTandDict
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        HashSet<String> hSet1;
        HashSet<String> hSet2;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            hSet1 = new HashSet<String>();
            hSet2 = new HashSet<String>();
            this.form3 = new Form3(this);
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("TextBox is Empty");
            }
            hSet1.Add(textBox1.Text);
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            if (!hSet1.Contains(textBox1.Text))
            {
                MessageBox.Show("Item not present in the hashset");
            }
            else
            {
                hSet1.Remove(textBox1.Text);
            }
        }

            private void btnAdd2_Click(object sender, EventArgs e)
        {
            hSet2.Add(textBox1.Text);
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("TextBox is Empty");
            }
            else
            {
                hSet2.Remove(textBox1.Text);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            hs1.Items.Clear();
            hs2.Items.Clear();

            foreach(String item in hSet1)
            {
                hs1.Items.Add(item);
            }

            foreach (String item in hSet2)
            {
                hs2.Items.Add(item);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(hSet1.Count <= 0 && hSet2.Count <= 0)
            {
                MessageBox.Show("Hashset is Already Empty");
            }
            else
            {
                hSet1.Clear();
                hSet2.Clear();
            }
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            hSet1.IntersectWith(hSet2);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            hSet1.UnionWith(hSet2);
        }

        private void btnSubset_Click(object sender, EventArgs e)
        {
            lblresult.Text= hSet1.IsSubsetOf(hSet2).ToString();
        }

        private void btnSuperset_Click(object sender, EventArgs e)
        {
            lblresult.Text = hSet1.IsSupersetOf(hSet2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }
    }
}