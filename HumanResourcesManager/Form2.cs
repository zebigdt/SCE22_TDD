using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace HumanResourcesManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" )
            {
                MessageBox.Show("אנא מלא את כל הפרטים");
            }
            else
            {
                Worker worker = new Worker(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                Form1.workerList.Add(worker);
                this.Close();
            }
            
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^\u0590-\u05FF -]"))
                {
                    MessageBox.Show("אנא הכנס שם פרטי בעברית");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    textBox1.Focus();
                }
            }
            catch (ArgumentException)
            {
                textBox1.Text = "";
                textBox1.Focus();
            }


        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 2)
            {
                MessageBox.Show("שם אינו תקין");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^\u0590-\u05FF -]"))
                {
                    MessageBox.Show("אנא הכנס שם משפחה בעברית");
                    textBox2.Text = textBox1.Text.Remove(textBox2.Text.Length - 1);
                    textBox2.Focus();
                }
            }
            catch (ArgumentException)
            {
                textBox2.Text = "";
                textBox2.Focus();
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 2)
            {
                MessageBox.Show("שם משפחה אינו תקין");
                textBox2.Text = "";
                textBox2.Focus();
            }
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
                {
                    MessageBox.Show("אנא הכנס מספרים בלבד");
                    textBox3.Text = textBox1.Text.Remove(textBox3.Text.Length - 1);
                    textBox3.Focus();
                }
            }
            catch (ArgumentException)
            {
                textBox3.Text = "";
                textBox3.Focus();
            }
        }
        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (!Utility.ValidateID(textBox3.Text))
            {
                MessageBox.Show("מספר תעודת זהות אינו תקין");
                textBox3.Text = "";
                textBox3.Focus();
            }
        }
        private void TextBox4_Leave(object sender, EventArgs e)
        {
            try
            {
                MailAddress m = new MailAddress(textBox4.Text);


            }
            catch (ArgumentException)
            {
                MessageBox.Show("כתובת מייל לא יכולה להיות ריקה");
                textBox4.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("אנא הכנס כתובת מייל תקינה ");
                textBox4.Focus();
            }

        }
        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
                {
                    MessageBox.Show("אנא הכנס מספרים בלבד");
                    textBox5.Text = textBox1.Text.Remove(textBox5.Text.Length - 1);
                    textBox5.Focus();
                }
            }
            catch (ArgumentException)
            {
                textBox5.Text = "";
                textBox5.Focus();
            }
        }
        private void TextBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text.Length < 8 || textBox5.Text.Length > 10)
            {
                MessageBox.Show("מספר טלפון אינו תקין");
                textBox5.Text = "";
                textBox5.Focus();
            }
        }
        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^\u0590-\u05FF 0-9-,]"))
                {
                    MessageBox.Show("אנא הכנס כתובת תקינה");
                    textBox6.Text = textBox1.Text.Remove(textBox6.Text.Length - 1);
                    textBox6.Focus();

                }
            }
            catch (ArgumentException)
            {
                textBox6.Text = "";
                textBox6.Focus();
            }
        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text.Length < 2)
            {
                MessageBox.Show("כתובת אינה תקינה");
                textBox6.Text = "";
                textBox6.Focus();
            }
        }
        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
                {
                    MessageBox.Show("אנא הכנס מספרים בלבד");
                    textBox7.Text = textBox1.Text.Remove(textBox7.Text.Length - 1);
                    textBox7.Focus();
                }
            }
            catch (ArgumentException)
            {
                textBox7.Text = "";
                textBox7.Focus();
            }
        }

        private void TextBox7_Leave(object sender, EventArgs e)
        {
            try
            {
                int sa = Int32.Parse(textBox7.Text);
                if (sa < 3000 || sa > 50000)
                {
                    MessageBox.Show("אנא הכנס משכורת בין 3,000 ל50,000");
                    textBox7.Text = "";
                    textBox7.Focus();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("אנא הכנס משכורת בין 3,000 ל50,000");
                textBox7.Focus();
            }
            
        }

        
    }
}
