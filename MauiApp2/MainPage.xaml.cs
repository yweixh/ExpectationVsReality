namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void imageButton_Clicked(object sender, EventArgs e)
        {
            imageButton.Source = "second.jpg";
            imgBtn.Text = "Reality";
        }

        private void imageButton2_Clicked(object sender, EventArgs e)
        {
            imageButton2.Source = "two.jpeg";
            imgBtn2.Text = "Reality";
        }
    }
}