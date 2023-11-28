using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp136
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] arr = System.Text.Encoding.UTF8.GetBytes(textBox1.Text);
            System.IO.FileStream f = new System.IO.FileStream(@"G:\G-sharp-14020510\sample.txt", System.IO.FileMode.Create);
            f.Write(arr, 0,arr.Length);
            f.Flush();
            f.Close();
            string t = "abc";
        }
    }
}
