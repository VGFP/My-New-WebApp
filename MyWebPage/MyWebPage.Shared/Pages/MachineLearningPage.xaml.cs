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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyWebPage.Shared.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MachineLearningPage : Page
    {
        
        public MachineLearningPage()
        {
            this.InitializeComponent();
            var frame = new Frame();
            frame.ContentTransitions = new TransitionCollection();
            frame.ContentTransitions.Add(new NavigationThemeTransition());
        }

        private void Go_to_UNO_Speech_recognition_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(XamarinAppsPage));
        }
    }
}
