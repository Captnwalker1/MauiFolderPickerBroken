using CommunityToolkit.Maui.Storage;

namespace MauiFolderPickerBroken
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
#if WINDOWS
            var result = await FolderPicker.Default.PickAsync(CancellationToken.None);
            if (result.IsSuccessful)
            {
                PathLabel.Text = "Folder Path: " + result.Folder.Path;
            }
            else
            {
                PathLabel.Text = "Folder Path: Error: "+result.Exception.Message;
            }
            SemanticScreenReader.Announce(CounterBtn.Text);
#endif
        }
    }

}
