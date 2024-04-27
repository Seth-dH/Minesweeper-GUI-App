namespace Minesweeper;

public partial class GameplayMainPage : ContentPage
{
	int count = 0;

	public GameplayMainPage()
	{
		InitializeComponent();
	}

    private void CounterButton_Clicked(object sender, EventArgs e)
    {
		count++;
		CounterButton.Text = $"Clicked: {count} times!";
    }
}