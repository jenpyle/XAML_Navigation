using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace page_navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BtnPage1_Click(object sender, RoutedEventArgs e)
        {
            //it just needs the type of page2
            //Frame.Navigate(typeof(Page2), "Coming from page 1");

            //create and instance of this class
            PageNav pageData = new PageNav(1, "Test", "lalala");
            Frame.Navigate(typeof(Page2), pageData.Description);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {





        }
    }
}
