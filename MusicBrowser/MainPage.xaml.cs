using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MusicBrowserLogic;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace MusicBrowser
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();


            BackButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Home));
            TitleTextBox.Text = "Main";
            Home.IsSelected = true;
        }

        private void AlbumButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (!MyFrame.CanGoBack) return;
            MyFrame.GoBack();
            Home.IsSelected = true;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Home));
                TitleTextBox.Text = "Main";
            }
            else if (SecondPage.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Style));
                TitleTextBox.Text = "Style";
            }
            else if (Genre.IsSelected)
            {
                MyFrame.Navigate(typeof(Genre));
                TitleTextBox.Text = "Genre";
            }
            else if (Year.IsSelected)
            {
                MyFrame.Navigate(typeof(Year));
                TitleTextBox.Text = "Year";
            }
            else if (Country.IsSelected)
            {
                MyFrame.Navigate(typeof(Country));
                TitleTextBox.Text = "Country";
            }
            else if (Albums.IsSelected)
            {
                MyFrame.Navigate(typeof(Albums));
                TitleTextBox.Text = "All albums";
            }
        }

        private void ListBox_Hover(object sender, PointerRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void SearchTextBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            MyFrame.Navigate(typeof(Search), args.QueryText);
            TitleTextBox.Text = $"Showing results for: {args.QueryText}";
        }
    }
}
