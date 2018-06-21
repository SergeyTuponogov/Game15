using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game15
{
    public partial class HelpForm : Form
    {
       public struct Vertex
        {
            int[,] state;
             
        }

       
     
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            TextEdt.Text = "";



           
        }


     
        static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
