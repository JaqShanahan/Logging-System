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

namespace LS
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ye = textBox1.Text + textBox2.Text;
            string path = @"F:\Projects\GitHub\Loging System\LS\All Logs\" + ye + ".txt";
            TextWriter tw = new StreamWriter(path);
            if (!File.Exists(path))
            {
                File.Create(path);
                tw.Close();
            }
            label1.Text = ye;
            tw.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ye = textBox1.Text + textBox2.Text;
            //change logs to the folder directory of your choice
            string path = @"F:\Projects\GitHub\Loging System\LS\All Logs\" + ye + ".txt";
            TextWriter tw = new StreamWriter(path);
            //tw.Close();
            if (File.Exists(path))
            {
                tw.WriteLine(textBox1.Text + textBox2.Text);
                tw.Close();
            }
        }
    }
}
