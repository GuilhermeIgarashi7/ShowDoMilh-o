namespace Modelos
{
    public class Gerenciador
    {
        private List<Question> QuestionList = new List<Question>();
        private HashSet<int> listQuestionRespondida = new HashSet<int>();
    
        private Question QuestaoCorrente;

        public int Point { get; private set; }

        private int CurrentlyLevel = 0;

    

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
    public Gerenciador()
    {

    }
    public Gerenciador(Label LabelQuestion, Button FirstButtonC, Button SecondButtonC, Button ThirdButtonC, Button FourthButtonC, Button FifthButtonC)
    {
        CreatePerguntas(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC,  FifthButtonC);  
    }
    


       private void Inicializar()
        {
            Point = 0;
            CurrentlyLevel = 1;
            NextQuestion();
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

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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

            var P2 = new Question();
            P2.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P2.QuestionM = "Qual é o maior país em extensão territorial?";
            P2.FirstResponse = "Brasil";
            P2.SecondResponse = "Rússia";
            P2.ThirdResponse = "China";
            P2.FourthResponse = "Estados Unidos";
            P2.FifthResponse = "Canadá";
            P2.CorrectResponse = 2;
            AddQuestion(P2);

            var P3 = new Question();
            P3.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P3.QuestionM = "Qual planeta é conhecido como o 'Planeta Vermelho'?";
            P3.FirstResponse = "Júpiter";
            P3.SecondResponse = "Vênus";
            P3.ThirdResponse = "Saturno";
            P3.FourthResponse = "Marte";
            P3.FifthResponse = "Netuno";
            P3.CorrectResponse = 4;
            AddQuestion(P3);

            var P4 = new Question();
            P4.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P4.QuestionM = "Quem foi o autor do livro 'Dom Casmurro'?";
            P4.FirstResponse = "Graciliano Ramos";
            P4.SecondResponse = "Machado de Assis";
            P4.ThirdResponse = "Jorge Amado";
            P4.FourthResponse = "Clarice Lispector";
            P4.FifthResponse = "Carlos Drummond de Andrade";
            P4.CorrectResponse = 2;
            AddQuestion(P4);

            var P5 = new Question();
            P5.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P5.QuestionM = "Qual é a capital da França?";
            P5.FirstResponse = "Londres";
            P5.SecondResponse = "Madri";
            P5.ThirdResponse = "Berlim";
            P5.FourthResponse = "Paris";
            P5.FifthResponse = "Roma";
            P5.CorrectResponse = 4;
            AddQuestion(P5);

            var P6 = new Question();
            P6.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P6.QuestionM = "Quem pintou a 'Monalisa'?";
            P6.FirstResponse = "Michelangelo";
            P6.SecondResponse = "Pablo Picasso";
            P6.ThirdResponse = "Vincent van Gogh";
            P6.FourthResponse = "Leonardo da Vinci";
            P6.FifthResponse = "Claude Monet";
            P6.CorrectResponse = 4;
            AddQuestion(P6);

            var P7 = new Question();
            P7.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P7.QuestionM = "Qual é o rio mais longo do mundo?";
            P7.FirstResponse = "Amazonas";
            P7.SecondResponse = "Nilo";
            P7.ThirdResponse = "Yangtzé";
            P7.FourthResponse = "Mississipi";
            P7.FifthResponse = "Ganges";
            P7.CorrectResponse = 2;
            AddQuestion(P7);

            var P8 = new Question();
            P8.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P8.QuestionM = "Quem é o autor de 'O Pequeno Príncipe'?";
            P8.FirstResponse = "Antoine de Saint-Exupéry";
            P8.SecondResponse = "J.K. Rowling";
            P8.ThirdResponse = "Mark Twain";
            P8.FourthResponse = "Jane Austen";
            P8.FifthResponse = "Jules Verne";
            P8.CorrectResponse = 1;
            AddQuestion(P8);

            var P9 = new Question();
            P9.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P9.QuestionM = "Qual é o maior oceano do mundo?";
            P9.FirstResponse = "Atlântico";
            P9.SecondResponse = "Índico";
            P9.ThirdResponse = "Pacífico";
            P9.FourthResponse = "Ártico";
            P9.FifthResponse = "Antártico";
            P9.CorrectResponse = 3;
            AddQuestion(P9);

            var P10 = new Question();
            P10.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P10.QuestionM = "Quem escreveu 'Odisseia'?";
            P10.FirstResponse = "Homero";
            P10.SecondResponse = "Sófocles";
            P10.ThirdResponse = "Aristóteles";
            P10.FourthResponse = "Platão";
            P10.FifthResponse = "Eurípedes";
            P10.CorrectResponse = 1;
            AddQuestion(P10);    

            var P11 = new Question();
            P11.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P11.QuestionM = "Qual é a capital da Argentina?";
            P11.FirstResponse = "Buenos Aires";
            P11.SecondResponse = "Montevidéu";
            P11.ThirdResponse = "Assunção";
            P11.FourthResponse = "La Paz";
            P11.FifthResponse = "Lima";
            P11.CorrectResponse = 1;
            AddQuestion(P11);

            var P12 = new Question();
            P12.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P12.QuestionM = "Quem foi o primeiro presidente dos Estados Unidos?";
            P12.FirstResponse = "Abraham Lincoln";
            P12.SecondResponse = "George Washington";
            P12.ThirdResponse = "Thomas Jefferson";
            P12.FourthResponse = "John Adams";
            P12.FifthResponse = "Benjamin Franklin";
            P12.CorrectResponse = 2;
            AddQuestion(P12);

            var P13 = new Question();
            P13.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P13.QuestionM = "Qual é a fórmula química da água?";
            P13.FirstResponse = "CO2";
            P13.SecondResponse = "H2O";
            P13.ThirdResponse = "O2";
            P13.FourthResponse = "N2";
            P13.FifthResponse = "HCl";
            P13.CorrectResponse = 2;
            AddQuestion(P13);

            var P14 = new Question();
            P14.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P14.QuestionM = "Quem descobriu a gravidade ao ver uma maçã cair?";
            P14.FirstResponse = "Albert Einstein";
            P14.SecondResponse = "Galileu Galilei";
            P14.ThirdResponse = "Isaac Newton";
            P14.FourthResponse = "Nikola Tesla";
            P14.FifthResponse = "Charles Darwin";
            P14.CorrectResponse = 3;
            AddQuestion(P14);

            var P15 = new Question();
            P15.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P15.QuestionM = "Qual país é famoso pela Torre Eiffel?";
            P15.FirstResponse = "Espanha";
            P15.SecondResponse = "Itália";
            P15.ThirdResponse = "França";
            P15.FourthResponse = "Reino Unido";
            P15.FifthResponse = "Alemanha";
            P15.CorrectResponse = 3;
            AddQuestion(P15);

            var P16 = new Question();
            P16.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P16.QuestionM = "Qual é a capital da Itália?";
            P16.FirstResponse = "Roma";
            P16.SecondResponse = "Milão";
            P16.ThirdResponse = "Veneza";
            P16.FourthResponse = "Florença";
            P16.FifthResponse = "Nápoles";
            P16.CorrectResponse = 1;
            AddQuestion(P16);

            var P17 = new Question();
            P17.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P17.QuestionM = "Qual é o símbolo químico do ouro?";
            P17.FirstResponse = "Au";
            P17.SecondResponse = "Ag";
            P17.ThirdResponse = "Pt";
            P17.FourthResponse = "Pb";
            P17.FifthResponse = "Fe";
            P17.CorrectResponse = 1;
            AddQuestion(P17);

            var P18 = new Question();
            P18.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P18.QuestionM = "Quem pintou o teto da Capela Sistina?";
            P18.FirstResponse = "Michelangelo";
            P18.SecondResponse = "Leonardo da Vinci";
            P18.ThirdResponse = "Rafael";
            P18.FourthResponse = "Donatello";
            P18.FifthResponse = "Tintoretto";
            P18.CorrectResponse = 1;
            AddQuestion(P18);

            var P19 = new Question();
            P19.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P19.QuestionM = "Qual continente é conhecido como o 'continente branco'?";
            P19.FirstResponse = "Europa";
            P19.SecondResponse = "Antártida";
            P19.ThirdResponse = "África";
            P19.FourthResponse = "América do Norte";
            P19.FifthResponse = "Ásia";
            P19.CorrectResponse = 2;
            AddQuestion(P19);

            var P20 = new Question();
            P20.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P20.QuestionM = "Quem é o autor de 'Cem Anos de Solidão'?";
            P20.FirstResponse = "Gabriel García Márquez";
            P20.SecondResponse = "Mario Vargas Llosa";
            P20.ThirdResponse = "Jorge Luis Borges";
            P20.FourthResponse = "Pablo Neruda";
            P20.FifthResponse = "Isabel Allende";
            P20.CorrectResponse = 1;
            AddQuestion(P20);

            var P21 = new Question();
            P11.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P21.QuestionM = "Quem é o deus grego do submundo?";
            P21.FirstResponse = "Zeus";
            P21.SecondResponse = "Hades";
            P21.ThirdResponse = "Ares";
            P21.FourthResponse = "Poseidon";
            P21.FifthResponse = "Apolo";
            P21.CorrectResponse = 2;
            AddQuestion(P21);

            var P22 = new Question();
            P22.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P22.QuestionM = "Qual era o nome da deusa grega da sabedoria e guerra?";
            P22.FirstResponse = "Afrodite";
            P22.SecondResponse = "Ártemis";
            P22.ThirdResponse = "Atena";
            P22.FourthResponse = "Hera";
            P22.FifthResponse = "Héstia";
            P22.CorrectResponse = 3;
            AddQuestion(P22);

            var P23 = new Question();
            P23.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P23.QuestionM = "Quem era o rei dos deuses na mitologia romana?";
            P23.FirstResponse = "Netuno";
            P23.SecondResponse = "Júpiter";
            P23.ThirdResponse = "Plutão";
            P23.FourthResponse = "Marte";
            P23.FifthResponse = "Vulcano";
            P23.CorrectResponse = 2;
            AddQuestion(P23);

            var P24 = new Question();
            P24.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P24.QuestionM = "Quem é o deus nórdico do trovão?";
            P24.FirstResponse = "Loki";
            P24.SecondResponse = "Thor";
            P24.ThirdResponse = "Odin";
            P24.FourthResponse = "Tyr";
            P24.FifthResponse = "Balder";
            P24.CorrectResponse = 2;
            AddQuestion(P24);

            var P25 = new Question();
            P25.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P25.QuestionM = "Quem é a esposa de Zeus na mitologia grega?";
            P25.FirstResponse = "Afrodite";
            P25.SecondResponse = "Deméter";
            P25.ThirdResponse = "Hera";
            P25.FourthResponse = "Atena";
            P25.FifthResponse = "Ártemis";
            P25.CorrectResponse = 3;
            AddQuestion(P25);
    
            var P26 = new Question();
            P26.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P26.QuestionM = "Qual é o maior deserto do mundo?";
            P26.FirstResponse = "Sahara";
            P26.SecondResponse = "Saara";
            P26.ThirdResponse = "Gobi";
            P26.FourthResponse = "Antártica";
            P26.FifthResponse = "Atacama";
            P26.CorrectResponse = 4;
            AddQuestion(P26);

            var P27 = new Question();
            P27.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P27.QuestionM = "Qual é a fórmula do gás carbônico?";
            P27.FirstResponse = "CO";
            P27.SecondResponse = "CO2";
            P27.ThirdResponse = "H2O";
            P27.FourthResponse = "O2";
            P27.FifthResponse = "N2";
            P27.CorrectResponse = 2;
            AddQuestion(P27);

            var P28 = new Question();
            P28.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P28.QuestionM = "Quem foi o primeiro homem a viajar ao espaço?";
            P28.FirstResponse = "Yuri Gagarin";
            P28.SecondResponse = "Neil Armstrong";
            P28.ThirdResponse = "Buzz Aldrin";
            P28.FourthResponse = "John Glenn";
            P28.FifthResponse = "Alan Shepard";
            P28.CorrectResponse = 1;
            AddQuestion(P28);

            var P29 = new Question();
            P29.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P29.QuestionM = "Qual é o maior animal terrestre?";
            P29.FirstResponse = "Elefante";
            P29.SecondResponse = "Girafa";
            P29.ThirdResponse = "Baleia Azul";
            P29.FourthResponse = "Rinoceronte";
            P29.FifthResponse = "Hipopótamo";
            P29.CorrectResponse = 1;
            AddQuestion(P29);

            var P30 = new Question();
            P30.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P30.QuestionM = "Qual é o país mais populoso do mundo?";
            P30.FirstResponse = "Índia";
            P30.SecondResponse = "Estados Unidos";
            P30.ThirdResponse = "China";
            P30.FourthResponse = "Indonésia";
            P30.FifthResponse = "Paquistão";
            P30.CorrectResponse = 3;
            AddQuestion(P30);

            var P31 = new Question();
            P31.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P31.QuestionM = "Qual é o menor planeta do sistema solar?";
            P31.FirstResponse = "Mercúrio";
            P31.SecondResponse = "Marte";
            P31.ThirdResponse = "Vênus";
            P31.FourthResponse = "Plutão";
            P31.FifthResponse = "Saturno";
            P31.CorrectResponse = 1;
            AddQuestion(P31);

            var P32 = new Question();
            P32.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P32.QuestionM = "Qual é a moeda oficial do Japão?";
            P32.FirstResponse = "Yuan";
            P32.SecondResponse = "Won";
            P32.ThirdResponse = "Yen";
            P32.FourthResponse = "Dólar";
            P32.FifthResponse = "Rúpia";
            P32.CorrectResponse = 3;
            AddQuestion(P32);

            var P33 = new Question();
            P33.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P33.QuestionM = "Qual é o autor da obra '1984'?";
            P33.FirstResponse = "George Orwell";
            P33.SecondResponse = "Aldous Huxley";
            P33.ThirdResponse = "Ray Bradbury";
            P33.FourthResponse = "F. Scott Fitzgerald";
            P33.FifthResponse = "J.D. Salinger";
            P33.CorrectResponse = 1;
            AddQuestion(P33);

            var P34 = new Question();
            P34.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P34.QuestionM = "Qual é a cor da bandeira da Itália, de cima para baixo?";
            P34.FirstResponse = "Verde, Branco, Vermelho";
            P34.SecondResponse = "Vermelho, Branco, Verde";
            P34.ThirdResponse = "Branco, Verde, Vermelho";
            P34.FourthResponse = "Vermelho, Verde, Branco";
            P34.FifthResponse = "Branco, Vermelho, Verde";
            P34.CorrectResponse = 1;
            AddQuestion(P34);

            var P35 = new Question();
            P35.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P35.QuestionM = "Qual é a capital do Egito?";
            P35.FirstResponse = "Cairo";
            P35.SecondResponse = "Líbia";
            P35.ThirdResponse = "Tunis";
            P35.FourthResponse = "Meca";
            P35.FifthResponse = "Algiers";
            P35.CorrectResponse = 1;
            AddQuestion(P35);

            var P36 = new Question();
            P36.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P36.QuestionM = "Qual é o elemento químico que tem o símbolo 'Fe'?";
            P36.FirstResponse = "Ferro";
            P36.SecondResponse = "Flúor";
            P36.ThirdResponse = "Fósforo";
            P36.FourthResponse = "Cálcio";
            P36.FifthResponse = "Mercúrio";
            P36.CorrectResponse = 1;
            AddQuestion(P36);

            var P37 = new Question();
            P37.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P37.QuestionM = "Qual animal é conhecido como o 'rei da selva'?";
            P37.FirstResponse = "Elefante";
            P37.SecondResponse = "Leão";
            P37.ThirdResponse = "Tigre";
            P37.FourthResponse = "Urso";
            P37.FifthResponse = "Gorila";
            P37.CorrectResponse = 2;
            AddQuestion(P37);

            var P38 = new Question();
            P38.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P38.QuestionM = "Qual país é conhecido como a 'terra dos mil lagos'?";
            P38.FirstResponse = "Canadá";
            P38.SecondResponse = "Finlândia";
            P38.ThirdResponse = "Suécia";
            P38.FourthResponse = "Noruega";
            P38.FifthResponse = "Rússia";
            P38.CorrectResponse = 2;
            AddQuestion(P38);

            var P39 = new Question();
            P39.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P39.QuestionM = "Qual é a capital da Austrália?";
            P39.FirstResponse = "Sydney";
            P39.SecondResponse = "Canberra";
            P39.ThirdResponse = "Melbourne";
            P39.FourthResponse = "Brisbane";
            P39.FifthResponse = "Perth";
            P39.CorrectResponse = 2;
            AddQuestion(P39);

            var P40 = new Question();
            P40.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P40.QuestionM = "Qual é a capital da Rússia?";
            P40.FirstResponse = "São Petersburgo";
            P40.SecondResponse = "Moscou";
            P40.ThirdResponse = "Kazan";
            P40.FourthResponse = "Novosibirsk";
            P40.FifthResponse = "Yekaterinburgo";
            P40.CorrectResponse = 2;
            AddQuestion(P40);

            var P41 = new Question();
            P41.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P41.QuestionM = "Quem escreveu 'O Senhor dos Anéis'?";
            P41.FirstResponse = "George R.R. Martin";
            P41.SecondResponse = "J.R.R. Tolkien";
            P41.ThirdResponse = "C.S. Lewis";
            P41.FourthResponse = "J.K. Rowling";
            P41.FifthResponse = "Isaac Asimov";
            P41.CorrectResponse = 2;
            AddQuestion(P41);

            var P42 = new Question();
            P42.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P42.QuestionM = "Qual é o país conhecido pela arte do origami?";
            P42.FirstResponse = "China";
            P42.SecondResponse = "Japão";
            P42.ThirdResponse = "Coreia do Sul";
            P42.FourthResponse = "Tailândia";
            P42.FifthResponse = "Vietnã";
            P42.CorrectResponse = 2;
            AddQuestion(P42);

            var P43 = new Question();
            P43.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P43.QuestionM = "Qual é a montanha mais alta do mundo?";
            P43.FirstResponse = "K2";
            P43.SecondResponse = "Kangchenjunga";
            P43.ThirdResponse = "Mount Everest";
            P43.FourthResponse = "Makalu";
            P43.FifthResponse = "Lhotse";
            P43.CorrectResponse = 3;
            AddQuestion(P43);

            var P44 = new Question();
            P44.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P44.QuestionM = "Qual é a forma mais comum de energia no universo?";
            P44.FirstResponse = "Eletromagnética";
            P44.SecondResponse = "Química";
            P44.ThirdResponse = "Nuclear";
            P44.FourthResponse = "Gravitacional";
            P44.FifthResponse = "Cinetica";
            P44.CorrectResponse = 1;
            AddQuestion(P44);

            var P45 = new Question();
            P45.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P45.QuestionM = "Qual país é famoso pelo seu vinho e queijos?";
            P45.FirstResponse = "Espanha";
            P45.SecondResponse = "França";
            P45.ThirdResponse = "Itália";
            P45.FourthResponse = "Portugal";
            P45.FifthResponse = "Grécia";
            P45.CorrectResponse = 2;
            AddQuestion(P45);

            var P46 = new Question();
            P46.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P46.QuestionM = "Qual é o principal gás do efeito estufa?";
            P46.FirstResponse = "O2";
            P46.SecondResponse = "CO2";
            P46.ThirdResponse = "N2";
            P46.FourthResponse = "CH4";
            P46.FifthResponse = "H2O";
            P46.CorrectResponse = 2;
            AddQuestion(P46);

            var P47 = new Question();
            P47.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P47.QuestionM = "Quem foi a primeira mulher a ganhar um Prêmio Nobel?";
            P47.FirstResponse = "Marie Curie";
            P47.SecondResponse = "Rosalind Franklin";
            P47.ThirdResponse = "Ada Lovelace";
            P47.FourthResponse = "Jane Goodall";
            P47.FifthResponse = "Rachel Carson";
            P47.CorrectResponse = 1;
            AddQuestion(P47);

            var P48 = new Question();
            P48.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P48.QuestionM = "Qual é a capital da Islândia?";
            P48.FirstResponse = "Reykjavik";
            P48.SecondResponse = "Oslo";
            P48.ThirdResponse = "Estocolmo";
            P48.FourthResponse = "Copenhague";
            P48.FifthResponse = "Helsinque";
            P48.CorrectResponse = 1;
            AddQuestion(P48);

            var P49 = new Question();
            P49.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P49.QuestionM = "Qual é o planeta mais próximo do sol?";
            P49.FirstResponse = "Vênus";
            P49.SecondResponse = "Terra";
            P49.ThirdResponse = "Mercúrio";
            P49.FourthResponse = "Marte";
            P49.FifthResponse = "Saturno";
            P49.CorrectResponse = 3;
            AddQuestion(P49);

            var P50 = new Question();
            P50.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P50.QuestionM = "Qual é a língua mais falada no mundo?";
            P50.FirstResponse = "Espanhol";
            P50.SecondResponse = "Chinês Mandarim";
            P50.ThirdResponse = "Inglês";
            P50.FourthResponse = "Árabe";
            P50.FifthResponse = "Francês";
            P50.CorrectResponse = 2;
            AddQuestion(P50);

            var P51 = new Question();
            P51.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P51.QuestionM = "Qual é o país conhecido como 'Terra do Sol Nascente'?";
            P51.FirstResponse = "China";
            P51.SecondResponse = "Japão";
            P51.ThirdResponse = "Coreia do Sul";
            P51.FourthResponse = "Tailândia";
            P51.FifthResponse = "Vietnã";
            P51.CorrectResponse = 2;
            AddQuestion(P51);

            var P52 = new Question();
            P52.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P52.QuestionM = "Qual é o símbolo químico do hidrogênio?";
            P52.FirstResponse = "H";
            P52.SecondResponse = "He";
            P52.ThirdResponse = "O";
            P52.FourthResponse = "N";
            P52.FifthResponse = "C";
            P52.CorrectResponse = 1;
            AddQuestion(P52);

            var P53 = new Question();
            P53.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P53.QuestionM = "Qual é o primeiro elemento da tabela periódica?";
            P53.FirstResponse = "Hélio";
            P53.SecondResponse = "Hidrogênio";
            P53.ThirdResponse = "Lítio";
            P53.FourthResponse = "Berílio";
            P53.FifthResponse = "Carbono";
            P53.CorrectResponse = 2;
            AddQuestion(P53);

            var P54 = new Question();
            P54.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P54.QuestionM = "Qual é o oceano mais profundo do mundo?";
            P54.FirstResponse = "Oceano Índico";
            P54.SecondResponse = "Oceano Atlântico";
            P54.ThirdResponse = "Oceano Pacífico";
            P54.FourthResponse = "Oceano Ártico";
            P54.FifthResponse = "Oceano Antártico";
            P54.CorrectResponse = 3;
            AddQuestion(P54);

            var P55 = new Question();
            P55.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P55.QuestionM = "Qual artista é conhecido por suas obras surrealistas?";
            P55.FirstResponse = "Pablo Picasso";
            P55.SecondResponse = "Salvador Dalí";
            P55.ThirdResponse = "Vincent van Gogh";
            P55.FourthResponse = "Henri Matisse";
            P55.FifthResponse = "Claude Monet";
            P55.CorrectResponse = 2;
            AddQuestion(P55);

            var P56 = new Question();
            P56.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P56.QuestionM = "Qual é o maior continente do mundo?";
            P56.FirstResponse = "África";
            P56.SecondResponse = "América do Norte";
            P56.ThirdResponse = "Ásia";
            P56.FourthResponse = "Europa";
            P56.FifthResponse = "Oceania";
            P56.CorrectResponse = 3;
            AddQuestion(P56);

            var P57 = new Question();
            P57.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P57.QuestionM = "Qual planeta é conhecido como o 'Planeta Azul'?";
            P57.FirstResponse = "Terra";
            P57.SecondResponse = "Netuno";
            P57.ThirdResponse = "Urano";
            P57.FourthResponse = "Júpiter";
            P57.FifthResponse = "Vênus";
            P57.CorrectResponse = 1;
            AddQuestion(P57);

            var P58 = new Question();
            P58.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P58.QuestionM = "Qual é o animal terrestre mais rápido?";
            P58.FirstResponse = "Leão";
            P58.SecondResponse = "Guepardo";
            P58.ThirdResponse = "Antílope";
            P58.FourthResponse = "Cavalo";
            P58.FifthResponse = "Canguru";
            P58.CorrectResponse = 2;
            AddQuestion(P58);

            var P59 = new Question();
            P59.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P59.QuestionM = "Quem foi o primeiro homem a pisar na lua?";
            P59.FirstResponse = "Yuri Gagarin";
            P59.SecondResponse = "Buzz Aldrin";
            P59.ThirdResponse = "Neil Armstrong";
            P59.FourthResponse = "John Glenn";
            P59.FifthResponse = "Michael Collins";
            P59.CorrectResponse = 3;
            AddQuestion(P59);

            var P60 = new Question();
            P60.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P60.QuestionM = "Qual é a capital do Egito?";
            P60.FirstResponse = "Cairo";
            P60.SecondResponse = "Alexandria";
            P60.ThirdResponse = "Luxor";
            P60.FourthResponse = "Giza";
            P60.FifthResponse = "Aswan";
            P60.CorrectResponse = 1;
            AddQuestion(P60);

            var P61 = new Question();
            P61.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P61.QuestionM = "Qual é a capital da Grécia?";
            P61.FirstResponse = "Atenas";
            P61.SecondResponse = "Salônica";
            P61.ThirdResponse = "Heraclião";
            P61.FourthResponse = "Patras";
            P61.FifthResponse = "Tessalônica";
            P61.CorrectResponse = 1;
            AddQuestion(P61);

            var P62 = new Question();
            P62.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P62.QuestionM = "Qual é a moeda oficial do Japão?";
            P62.FirstResponse = "Yuan";
            P62.SecondResponse = "Won";
            P62.ThirdResponse = "Iene";
            P62.FourthResponse = "Dólar";
            P62.FifthResponse = "Rublo";
            P62.CorrectResponse = 3;
            AddQuestion(P62);

            var P63 = new Question();
            P63.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P63.QuestionM = "Qual é a capital da Nova Zelândia?";
            P63.FirstResponse = "Auckland";
            P63.SecondResponse = "Wellington";
            P63.ThirdResponse = "Christchurch";
            P63.FourthResponse = "Hamilton";
            P63.FifthResponse = "Dunedin";
            P63.CorrectResponse = 2;
            AddQuestion(P63);

            var P64 = new Question();
            P64.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P64.QuestionM = "Qual é o país mais populoso do mundo?";
            P64.FirstResponse = "Índia";
            P64.SecondResponse = "Estados Unidos";
            P64.ThirdResponse = "China";
            P64.FourthResponse = "Indonésia";
            P64.FifthResponse = "Paquistão";
            P64.CorrectResponse = 3;
            AddQuestion(P64);

            var P65 = new Question();
            P65.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P65.QuestionM = "Qual é a capital da Austrália?";
            P65.FirstResponse = "Sydney";
            P65.SecondResponse = "Canberra";
            P65.ThirdResponse = "Melbourne";
            P65.FourthResponse = "Brisbane";
            P65.FifthResponse = "Perth";
            P65.CorrectResponse = 2;
            AddQuestion(P65);

            var P66 = new Question();
            P66.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P66.QuestionM = "Qual é o maior mamífero do mundo?";
            P66.FirstResponse = "Elefante";
            P66.SecondResponse = "Baleia Azul";
            P66.ThirdResponse = "Tubarão";
            P66.FourthResponse = "Girafa";
            P66.FifthResponse = "Urso Polar";
            P66.CorrectResponse = 2;
            AddQuestion(P66);

            var P67 = new Question();
            P67.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P67.QuestionM = "Qual país é conhecido como a 'Terra dos Faraós'?";
            P67.FirstResponse = "Irã";
            P67.SecondResponse = "Egito";
            P67.ThirdResponse = "Iraque";
            P67.FourthResponse = "Síria";
            P67.FifthResponse = "Jordânia";
            P67.CorrectResponse = 2;
            AddQuestion(P67);

            var P68 = new Question();
            P68.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P68.QuestionM = "Qual é a forma mais comum de energia renovável?";
            P68.FirstResponse = "Energia eólica";
            P68.SecondResponse = "Energia solar";
            P68.ThirdResponse = "Energia hidrelétrica";
            P68.FourthResponse = "Biomassa";
            P68.FifthResponse = "Geotérmica";
            P68.CorrectResponse = 3;
            AddQuestion(P68);

            var P69 = new Question();
            P69.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P69.QuestionM = "Quem pintou 'A Noite Estrelada'?";
            P69.FirstResponse = "Pablo Picasso";
            P69.SecondResponse = "Vincent van Gogh";
            P69.ThirdResponse = "Claude Monet";
            P69.FourthResponse = "Henri Matisse";
            P69.FifthResponse = "Edvard Munch";
            P69.CorrectResponse = 2;
            AddQuestion(P69);

            var P70 = new Question();
            P70.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P70.QuestionM = "Qual é a primeira letra do alfabeto grego?";
            P70.FirstResponse = "Beta";
            P70.SecondResponse = "Alfa";
            P70.ThirdResponse = "Gama";
            P70.FourthResponse = "Delta";
            P70.FifthResponse = "Épsilon";
            P70.CorrectResponse = 2;
            AddQuestion(P70);

            var P71 = new Question();
            P71.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P71.QuestionM = "Qual é a principal linguagem de programação usada para desenvolvimento web?";
            P71.FirstResponse = "Python";
            P71.SecondResponse = "Java";
            P71.ThirdResponse = "JavaScript";
            P71.FourthResponse = "C#";
            P71.FifthResponse = "Ruby";
            P71.CorrectResponse = 3;
            AddQuestion(P71);

            var P72 = new Question();
            P72.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P72.QuestionM = "Qual é a capital da Espanha?";
            P72.FirstResponse = "Madrid";
            P72.SecondResponse = "Barcelona";
            P72.ThirdResponse = "Valência";
            P72.FourthResponse = "Sevilha";
            P72.FifthResponse = "Bilbao";
            P72.CorrectResponse = 1;
            AddQuestion(P72);

            var P73 = new Question();
            P73.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P73.QuestionM = "Qual é o elemento químico com o símbolo 'Fe'?";
            P73.FirstResponse = "Ferro";
            P73.SecondResponse = "Flúor";
            P73.ThirdResponse = "Fósforo";
            P73.FourthResponse = "Cálcio";
            P73.FifthResponse = "Mercúrio";
            P73.CorrectResponse = 1;
            AddQuestion(P73);

            var P74 = new Question();
            P74.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P74.QuestionM = "Qual é a capital da Rússia?";
            P74.FirstResponse = "São Petersburgo";
            P74.SecondResponse = "Moscou";
            P74.ThirdResponse = "Kazan";
            P74.FourthResponse = "Novosibirsk";
            P74.FifthResponse = "Vladivostok";
            P74.CorrectResponse = 2;
            AddQuestion(P74);

            var P75 = new Question();
            P75.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P75.QuestionM = "Qual é o maior deserto do mundo?";
            P75.FirstResponse = "Deserto do Saara";
            P75.SecondResponse = "Deserto da Antártida";
            P75.ThirdResponse = "Deserto de Gobi";
            P75.FourthResponse = "Deserto de Kalahari";
            P75.FifthResponse = "Deserto de Atacama";
            P75.CorrectResponse = 2;
            AddQuestion(P75);

            var P76 = new Question();
            P76.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P76.QuestionM = "Qual é a capital da Suécia?";
            P76.FirstResponse = "Estocolmo";
            P76.SecondResponse = "Copenhague";
            P76.ThirdResponse = "Oslo";
            P76.FourthResponse = "Helsinque";
            P76.FifthResponse = "Reiquiavique";
            P76.CorrectResponse = 1;
            AddQuestion(P76);

            var P77 = new Question();
            P77.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P77.QuestionM = "Qual é o símbolo químico do hidrogênio?";
            P77.FirstResponse = "H";
            P77.SecondResponse = "He";
            P77.ThirdResponse = "O";
            P77.FourthResponse = "N";
            P77.FifthResponse = "C";
            P77.CorrectResponse = 1;
            AddQuestion(P77);

            var P78 = new Question();
            P78.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P78.QuestionM = "Qual é a montanha mais alta do mundo?";
            P78.FirstResponse = "K2";
            P78.SecondResponse = "Kangchenjunga";
            P78.ThirdResponse = "Everest";
            P78.FourthResponse = "Lhotse";
            P78.FifthResponse = "Makalu";
            P78.CorrectResponse = 3;
            AddQuestion(P78);

            var P79 = new Question();
            P79.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P79.QuestionM = "Qual é o menor país do mundo?";
            P79.FirstResponse = "Mônaco";
            P79.SecondResponse = "Nauru";
            P79.ThirdResponse = "Vaticano";
            P79.FourthResponse = "San Marino";
            P79.FifthResponse = "Ilha Christmas";
            P79.CorrectResponse = 3;
            AddQuestion(P79);

            var P80 = new Question();
            P80.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P80.QuestionM = "Qual é a capital da Indonésia?";
            P80.FirstResponse = "Jacarta";
            P80.SecondResponse = "Bali";
            P80.ThirdResponse = "Surabaya";
            P80.FourthResponse = "Bandung";
            P80.FifthResponse = "Medan";
            P80.CorrectResponse = 1;
            AddQuestion(P80);

            var P81 = new Question();
            P81.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P81.QuestionM = "Qual é o maior órgão do corpo humano?";
            P81.FirstResponse = "Coração";
            P81.SecondResponse = "Fígado";
            P81.ThirdResponse = "Pele";
            P81.FourthResponse = "Pulmão";
            P81.FifthResponse = "Rim";
            P81.CorrectResponse = 3;
            AddQuestion(P81);

            var P82 = new Question();
            P82.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P82.QuestionM = "Qual é a moeda oficial da União Europeia?";
            P82.FirstResponse = "Dólar";
            P82.SecondResponse = "Euro";
            P82.ThirdResponse = "Libra";
            P82.FourthResponse = "Franco";
            P82.FifthResponse = "Coroa";
            P82.CorrectResponse = 2;
            AddQuestion(P82);

            var P83 = new Question();
            P83.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P83.QuestionM = "Qual é a temperatura em que a água ferve ao nível do mar?";
            P83.FirstResponse = "90°C";
            P83.SecondResponse = "100°C";
            P83.ThirdResponse = "110°C";
            P83.FourthResponse = "80°C";
            P83.FifthResponse = "120°C";
            P83.CorrectResponse = 2;
            AddQuestion(P83);

            var P84 = new Question();
            P84.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P84.QuestionM = "Quem foi o primeiro homem a pisar na Lua?";
            P84.FirstResponse = "Buzz Aldrin";
            P84.SecondResponse = "Neil Armstrong";
            P84.ThirdResponse = "Yuri Gagarin";
            P84.FourthResponse = "John Glenn";
            P84.FifthResponse = "Michael Collins";
            P84.CorrectResponse = 2;
            AddQuestion(P84);

            var P85 = new Question();
            P85.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P85.QuestionM = "Qual é a capital do Japão?";
            P85.FirstResponse = "Seul";
            P85.SecondResponse = "Tóquio";
            P85.ThirdResponse = "Pequim";
            P85.FourthResponse = "Bangcoc";
            P85.FifthResponse = "Hanoi";
            P85.CorrectResponse = 2;
            AddQuestion(P85);

            var P86 = new Question();
            P86.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P86.QuestionM = "Qual é a língua oficial do Brasil?";
            P86.FirstResponse = "Espanhol";
            P86.SecondResponse = "Inglês";
            P86.ThirdResponse = "Francês";
            P86.FourthResponse = "Português";
            P86.FifthResponse = "Italiano";
            P86.CorrectResponse = 4;
            AddQuestion(P86);

            var P87 = new Question();
            P87.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P87.QuestionM = "Qual é o elemento mais abundante no universo?";
            P87.FirstResponse = "Oxigênio";
            P87.SecondResponse = "Carbono";
            P87.ThirdResponse = "Hidrogênio";
            P87.FourthResponse = "Hélio";
            P87.FifthResponse = "Nitrogênio";
            P87.CorrectResponse = 3;
            AddQuestion(P87);

            var P88 = new Question();
            P88.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P88.QuestionM = "Qual é a fórmula química do gás carbônico?";
            P88.FirstResponse = "CO2";
            P88.SecondResponse = "O2";
            P88.ThirdResponse = "N2";
            P88.FourthResponse = "H2O";
            P88.FifthResponse = "CH4";
            P88.CorrectResponse = 1;
            AddQuestion(P88);

            var P89 = new Question();
            P89.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P89.QuestionM = "Qual é o maior continente do mundo?";
            P89.FirstResponse = "África";
            P89.SecondResponse = "América do Norte";
            P89.ThirdResponse = "Ásia";
            P89.FourthResponse = "Antártica";
            P89.FifthResponse = "Europa";
            P89.CorrectResponse = 3;
            AddQuestion(P89);

            var P90 = new Question();
            P90.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P90.QuestionM = "Qual é o sistema de governo da China?";
            P90.FirstResponse = "Monarquia";
            P90.SecondResponse = "República";
            P90.ThirdResponse = "Ditadura Comunista";
            P90.FourthResponse = "Democracia";
            P90.FifthResponse = "Teocracia";
            P90.CorrectResponse = 3;
            AddQuestion(P90);

            var P91 = new Question();
            P91.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P91.QuestionM = "Qual é a unidade de medida da força?";
            P91.FirstResponse = "Newton";
            P91.SecondResponse = "Joule";
            P91.ThirdResponse = "Pascal";
            P91.FourthResponse = "Watt";
            P91.FifthResponse = "Ampere";
            P91.CorrectResponse = 1;
            AddQuestion(P91);

            var P92 = new Question();
            P92.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P92.QuestionM = "Quem é o autor de '1984'?";
            P92.FirstResponse = "Aldous Huxley";
            P92.SecondResponse = "George Orwell";
            P92.ThirdResponse = "Ray Bradbury";
            P92.FourthResponse = "H.G. Wells";
            P92.FifthResponse = "Isaac Asimov";
            P92.CorrectResponse = 2;
            AddQuestion(P92);

            var P93 = new Question();
            P93.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P93.QuestionM = "Qual é a capital do Egito?";
            P93.FirstResponse = "Cairo";
            P93.SecondResponse = "Lagos";
            P93.ThirdResponse = "Nairobi";
            P93.FourthResponse = "Tunis";
            P93.FifthResponse = "Rabate";
            P93.CorrectResponse = 1;
            AddQuestion(P93);

            var P94 = new Question();
            P94.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P94.QuestionM = "Qual é a maior ilha do mundo?";
            P94.FirstResponse = "Grécia";
            P94.SecondResponse = "Groenlândia";
            P94.ThirdResponse = "Nova Guiné";
            P94.FourthResponse = "Borneu";
            P94.FifthResponse = "Madagascar";
            P94.CorrectResponse = 2;
            AddQuestion(P94);

            var P95 = new Question();
            P95.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P95.QuestionM = "Qual animal é conhecido como o 'rei da selva'?";
            P95.FirstResponse = "Tigre";
            P95.SecondResponse = "Leão";
            P95.ThirdResponse = "Elefante";
            P95.FourthResponse = "Urso";
            P95.FifthResponse = "Gorila";
            P95.CorrectResponse = 2;
            AddQuestion(P95);

            var P96 = new Question();
            P96.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P96.QuestionM = "Qual é o idioma mais falado no mundo?";
            P96.FirstResponse = "Inglês";
            P96.SecondResponse = "Chinês Mandarim";
            P96.ThirdResponse = "Espanhol";
            P96.FourthResponse = "Árabe";
            P96.FifthResponse = "Hindi";
            P96.CorrectResponse = 2;
            AddQuestion(P96);

            var P97 = new Question();
            P97.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P97.QuestionM = "Quem escreveu 'O Senhor dos Anéis'?";
            P97.FirstResponse = "C.S. Lewis";
            P97.SecondResponse = "J.K. Rowling";
            P97.ThirdResponse = "J.R.R. Tolkien";
            P97.FourthResponse = "George R.R. Martin";
            P97.FifthResponse = "Jules Verne";
            P97.CorrectResponse = 3;
            AddQuestion(P97);

            var P98 = new Question();
            P98.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P98.QuestionM = "Qual é o maior mamífero do planeta?";
            P98.FirstResponse = "Elefante";
            P98.SecondResponse = "Baleia Azul";
            P98.ThirdResponse = "Girafa";
            P98.FourthResponse = "Urso-polar";
            P98.FifthResponse = "Hipopótamo";
            P98.CorrectResponse = 2;
            AddQuestion(P98);

            var P99 = new Question();
            P99.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P99.QuestionM = "Qual é a fórmula da fotossíntese?";
            P99.FirstResponse = "CO2 + H2O → C6H12O6 + O2";
            P99.SecondResponse = "H2 + O2 → H2O";
            P99.ThirdResponse = "C6H12O6 + O2 → CO2 + H2O";
            P99.FourthResponse = "N2 + O2 → CO2";
            P99.FifthResponse = "C6H12O6 + H2O → CO2";
            P99.CorrectResponse = 1;
            AddQuestion(P99);

            var P100 = new Question();
            P100.ConfigDrawn(LabelQuestion, FirstButtonC, SecondButtonC, ThirdButtonC, FourthButtonC, FifthButtonC);
            P100.QuestionM = "Quem pintou 'A Última Ceia'?";
            P100.FirstResponse = "Rafael";
            P100.SecondResponse = "Leonardo da Vinci";
            P100.ThirdResponse = "Michelangelo";
            P100.FourthResponse = "Caravaggio";
            P100.FifthResponse = "Van Gogh";
            P100.CorrectResponse = 2;
            AddQuestion(P100);
    }





    }

}