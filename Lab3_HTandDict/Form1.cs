using System.Collections;
using System.Text.RegularExpressions;

namespace Lab3_HTandDict
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Hashtable hashtable;
        private Dictionary<int, string> dict;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            hashtable = new Hashtable();
            dict = new Dictionary<int, string>();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btnHtAdd_Click(object sender, EventArgs e)
        {
            
            bool isDigit = Regex.IsMatch(txtKey.Text, @"^[1-9999]+$");
            bool isValid = Regex.IsMatch(txtValue.Text, @"^[a-zA-Z]+$");

            if (isValid)
            {

                if (txtKey.Text == "" || txtValue.Text == "")
                {
                    MessageBox.Show("one text boxes empty ", "Push Stack", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                if (txtKey.Text != "" && txtValue.Text == "")
                {
                    MessageBox.Show("Enter something in both textboxes to Add");
                }
                else if (hashtable.Contains(txtKey.Text))
                {
                    MessageBox.Show("Key already present in the hastable");
                }
                else
                {
                    if (isDigit)
                    {
                        hashtable.Add(txtKey.Text, txtValue.Text);
                    }
                    else
                    {
                        MessageBox.Show("Enter number in Value TextField");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }
        }

        private void btnHtRemove_Click(object sender, EventArgs e)
        {

            if (txtKey.Text != "" && txtValue.Text == "")
            {
                MessageBox.Show("Enter something in both textboxes to Remove");
            }
            else if (!hashtable.Contains(txtKey.Text))
            {
                MessageBox.Show("Value not present in the hastable to remove");
            }
            else
            {
                hashtable.Remove(txtKey.Text);
            }
        }

        private void btnHtDisplay_Click(object sender, EventArgs e)
        {

            lbxDisplay.Items.Clear();
            foreach (DictionaryEntry de in hashtable)
            {
                lbxDisplay.Items.Add(de.Key + " - " + de.Value);
            }
            if (!hashtable.Contains(txtKey.Text))
            {
                MessageBox.Show("Hashtable is Empty");
            }
            janki;
        }

        private void btnDictAdd_Click(object sender, EventArgs e)
        {
            bool isValid = Regex.IsMatch(txtValue.Text, @"^[a-zA-Z]+$");
            bool isdigitvalid = Regex.IsMatch(txtKey.Text, @"^[1-9999]+$");
            if (isValid || isdigitvalid)
            {
                dict.Add(Int32.Parse(txtKey.Text), txtValue.Text);
            }
            else if (txtKey.Text == " " || txtValue.Text == "")
            {
                MessageBox.Show("Enter something in both TextFields");
            }
            else
            {
                MessageBox.Show("Enter proper Value in TextFields");
            }

        }

        private void btnDictRemove_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtValue.Clear();
            bool isDigit = Regex.IsMatch(txtKey.Text, @"^[1-9999]+$");
            if (isDigit)
            {
                dict.Remove(Int32.Parse(txtKey.Text));
            }
            else if (!hashtable.Contains(txtKey))
            {
                MessageBox.Show("Key not found");
            }
        }

        private void btnDictDisplay_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtValue.Clear();
            lbxDisplay.Items.Clear();
            foreach(KeyValuePair<int, string> kvp in dict)
            {
                lbxDisplay.Items.Add(kvp.Key + " - " + kvp.Value);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtValue.Clear();
            hashtable.Clear();
            if(hashtable.Count <= 0)
            {
                MessageBox.Show("Hashtable is empty");
            }

        }

        private void btnValues_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
            if (hashtable.ContainsValue(txtValue.Text))
            {
                lbxDisplay.Items.Add("Value is: " + txtValue.Text + " Key is: " + txtKey.Text);
            }
            else
            {
                MessageBox.Show("Value not present in the Hashtable");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            dict.Clear();
            if (dict.Count <= 0)
            {
                MessageBox.Show("Dictionary is Already empty");
            }
        }

        private void btncheckValue_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<int, String> kvp in dict)
            {
                if (kvp.Value == txtValue.Text)
                {
                    lblCheck.Text = "Key is: " + txtKey.Text + "Value is: " + txtValue.Text;
                }
                else
                {
                    lblCheck.Text = "Value not Found ";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}