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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }
        public enum EnOperationType { Add = 1, Sub, Mult, Div, Mix };
        public enum EnLevelType { Easy = 1, Med, Hard, Mix };
        public struct StQuestion
        {
            public int Number1;
            public int Number2;
            public EnOperationType OperationType;
            public EnLevelType LevelType;
            public int PlyerAnswer;
            public int CorrectAnswer;
            public bool Reslut;



        }



        public struct StQuizz
        {
            public StQuestion[] QuestionsList;
            public  int NumbersOfCorrectAnswer;
            public  int NumbersOfWrongANswer;
            public  EnOperationType OpType;
            public  EnLevelType LevelType;
            public  int NumbersOfQuestions;
            public  bool IsPass;
        }
        static StQuizz Quizz = new StQuizz();

       

        private void frmResult_Load(object sender, EventArgs e)
        {
            Quizz.OpType = (EnOperationType)(Form1.OperationType + 1);
            Quizz.LevelType = (EnLevelType)(Form1.LevelQuizz + 1);
            Quizz.NumbersOfQuestions = (int)Form1.NumbersOfQuestions;
            

           
            lbResultTimer.Text = Form1.NumberOfTimes.ToString();
            lbResultOpType.Text = Quizz.OpType.ToString();
            lbResultQuizzLevel.Text = Quizz.LevelType.ToString();
            lbResultNumbersOfQuestions.Text = Quizz.NumbersOfQuestions.ToString();
            lbResultCorecctQues.Text = Quizz.NumbersOfCorrectAnswer.ToString();
            

            if(Quizz.IsPass)
            {
                lbResult.Text = " Winner :-)";
            }
            else
            {
                lbResult.Text = " Lose (-:";
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

           
            if (MessageBox.Show("Closing ", " Are You  Sure To Enclose this Game ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
                == DialogResult.Yes)

            {
                this.Close();
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("Restart Gamr ", " Are Sue To Restrat Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                Form frm = new Form1();
                frm.Show();
            }
        }

        
    }
}
