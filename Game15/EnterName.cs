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
    public partial class EnterName : Form
    {
        public static string name = "";
        public EnterName()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                name = NameTextBox.Text;
                this.Close();
                FormGame form = new FormGame();
                form.Show();
            }
            else MessageBox.Show("Строчка с именем не должна быть пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
