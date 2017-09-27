﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Final_excersise.ViewModels;

namespace Final_excersise.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        private MainViewModel VM => MainViewModel.SingleInstance;

        private void ArticlesListView_OnItemClick(object sender, ItemClickEventArgs e)
        {
            VM.ArticleClickCommand.Execute(e.ClickedItem);
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }
    }
}
