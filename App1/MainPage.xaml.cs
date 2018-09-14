using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            txtBoxRas.Text = "Rasmussen College";
            BL_PageContent.CreatedBy = "Created By: Anzarul Haque";
            txtBoxFooterMain.Text = BL_PageContent.CreatedBy;

        }

        async private void btnCourse1_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course1();
            txtBoxCourse.Text = BL_PageContent.VarOutput;
            var dialog = new MessageDialog(BL_PageContent.VarOutput);
            await dialog.ShowAsync();

        }

        private void hypLnkPage2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Faculty));
        }

    }
}
