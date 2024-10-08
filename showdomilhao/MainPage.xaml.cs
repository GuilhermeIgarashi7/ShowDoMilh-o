using Modelos;

namespace showdomilhao;

public partial class MainPage : ContentPage
{
	public Gerenciador gerenciador;
	public int QntsClickeds = 0;

	public MainPage()
	{
		InitializeComponent();    

		gerenciador = new Gerenciador(labelPergunta, button01, button02, button03, button04, button05, labelPoints, labelLvl);
		gerenciador.NextQuestion();
	}

	private void button01ResponseClicked(object sender,EventArgs e)
	{
		gerenciador!.Verify(1);
	}

	private void button02ResponseClicked(object sender,EventArgs e)
	{
		gerenciador!.Verify(2);
	}

	private void button03ResponseClicked(object sender,EventArgs e)
	{
		gerenciador!.Verify(3);
	}

	private void button04ResponseClicked(object sender,EventArgs e)
	{
		gerenciador!.Verify(4);
	}

	private void button05ResponseClicked(object sender,EventArgs e)
	{
		gerenciador!.Verify(5);
	}

	void OnPularCLicked (object s, EventArgs e)
	{
		gerenciador.NextQuestion();
		QntsClickeds ++;

		if (QntsClickeds == 0)
		{
			BotaoPular.Text = "Pula: 3x";
		}
		if (QntsClickeds == 1)
		{
			BotaoPular.Text = "Pula: 2x";
		}
		if (QntsClickeds == 2)
		{
			BotaoPular.Text = "Pula: 1x";
		}

		if (QntsClickeds < 3)
		{
			return;
		}
		else
		{
			(s as Button).IsVisible = false;
		}


	}
    

//



}

