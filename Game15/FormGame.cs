using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace Game15
{
    public partial class FormGame : Form
    {
        Game game;    
        int count;     
        DateTime Seconds =  new DateTime();    
        Button[] b;
        public static int[] mas = new int[9];
        int sec = 1;         
        public FormGame()
        {
            InitializeComponent();
            game = new Game(StartMenu.choiseLevel);
            b = new Button[StartMenu.choiseLevel * StartMenu.choiseLevel];      
        }
        private void button_enable()
        {
            TableLayoutPanel.Enabled = false;
        }
        private void GifLoad()
        {
            try
            {
                pictureBox1.Invoke((Action)delegate { pictureBox1.Visible = true; });
                pictureBox1.Image = null;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = Image.FromFile("D://5.GIF");
                Thread.Sleep(8000);
            }
            catch (Exception o)
            {
                MessageBox.Show("Ошибка: " + o.Message);
            }                           
        }
        private void FormGame8_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(GifLoad));
            t.IsBackground = true;
            t.Start();            
            TableLayoutPanel.BackColor = Color.White;
            if (StartMenu.choiseLevel == 3)
            {
                Icon icon = new Icon("Icon8.ico");
                this.Icon = icon;
                Text = "Восьмёрки";
            }
            else if (StartMenu.choiseLevel == 4)
            {
                Icon icon = new Icon("Icon15.ico");
                this.Icon = icon;         
                Text = "Пятнашки";
            }
            else if (StartMenu.choiseLevel == 5)
            {
                Icon icon = new Icon("24Icon.ico");
                this.Icon = icon;
                Text = "Двадцатичетырёшки";
            }
            ///////////////////////////////////////////////////// создание сетки 
            TableLayoutPanel.ColumnCount = StartMenu.choiseLevel; //добавление столбцов
            TableLayoutPanel.RowCount = StartMenu.choiseLevel; //добавление строк
            TableLayoutPanel.Dock = DockStyle.Fill; //растянуть на всю форму
            TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            for (int i = 0; i < StartMenu.choiseLevel; i++)
            {
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            }
            timerLabel.BackColor = Color.Lavender;
            /////////////////////////////////////////////////////////////// кнопки                               
            for (int i = 0; i < StartMenu.choiseLevel * StartMenu.choiseLevel; i++)
            {
                b[i] = new Button();
                b[i].BackColor = Color.Lavender;
                b[i].Dock = DockStyle.Fill;
                b[i].Margin = new Padding(3, 3, 3, 3);
                b[i].Tag = i;
                b[i].TabIndex = i;
                TableLayoutPanel.Controls.Add(b[i]);                    
                b[i].Click += new EventHandler(Button_Click); //приводим к типу и устанавливаем обработчик события  
                if (StartMenu.choiseLevel == 5)
                {
                    b[i].Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Pixel, 204);
                } else
                b[i].Font = new Font("Tahoma", 22F, FontStyle.Bold, GraphicsUnit.Pixel, 204);                                
            }       
            start_game();       
        }    
        protected void Button_Click(object sender, EventArgs e)
        {
            count++;
            int position = Convert.ToInt16(((Button)sender).Tag);
         
            game.shift(position);
            refresh();
            if (game.chek_numbers())
            {
                timer1.Enabled = false;
                MessageBox.Show("Количество ходов: " + count + "\nВремя: " + timerLabel.Text, "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);            
                button_enable();
                if (StartMenu.choiseLevel == 3) TxtFor8();
                else if (StartMenu.choiseLevel == 4) TxtFor15();
                else TxtFor24();               
            }
        }     
        private Button button(int position)
        {
            switch (position)
            {
                case 0: return  b[0];
                case 1: return  b[1];
                case 2: return  b[2];
                case 3: return  b[3];
                case 4: return  b[4];
                case 5: return  b[5];
                case 6: return  b[6];
                case 7: return  b[7];
                case 8: return  b[8];
                case 9: return  b[9];
                case 10: return b[10];
                case 11: return b[11];
                case 12: return b[12];
                case 13: return b[13];
                case 14: return b[14];
                case 15: return b[15];
                case 16: return b[16];
                case 17: return b[17];
                case 18: return b[18];
                case 19: return b[19];
                case 20: return b[20];
                case 21: return b[21];
                case 22: return b[22];
                case 23: return b[23];
                case 24: return b[24];
                default: return null;
            }
        }    
        private void start_game() //+
        {
            game.start();
            for (int j = 0; j < 100; j++)
                game.shift_random();
            refresh();
            Seconds = new DateTime();
            timer1.Enabled = true;
        }
        private void refresh()//+
        {
            for (int position = 0; position < StartMenu.choiseLevel * StartMenu.choiseLevel; position++)
            {
                int nr = game.get_number(position);
                button(position).Text = nr.ToString();
                mas[position] = nr;    
                if (button(position).Text == "0")
                {
                    button(position).BackColor = Color.White;
                    button(position).Text = "";
                }
                else                       
                    button(position).BackColor = Color.Lavender;                         
            }
        }
        private void menu_start_Click_1(object sender, EventArgs e)//+
        {
            TableLayoutPanel.Enabled = true;
            start_game();
            count = 0;
        }       
        private void выйтиВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec > 1)
            {
                pictureBox1.Invoke((Action)delegate { pictureBox1.Visible = false; });               
            }
            if (sec > 1)
            {
                Seconds = Seconds.AddSeconds(1);
                timerLabel.Text = Seconds.ToLongTimeString();
            }
        }
        private void FormGame_Resize(object sender, EventArgs e)
        {      
            Thread t = new Thread(new ThreadStart(GifLoad));
            t.IsBackground = true;
            t.Start();
        }
        private void TxtFor8()
        {
            try
            {
                StreamReader objReader = new StreamReader("BestResult8.TXT");
                string result = EnterName.name + " | " + count.ToString() + " | " + Seconds.ToLongTimeString();
                string sLine = ""; ArrayList arrText = new ArrayList();
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        arrText.Add(sLine);
                }
                objReader.Close();
                if (arrText.Count < 15)
                {
                    arrText.Add(result);
                    arrText.Sort();
                }
                else
                {
                    arrText.RemoveAt(arrText.Count);
                    arrText.Add(result);
                    arrText.Sort();
                }
                StreamWriter sw = new StreamWriter("BestResult8.TXT");
                    for (int i = 0; i < arrText.Count; i++)
                    {
                        sw.WriteLine(arrText[i]);
                    } sw.Close();                                  
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
        }
        private void TxtFor15()
        {
            try
            {
                StreamReader objReader = new StreamReader("BestResult15.TXT");
                string result = EnterName.name + " | " + count.ToString() + " | " + Seconds.ToLongTimeString();
                string sLine = ""; ArrayList arrText = new ArrayList();
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        arrText.Add(sLine);
                }
                objReader.Close();
                if (arrText.Count < 15)
                {
                    arrText.Add(result);
                    arrText.Sort();
                }
                else
                {
                    arrText.RemoveAt(arrText.Count);
                    arrText.Add(result);
                    arrText.Sort();
                }
                StreamWriter sw = new StreamWriter("BestResult15.TXT");
                for (int i = 0; i < arrText.Count; i++)
                {
                    sw.WriteLine(arrText[i]);
                } sw.Close();                
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
        }
        private void TxtFor24()
        {
            try
            {
                StreamReader objReader = new StreamReader("BestResult24.TXT");
                string result = EnterName.name + " | " + count.ToString() + " | " + Seconds.ToLongTimeString();
                string sLine = ""; ArrayList arrText = new ArrayList();
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        arrText.Add(sLine);
                }
                objReader.Close();
                if (arrText.Count < 15)
                {
                    arrText.Add(result);
                    arrText.Sort();
                }
                else
                {
                    arrText.RemoveAt(arrText.Count);
                    arrText.Add(result);
                    arrText.Sort();
                }
                StreamWriter sw = new StreamWriter("BestResult24.TXT");
                for (int i = 0; i < arrText.Count; i++)
                {
                    sw.WriteLine(arrText[i]);
                } sw.Close();               
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.Show();
        }
    }
}
