namespace weterynarz
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSlideW(object? sender, EventArgs e)
        {
            if (slider_wiek == null)
            {
                return;
            }
            double sliderD = slider_wiek.Value;
            int slider = (int)Math.Round(sliderD);
        ile_lat.Text = Convert.ToString(slider);
        }

}
}
