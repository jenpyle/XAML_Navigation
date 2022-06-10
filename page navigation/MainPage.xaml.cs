using System.Collections.Generic;
using System.Linq;
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
            if (Frame.BackStack.Count > 1)
            {
                Frame.GoBack();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Btn_HamburgerNav_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SplitView));
        }

        private List<string> Cats = new List<string>()
            {
                "Abyssinian",
                "Aegean",
                "American Bobtail"
            };

        // Handle text change and present suitable items
        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Since selecting an item will also change the text,
            // only listen to changes caused by user entering text.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                var suitableItems = new List<string>();
                var splitText = sender.Text.ToLower().Split(" ");
                foreach (var cat in Cats)
                {
                    var found = splitText.All((key) =>
                    {
                        return cat.ToLower().Contains(key);
                    });
                    if (found)
                    {
                        suitableItems.Add(cat);
                    }
                }
                if (suitableItems.Count == 0)
                {
                    suitableItems.Add("No results found");
                }
                sender.ItemsSource = suitableItems;
            }
        }
    }
}