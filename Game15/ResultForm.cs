using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace Game15
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        private void ResultForm_Load(object sender, EventArgs e)
        {
            TextResult.Text = "Имя | Кол-во ходов | Время \n\n";
            string sLine = ""; ArrayList arrText = new ArrayList();
            StreamReader objReader;
            if (StartMenu.choiseLevel == 3) objReader = new StreamReader("BestResult8.TXT");                                                            
            else if (StartMenu.choiseLevel == 4)  objReader = new StreamReader("BestResult15.TXT");                                                                
            else objReader = new StreamReader("BestResult24.TXT");                                                             
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();
            for (int i = 0; i < arrText.Count; i++)           
                TextResult.Text += arrText[i] + "\n";           
        }      
    }
}
