using Modelos;

namespace showdomilhao;

public partial class MainPage : ContentPage
{
	public Gerenciador gerenciador;

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

//



}

