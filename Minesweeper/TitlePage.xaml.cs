
namespace Minesweeper;

public partial class TitlePage : ContentPage
{
	public TitlePage()
	{
		InitializeComponent();
	}

	public void OnDiffucultyButtonClick(object sender, EventArgs e)
	{
		switch (Settings.Diffuculty)
		{
			case 0: 
				Settings.Diffuculty = 1;
				DiffucultyButton.Text = "Diffuculty: Normal";
				break;
			case 1:
                Settings.Diffuculty = 2;
                DiffucultyButton.Text = "Diffuculty: Medium";
                break;
            case 2:
                Settings.Diffuculty = 3;
                DiffucultyButton.Text = "Diffuculty: Hard";
                break;
            case 3:
                Settings.Diffuculty = 0;
                DiffucultyButton.Text = "Diffuculty: Easy";
                break;
        }
	}

	public void OnPlayButtonClick(object sender, EventArgs e)
	{
		Navigation.PushAsync(new GameplayFlyoutLayout());
	}
	
	public void OnHighscoresButtonClick(object sender, EventArgs e)
	{
		Navigation.PushAsync(new HighscoresPage());
	}
}