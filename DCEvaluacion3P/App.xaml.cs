using DCEvaluacion3P.Views;


namespace DCEvaluacion3P

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DCCatApiView());
        }
    }
}
