using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverMp3Example
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...

            Uri beepUri = new Uri("/OpenSilverMp3Example;component/Media/loaded.mp3", UriKind.Relative);
            BeeperLoaded.Source = beepUri;
        }

        void ButtonToPlayAudio_Click(object sender, RoutedEventArgs e)
        {
            BeeperLoaded.Play();
        }

        void ButtonToPauseAudio_Click(object sender, RoutedEventArgs e)
        {
            BeeperLoaded.Pause();
        }
    }
}
