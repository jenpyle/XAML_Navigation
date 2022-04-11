using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace page_navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        private void BtnPage2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page3));
            //PageNav pageData = new PageNav(1, "Test", "lalala");
            //Frame.Navigate(typeof(MainPage), pageData);
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            pg2.Text = e.Parameter.ToString();
        }
    }
}
