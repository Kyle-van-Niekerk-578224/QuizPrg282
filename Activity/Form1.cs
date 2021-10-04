using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //On Button Click, Read + display data from txt
            //This was edited in GitHub
            int counter = 0;
            string line, outString;

            System.IO.StreamReader file =
                new System.IO.StreamReader(@".\bin\debug\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                outString = line;
                listBox1.Items.Add(outString);
                //System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
        }
    }
}
