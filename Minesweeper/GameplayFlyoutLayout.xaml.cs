using System.Diagnostics;

namespace Minesweeper;

public partial class GameplayFlyoutLayout : FlyoutPage
{
	private GameplayFlyoutMenu flyoutMenu;
	private GameplayMainPage detailsPage;

    public GameplayFlyoutLayout()
	{
		InitializeComponent();

        flyoutMenu = new GameplayFlyoutMenu();
        flyoutMenu.RestartButton.Clicked += RestartButtonClicked;
        flyoutMenu.MenuReturnButton.Clicked += MainMenuButtonClicked;
        flyoutMenu.BackButton.Clicked += BackButtonClicked;
		Flyout = flyoutMenu;

        detailsPage = new GameplayMainPage();
        detailsPage.MenuButton.Clicked += FlyoutMenuButtonClicked;
		Detail = detailsPage;

		IsPresented = false;
	}
    private void RestartButtonClicked(object sender, EventArgs e)
	{
        detailsPage = new GameplayMainPage();
        detailsPage.MenuButton.Clicked += FlyoutMenuButtonClicked;

		Detail = detailsPage;

		IsPresented = false;
	}

	private void FlyoutMenuButtonClicked(object sender, EventArgs e)
	{
		IsPresented = true;
    }

	private void MainMenuButtonClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

	public void BackButtonClicked(object sender, EventArgs e)
	{
		IsPresented = false;
    }
}