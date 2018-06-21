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
    public partial class StartMenu : Form
    {
        public static byte choiseLevel = 0;
        public StartMenu()
        {
            InitializeComponent();
        }
        private void buttonGame8_Click(object sender, EventArgs e)
        {
            EnterName enterName = new EnterName();
            enterName.Show();
            choiseLevel = 3;
        }
        private void buttonGame15_Click(object sender, EventArgs e)
        {
            choiseLevel = 4;
            EnterName enterName = new EnterName();
            enterName.Show();
        }
        private void buttonGame24_Click(object sender, EventArgs e)
        {
            choiseLevel = 5;
            EnterName enterName = new EnterName();
            enterName.Show();           
        }       
        private void помошьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пятнашки - известная головомка, представляющая набор,\nв который входит квадратная коробка (3х3, 4x4, 5x5).\nВнутри этой коробки 8, 15 или 24 костяшек.\nВ коробке остается 1 свободное место под костяшку.\nЦель игры - упорядочить костяшки по порядку. Концом игры считается, когда все костяшки стоят друг за другом.", "Об игре", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тупоногов Сергей Анатольевич - студент ВятГУ.\nФакультет компьютерных и физико-математических наук.\nНаправление: Фундаментальная информатика и информационные технологии.", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void легкийУровеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choiseLevel = 3;
            ResultForm openResult = new ResultForm();
            openResult.Show();
        }
        private void среднийУровеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choiseLevel = 4;
            ResultForm openResult = new ResultForm();
            openResult.Show();
        }
        private void сложныйУровеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choiseLevel = 5;
            ResultForm openResult = new ResultForm();
            openResult.Show();
        }
    }
}
