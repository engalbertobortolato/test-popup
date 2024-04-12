namespace testMaui.Pages.Shared;

using System.Diagnostics;
using CommunityToolkit.Maui.Views;

public partial class PopUp : Popup
{
    public PopUpViewModel SetupPasswordPopupViewModel { get; set; }
    private bool focus = false;
    Process entry_password_process = null;
	public PopUp()
	{
        SetupPasswordPopupViewModel = new PopUpViewModel();

        BindingContext = SetupPasswordPopupViewModel;
		InitializeComponent();
	}

    public void btn_Yes_Clicked(object sender, EventArgs e)
    {
           
        try
        {
            Console.WriteLine("Password: " + SetupPasswordPopupViewModel.password);
            Close(1);
        }
        catch (Exception)
        {
            // ignored
        }
    }

    public void btn_No_Clicked(object sender, EventArgs e)
    {
        try
        {
            Console.WriteLine("NO Password");
            Close(0);
        }
        catch (Exception)
        {
            // ignored
        }
    }
}