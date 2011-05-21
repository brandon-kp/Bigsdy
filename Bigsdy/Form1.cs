using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bigsdy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string path = textBox1.Text + "\\res\\defaults.yaml";

            if (!File.Exists(path))
            {
                textBox2.Text = "\r\nThe file we're looking for doesn't exist. Please make sure the path to Digsby is correct.";
            }
            else
            {
                string text = System.IO.File.ReadAllText(path);
                string newtext = text.Replace("ads: yes", "ads: no");

                using (StreamWriter outfile = new StreamWriter(path))
                {
                    outfile.Write(newtext);
                }

                textBox2.Text = "\n\r\nI hope you're happy.\r\nRestart Digsby to see full effects.";
            }
        }

        private void Form1_Load(object sender, EventArgs e){}
    }
}
