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

            this.button01!.BackgroundColor = Color.FromArgb("#773babd3");
            this.button01!.TextColor       = Colors.White;
            this.button02!.BackgroundColor = Color.FromArgb("#773babd3");
            this.button02!.TextColor       = Colors.White;
            this.button03!.BackgroundColor = Color.FromArgb("#773babd3");
            this.button03!.TextColor       = Colors.White;
            this.button04!.BackgroundColor = Color.FromArgb("#773babd3");
            this.button04!.TextColor       = Colors.White;
            this.button05!.BackgroundColor = Color.FromArgb("#773babd3");
            this.button05!.TextColor       = Colors.White;
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
            else if(RespostaSelected == 5)
            return button05;
            else 
            return null;
        }



        public bool VerifyResponse(int resposta)
        {
            if (CorrectResponse  == resposta)
            {
            DrawnCorrect(resposta);
            return true;
            }
            else
            {
            DrawnIncorrect(resposta);
            return false;
            }
        }

        private void DrawnCorrect(int resposta)
        {
            var button = QualBNT(resposta);
            DesenhaButtonCorreto(button!);
        }

        private void DrawnIncorrect(int resposta)
        {
            var buttonCorreto = QualBNT(CorrectResponse);
            var buttonResposta = QualBNT(resposta);
            DesenhaButtonIncorreto(buttonCorreto!, buttonResposta!);
        }


        private void DesenhaButtonCorreto(Button button)
        {
            button.BackgroundColor = Colors.Green;
            button.TextColor = Colors.White;
        }

        private void DesenhaButtonIncorreto(Button buttonCorreto, Button buttonResposta)
        {
            buttonCorreto.BackgroundColor = Colors.Yellow;
            buttonCorreto.TextColor       = Colors.Black;

            buttonResposta.BackgroundColor = Colors.Red;
            buttonResposta.TextColor       = Colors.Black;
        }
    }



}