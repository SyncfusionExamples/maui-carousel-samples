namespace VirtualizationSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            Button button = new Button() 
            { 
                Text = "Tap to load 1000+ Items..", 
                HeightRequest = 200, 
                WidthRequest = 200, 
                CornerRadius = 100, 
                LineBreakMode = LineBreakMode.WordWrap 
            };

            button.Clicked += Button_Clicked;
            this.Content = button;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Content = carousel;
        }
    }

}
