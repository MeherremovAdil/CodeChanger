using System;

namespace HelloWorld_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "python" && comboBox2.Text == "1+1 toplama")
            {
                listBox1.Items.Add("print(1+1)");
                listBox1.Items.Add("2");
                listBox1.Items.Add("---------");
            }
            else if (comboBox1.Text == "python" && comboBox2.Text == "Hello World yazdirmaq")
            {
                listBox1.Items.Add("print('Hello World')");
                listBox1.Items.Add("Hello World");
                listBox1.Items.Add("---------");

            }

            if (comboBox1.Text == "javascript" && comboBox2.Text == "1+1 toplama")
            {
                listBox1.Items.Add("console.log(1+1);");
                listBox1.Items.Add("2");
                listBox1.Items.Add("---------");
            }
            else if(comboBox1.Text == "javascript" && comboBox2.Text == "Hello World yazdirmaq")
            {
                listBox1.Items.Add("console.log('Hello World');");
                listBox1.Items.Add("Hello World");
                listBox1.Items.Add("---------");
            }

            if (comboBox1.Text == "c#" && comboBox2.Text == "1+1 toplama")
            {
                listBox1.Items.Add("Console.WriteLine(1+1);");
                listBox1.Items.Add("2");
                listBox1.Items.Add("---------");
            }
            else if(comboBox1.Text == "c#" && comboBox2.Text == "Hello World yazdirmaq")
            {
                listBox1.Items.Add("Console.WriteLine('Hello World');");
                listBox1.Items.Add("Hello World");
                listBox1.Items.Add("---------");
            }

            if (comboBox1.Text == "java" && comboBox2.Text == "1+1 toplama")
            {
                listBox1.Items.Add("System.out.println(“1+1”):");
                listBox1.Items.Add("2");
                listBox1.Items.Add("---------");
            }
            else if(comboBox1.Text == "java" && comboBox2.Text == "Hello World yazdirmaq")
            {
                listBox1.Items.Add("System.out.println(“Hello World”):");
                listBox1.Items.Add("Hello World");
                listBox1.Items.Add("---------");
            }
        }
    }
}