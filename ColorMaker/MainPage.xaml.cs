namespace ColorMaker
{
    public partial class MainPage : ContentPage
    {
        bool _isRandom = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(_isRandom)
                return;
            var red = SliderRed.Value;
            var blue = SliderBlue.Value;
            var green = SliderGreen.Value;

            Color color = Color.FromRgb(red, blue, green);
            SetColor(color);
        }

        void SetColor(Color color)
        {
            Grid.BackgroundColor = color;
            RandomBtn.BackgroundColor = color;
            copyBtn.Text = color.ToHex();
        }

        private void RandomBtn_Clicked(object sender, EventArgs e)
        {
            _isRandom = true;
            var random = new Random();

            Color color = Color.FromRgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            SliderRed.Value = color.Red;
            SliderBlue.Value = color.Blue;
            SliderGreen.Value = color.Green;
            SetColor(color);
            _isRandom = false;
        }
    }

}
