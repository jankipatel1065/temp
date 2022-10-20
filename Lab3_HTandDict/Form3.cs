using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HTandDict
{
    
    public partial class Form3 : Form  
    {
        private Form2 form2;
        SortedSet<String> sSet1;
        SortedSet<String> sSet2;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            sSet1 = new SortedSet<String>();
            sSet2 = new SortedSet<String>();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            ss1.Items.Clear();
            ss2.Items.Clear();

            foreach (String item in sSet1)
            {
                ss1.Items.Add(item);
            }

            foreach (String item in sSet2)
            {
                ss2.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sSet1.Clear();
            sSet2.Clear();
        }

        private void btnintersect_Click(object sender, EventArgs e)
        {
            sSet1.IntersectWith(sSet2);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            sSet1.UnionWith(sSet2);
        }

        private void btnSubset_Click(object sender, EventArgs e)
        {
            lblResult.Text = sSet1.IsSubsetOf(sSet2).ToString();
        }

        private void tnSuperSet_Click(object sender, EventArgs e)
        {
            lblResult.Text = sSet1.IsSupersetOf(sSet2).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("TextBox is Empty");
            }
            sSet1.Add(textBox1.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!sSet1.Contains(textBox1.Text))
            {
                MessageBox.Show("Item not present in the hashset");
            }
            sSet1.Remove(textBox1.Text);
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("TextBox is Empty");
            }
            sSet2.Add(textBox1.Text);
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            if (!sSet2.Contains(textBox1.Text))
            {
                MessageBox.Show("Item not present in the hashset");
            }
            sSet2.Remove(textBox1.Text);
        }
        janki;
        private void ss1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
