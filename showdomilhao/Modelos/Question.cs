namespace Modelos

{


    public class Question
    {
        public string QuestionM;

        public string FirstResponse;

        public string SecondResponse;

        public string ThirdResponse;

        public string FourthResponse;

        public string FifthResponse;

        public int QuestionLevel;

        public int CorrectResponse = 0;



        //----------------------------------------------------------------------------------------------

        private Label labelPergunta;

        private Button button01;

        private Button button02;

        private Button button03;

        private Button button04;

        private Button button05;

        public Question(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC)
        {
            labelPergunta = LabelQuestion;
            button01 = FirstButtonC;
            button02 = SecondButtonC;
            button03 = ThirdButtonC;
            button04 = FourthButtonC;
            button05 = FifthButtonC;
        }

        public void Drawn()
        {
            labelPergunta.Text = QuestionM;
            button01.Text = FirstResponse;
            button02.Text = SecondResponse;
            button03.Text = ThirdResponse;
            button04.Text = FourthResponse;
            button05.Text = FifthResponse;
        }

        private Button QualBnt(int CR)
        {
            if (CR == 1)
            {
                return button01;
            }
            else if (CR == 2)
            {
                return button02;
            }
        }

        public bool VerifyResponse(int CR)
        {
            if  (CR == CorrectResponse)
            {
                var Btn = QualBnt(CR);
                    Btn = BackgroundColor = Color.Green;
            }
            else
            {
                return  false;
            }
        }

    }






}