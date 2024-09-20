namespace Modelos
{
    public class Gerenciador
    {
        private List<Question> QuestionList = new List<Question>();
        private HashSet<int> QuestionRespondida = new HashSet<int>();
    }
        private Question QuestaoCorrente;
    public Gerenciador(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC)
    {
        CreatePerguntas(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC,  FifthButtonC);  
    }
    private void CreatePerguntas(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC)
    {
            var P1 = new Question();
            P1.ConfigDrawn(lp, BT01, BT02, BT03, BT04, BT05);
            P1.LabelQuestion = "Qual é a capital da Argentina?";
            P1.FirstButtonC = "Brasil";
            P1.SecondButtonC = "Caracas";
            P1.ThirdButtonC = "Buenos Aires";
            P1.FourthButtonC = "Mendoza";
            P1.FifthButtonC = "Xique-Xique";
            P1.CorrectResponse = 3;  
            QuestionList.Add(P1);        
    }


}