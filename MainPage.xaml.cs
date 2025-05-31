namespace Maps
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Map map = new Map();
            getLocation();
            
        }
        public async void getLocation()
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
