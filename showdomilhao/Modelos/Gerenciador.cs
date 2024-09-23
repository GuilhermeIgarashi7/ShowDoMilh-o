namespace Modelos
{
    public class Gerenciador
    {
        private List<Question> QuestionList = new List<Question>();
        private HashSet<int> listQuestionRespondida = new HashSet<int>();
    
        private Question QuestaoCorrente;

        public int Point { get; private set; }

        private int CurrentlyLevel = 0;

        private void Inicializar()
        {
            Point = 0;
            CurrentlyLevel = 1;
            NextQuestion();
        }
        


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
    public Gerenciador(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC)
    {
        CreatePerguntas(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC,  FifthButtonC);  
    }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void NextQuestion()
    {
        var RandomNumber = Random.Shared.Next(0, QuestionList.Count);
        while (listQuestionRespondida.Contains (RandomNumber))
        RandomNumber = Random.Shared.Next(0, QuestionList.Count);

        listQuestionRespondida.Add(RandomNumber);
        QuestaoCorrente = QuestionList[RandomNumber];

        QuestaoCorrente.Drawn();
    }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public async void Verify(int resposta)
    {
        if (QuestaoCorrente!.VerifyResponse(resposta))
        {
        await Task.Delay(1500);
        AddPoints (CurrentlyLevel);
        CurrentlyLevel ++;
        NextQuestion();
        }
    }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    public void AddQuestion(Question questao)
    {
        QuestionList.Add(questao);
    }

    private void CreatePerguntas(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC)
    {
            var P1 = new Question();
            P1.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P1.QuestionM = "Qual dessas cidades é do Paraná?";
            P1.FirstResponse = "Rolândia";
            P1.SecondResponse = "Ampere";
            P1.ThirdResponse = "Anta Gorda";
            P1.FourthResponse = "Graxa";
            P1.FifthResponse = "Xique-Xique";
            P1.CorrectResponse = 1;  
            AddQuestion(P1);        
    }

    private void AddPoints(int Dificuldade)
    {
        if ( Dificuldade ==1)
        {
            Point = 1000;
        }
        else if (Dificuldade ==2)
        {
            Point = 2000;
        }
        else if (Dificuldade ==3)
        {
            Point = 4000;
        }
        else if (Dificuldade ==4)
        {
            Point = 8000;
        }
        else if (Dificuldade ==5)
        {
            Point = 16000;
        }
        else if (Dificuldade ==6)
        {
            Point = 32000;
        }
        else if (Dificuldade ==7)
        {
            Point = 64000;
        }
        else if (Dificuldade ==8)
        {
            Point = 128000;
        }
        else if (Dificuldade ==9)
        {
            Point = 256000;
        }
        else
        {
            Point = 512000;
        }
    }



    }

}