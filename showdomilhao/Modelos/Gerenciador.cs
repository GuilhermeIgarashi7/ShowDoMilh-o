namespace Modelos
{
    public class Gerenciador
    {
        private List<Question> QuestionList = new List<Question>();
        private HashSet<int> listQuestionRespondida = new HashSet<int>();
    
        private Question QuestaoCorrente;


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
            P1.ThirdResponse = "Nicedick";
            P1.FourthResponse = "Graxa";
            P1.FifthResponse = "Xique-Xique";
            P1.CorrectResponse = 3;  
            AddQuestion(P1);        
    }



    }

}