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

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private Label? labelPergunta;

        private Button? button01;

        private Button? button02;

        private Button? button03;

        private Button? button04;

        private Button? button05;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public Question()
        {

        }


        public Question(string questionM)
        {
            this.QuestionM = questionM; 
        }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        public Question(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC, int questionM)
        {
            labelPergunta = LabelQuestion;
            button01 = FirstButtonC;
            button02 = SecondButtonC;
            button03 = ThirdButtonC;
            button04 = FourthButtonC;
            button05 = FifthButtonC;
        }

        public void ConfigDrawn(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC)
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

        private Button QualBNT (int RespostaSelected)
        {
            if (RespostaSelected == 1 )
            return button01;
            else if (RespostaSelected == 2)
            return button02;
            else if (RespostaSelected == 3)
            return button03;
            else if (RespostaSelected == 4)
            return button04;
            else 
            return button05;
        }

        public bool VerifyResponse(int RespostaSelected)
        {
            if (RespostaSelected == CorrectResponse)
            {
                var Verify = QualBNT(RespostaSelected);
                    Verify.BackgroundColor = Colors.Green;
                return true;
            }
            else
            {
                var VCorrect = QualBNT(CorrectResponse);
                var VIncorrect = QualBNT(RespostaSelected);
                VCorrect.BackgroundColor = Colors.Yellow;
                VIncorrect.BackgroundColor = Colors.Red;
                return false;
                
            }
        }



    }



}