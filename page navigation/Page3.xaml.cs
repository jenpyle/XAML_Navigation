using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace page_navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page3 : Page
    {
        public Page3()
        {
            this.InitializeComponent();
        }

        private void BtnPage3_Click(object sender, RoutedEventArgs e)
        {
           
            Frame.GoBack();
        }
        private void SourceBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.BackStack.RemoveAt(Frame.BackStackDepth - 1);
            Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string pages = "";
            foreach (PageStackEntry page in Frame.BackStack)
            {
                pages += "Hi" + page.SourcePageType.ToString() + "\n";
            }
            pg3.Text = pages;
        }
    }
}
