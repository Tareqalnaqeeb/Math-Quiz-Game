using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game_Project
{
    public partial class frmGenarateGame : Form
    {
        public frmGenarateGame( )
        {
            InitializeComponent();

        }

         enum EnOperationType { Add = 1, Sub , Mult, Div, Mix };
        enum EnLevelType { Easy = 1, Med, Hard, Mix };


         struct StQuestion
        {
            public int Number1;
            public int Number2;
            public EnOperationType OperationType;
            public EnLevelType LevelType;
            public int PlyerAnswer;
            public int CorrectAnswer;
            public bool Reslut;
           


        }
         
       

          struct StQuizz
        {
            public StQuestion [] QuestionsList;
            public  int NumbersOfCorrectAnswer;
            public  int NumbersOfWrongANswer;
            public  EnOperationType OpType;
            public  EnLevelType LevelType;
            public  int NumbersOfQuestions;
            public  bool IsPass;
        }
         static StQuizz Quizz= new StQuizz( );

        int CounterTime = (int)Form1.NumberOfTimes;
        int QuestionNumbers = 0;

        Random rand = new Random();
        int RandomNumber(int From , int To)
        {
            return rand.Next(From, To+1);
        }

        EnOperationType GetRandomOeationType()
        {
            return (EnOperationType)RandomNumber(1, 4);
        }

        EnLevelType GetRandomLevelType()
        {
            return (EnLevelType)RandomNumber(1, 3);
        }
        
        int SampleCalclutor(int Num1 , int Num2 , EnOperationType OpType)
        {
            switch(OpType)
            {
                case EnOperationType.Add:
                    return Num1 + Num2;
                case EnOperationType.Sub:
                    return Num1 - Num2;
                case EnOperationType.Mult:
                    return Num1 * Num2;
                case EnOperationType.Div:
                    return Num1 / Num2;
                default:
                  return  Num1 + Num2;

            }
        }
      

        StQuestion GenerateQuestion(EnOperationType OpType , EnLevelType levelType )
        {
            StQuestion Question = new StQuestion();

            if(levelType == EnLevelType.Mix)
            {
                GetRandomLevelType();
            }
            if(OpType == EnOperationType.Mix)
            {
                GetRandomOeationType();
            }

            Question.OperationType = OpType;
            switch(levelType)
            {
                case EnLevelType.Easy:
                    Question.Number1 = RandomNumber(1, 10);
                    Question.Number2 = RandomNumber(1, 10);
                    //Question.OpType = OpType;
                    Question.LevelType = levelType;
                    Question.CorrectAnswer = SampleCalclutor(Question.Number1, Question.Number2, OpType);
                    return Question;

                case EnLevelType.Med:
                    Question.Number1 = RandomNumber(10, 40);
                    Question.Number2 = RandomNumber(10, 40);
                    //Question.OpType = OpType;
                    Question.LevelType = levelType;
                    Question.CorrectAnswer = SampleCalclutor(Question.Number1, Question.Number2, OpType);
                    return Question;

                case EnLevelType.Hard:
                    Question.Number1 = RandomNumber(40, 100);
                    Question.Number2 = RandomNumber(40, 100);
                   // Question.OpType = OpType;
                    Question.LevelType = levelType;
                    Question.CorrectAnswer = SampleCalclutor(Question.Number1, Question.Number2, OpType);
                    return Question;

                case EnLevelType.Mix:
                    Question.Number1 = RandomNumber(1, 100);
                    Question.Number2 = RandomNumber(1, 100);
                    //Question.OpType = OpType;
                    Question.LevelType = levelType;
                    Question.CorrectAnswer = SampleCalclutor(Question.Number1, Question.Number2, OpType);
                    return Question;



            }

            return Question;
        }


        void GenerateQuizz()
        {
            for(int i= 0; i < Quizz.NumbersOfQuestions; i++)
            {
                Quizz.QuestionsList[i] = GenerateQuestion(Quizz.OpType , Quizz.LevelType);
            }
        }


        string GetSampleOpType(EnOperationType OpType)
        {
            switch(OpType)
            {
                case EnOperationType.Add:
                    return "+";
                case EnOperationType.Sub:
                    return "-";
                case EnOperationType.Mult:
                    return "*";
                case EnOperationType.Div:
                    return "/";
                default:
                    return "Mix";
            }
        }



        void CorrectTheQuestionAnswer(int QuestionNUmber)
        {
           
            
                if(Quizz.QuestionsList[QuestionNUmber].CorrectAnswer != Quizz.QuestionsList[QuestionNUmber].PlyerAnswer)
                {
                    Quizz.QuestionsList[QuestionNUmber].Reslut = false;
                    Quizz.NumbersOfWrongANswer++;
                }else
                {
                    Quizz.QuestionsList[QuestionNUmber].Reslut = true;
                    Quizz.NumbersOfCorrectAnswer++;
                }
            
        }


        bool IsPass()
        {
            return Quizz.IsPass = Quizz.NumbersOfCorrectAnswer > Quizz.NumbersOfWrongANswer;
        }



        EnLevelType GetLevelType(string LevelType)
        {
            switch(LevelType)
            {
                case "Easy":
                    return EnLevelType.Easy;
                case "Med":
                    return EnLevelType.Med;
                case "Hard":
                    return EnLevelType.Med;
                case "Mix":
                    return EnLevelType.Mix;

                default:
                    return EnLevelType.Mix;

            }
        }

        EnOperationType GetEnOperationType(string OpType)
        {
            switch(OpType)
            {
                case "Add":
                    return EnOperationType.Add;
                case "Sub":
                    return EnOperationType.Sub;
                case "Mult":
                    return EnOperationType.Mult;
                case "Div":
                    return EnOperationType.Div;
                case "Mix":
                    return EnOperationType.Mix;
                default:
                    return EnOperationType.Mix;

            }
        }

        void SweapArry(int [] arr , int Num1 , int Num2)
        {

            int TempArr = arr[Num1];
            arr[Num1] = arr[Num2];
            arr[Num2] = TempArr ;

        }

        void RandomsAnswers()
        {
            int[] arr = new int[4];

            //
            int CAnswer = Quizz.QuestionsList[QuestionNumbers].CorrectAnswer;
           // int CAnswer = 1;
            arr[0] = CAnswer;
            arr[1] = RandomNumber(CAnswer + 1, CAnswer + 20);

           
                arr[2] = RandomNumber(CAnswer +1, CAnswer + 20);
                arr[3] = RandomNumber(CAnswer + 1, CAnswer + 20);
             

            for (int i = 0; i <= 3; i++)
            {
                SweapArry(arr, RandomNumber(0, 3), RandomNumber(0, 3));
            }

            button1.Text = arr[0].ToString();
            button2.Text = arr[1].ToString();
            button3.Text = arr[2].ToString();
            button4.Text = arr[3].ToString();

        
            
        }
       
        
       void DiasbleBottons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        void EnableBottons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CounterTime--;
            lbTimer.Text = CounterTime.ToString() + " s";

            if(CounterTime == 0)
            {
                DiasbleBottons();

                timer1.Stop();
                MessageBox.Show("Game Is Over", " Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void FinshedGame()
        {

            lbTimer.Text = " ";
            lbOperationsType.Text = " ";
            lbQuestionLevel.Text = " ";
            lbNumbersOfQuestion.Text = " ";
            lbNumberQuestion.Text = " ";

        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            if(QuestionNumbers +1 == Quizz.NumbersOfQuestions)
            {
                CounterTime = 0;
                timer1.Stop();

            }

            Quizz.QuestionsList[QuestionNumbers].PlyerAnswer = Convert.ToInt32(((Button)sender).Text);
            // Notice

            CorrectTheQuestionAnswer(QuestionNumbers);

            if(Quizz.QuestionsList[QuestionNumbers].Reslut)
            {
                lbCorrcetAnswer.Text = Quizz.NumbersOfCorrectAnswer.ToString();
                ((Button)sender).BackColor = Color.Green;

                MessageBox.Show("Corrct Answer", " Ture");
            }

            else
            {
                lbWrongAnswer.Text = Quizz.NumbersOfWrongANswer.ToString();
                ((Button)sender).BackColor = Color.Red;
                MessageBox.Show("Wrong Answer", " False ");
            }

            QuestionNumbers++;
            lbNumberQuestion.Text = QuestionNumbers.ToString();
            ((Button)sender).BackColor = Color.Teal;

            
            if (QuestionNumbers == Quizz.NumbersOfQuestions)
            {
                if (IsPass())
                {
                    MessageBox.Show("Winner", " Game Fansh", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Lose", " Game Over", MessageBoxButtons.OK);
                }

                timer1.Stop();
                DiasbleBottons();
                FinshedGame();
                MoveToResultForm();
                
                return;
            }
            
            lbQusitons.Text = Quizz.QuestionsList[QuestionNumbers].Number1.ToString() +
                " " + GetSampleOpType(Quizz.OpType) + Quizz.QuestionsList[QuestionNumbers].Number2.ToString();

            RandomsAnswers();

        }

        void MoveToResultForm()
        {
            Form frmResult = new frmResult();
            frmResult.Show();
        }
        private void frmGenarateGame_Load(object sender, EventArgs e)
        {
            btnEnd.Enabled = false;
            DiasbleBottons();

            Quizz.OpType = (EnOperationType)(Form1.OperationType+1);
            Quizz.LevelType = (EnLevelType)(Form1.LevelQuizz + 1);
            Quizz.NumbersOfQuestions = (int)Form1.NumbersOfQuestions;

            Quizz.QuestionsList = new StQuestion[Quizz.NumbersOfQuestions];
            lbTimer.Text = Form1.NumberOfTimes.ToString();
            lbOperationsType.Text = Quizz.OpType.ToString();
            lbQuestionLevel.Text = Quizz.LevelType.ToString();
            lbNumbersOfQuestion.Text = Quizz.NumbersOfQuestions.ToString();
            lbNumberQuestion.Text = QuestionNumbers.ToString();

            GenerateQuizz();

        }
         
        string Questins()
        {
            
            string Ques = "";
            Ques += Quizz.QuestionsList[QuestionNumbers].Number1.ToString();
            Ques += GetSampleOpType(Quizz.OpType);
            Ques += Quizz.QuestionsList[QuestionNumbers].Number2.ToString();

            return Ques;
        }
        private void btnStrart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GenerateQuizz();
            EnableBottons();
            btnStrart.Enabled = false;
            btnEnd.Enabled = true;



            
            lbQusitons.Text = Questins();
            RandomsAnswers();
        }


        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
            MoveToResultForm();
        }
    }
}
