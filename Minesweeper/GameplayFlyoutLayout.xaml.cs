namespace Minesweeper;

public partial class GameplayFlyoutLayout : FlyoutPage
{
	public GameplayFlyoutLayout()
	{
		InitializeComponent();
		FlyoutMenu.RestartButton.Clicked += RestartButtonClicked;
		FlyoutMenu.MenuReturnButton.Clicked += MenuButtonClicked;

		IsPresented = false;
    }

    private void RestartButtonClicked(object sender, EventArgs e)
	{
		Detail = new GameplayMainPage();
	}
	private void MenuButtonClicked(object sender, EventArgs e)
	{
		
	}
}