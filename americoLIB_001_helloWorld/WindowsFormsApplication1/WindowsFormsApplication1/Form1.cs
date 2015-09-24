using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //WINDOW
    public partial class Form1 : Form
    {
        //START
        public Form1()
        {
            InitializeComponent();
        }

        //PRINT MESSAGE
        private void button1_Click(object sender, EventArgs e)
        {
            //WINDOW
            MessageBox.Show("HELLO WORLD OF C#");
        }
    }
}
