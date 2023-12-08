using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public static decimal NumbersOfQuestions=1;
        public static decimal NumberOfTimes = 1;
        public static int OperationType=1;
        public static int  LevelQuizz = 1;
            

       
        private void button1_Click(object sender, EventArgs e)
        {
            NumbersOfQuestions = numericNumOfQuis.Value;
            NumberOfTimes = numNumberOfTimes.Value;

            OperationType = coOeprationType.SelectedIndex;
            LevelQuizz = coQuizzType.SelectedIndex;
            
            
            Form frm = new frmGenarateGame();
            frm.Show();
            
            
            
        }

       
    }
}
