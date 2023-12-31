namespace NaviShellPage;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
        this.Loaded += (_, _) =>
        {
            // バインドする
            this.BindingContext = (App.Current as App).MainViewModel;
        };
    }
    private void OnCountClicked(object sender, EventArgs e)
    {
        var vm = this.BindingContext as MainViewModel;
        vm.Count++;
    }
}
