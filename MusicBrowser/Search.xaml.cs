using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MusicBrowserLogic;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace MusicBrowser
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            AlbumsCollection coll = new AlbumsCollection();
            coll.AddAlbumsToCollection();

            string albumName = e.Parameter.ToString();

            var alb = coll.GetAlbumByName(albumName);

            someData.ItemsSource = alb;

            base.OnNavigatedTo(e);

        }
    }
}
