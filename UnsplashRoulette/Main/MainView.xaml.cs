﻿using UnsplashRoulette.Framework;
using UnsplashRoulette.Photos;
using Windows.UI.Xaml;
using Windows.System.Profile;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UnsplashRoulette.Main
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : View
    {
        public MainView()
        {
            this.InitializeComponent();
            SetRootMargin();
            DataContext = DependencyInjector.Instance.CreateInstance<MainViewModel>(typeof(PhotoService));
        }

        private void SetRootMargin()
        {
            string deviceName = AnalyticsInfo.VersionInfo.DeviceFamily;
            bool isXbox = deviceName == "Windows.Xbox";

            // override the title-safe area if running on Xbox
            Margin = new Thickness(isXbox ? -5 : 0);
        }
    }
}
