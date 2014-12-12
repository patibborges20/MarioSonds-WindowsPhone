using mario2.ExemploReview;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Globalization;

namespace mario2
{
 
    public partial class PivotPage1 : PhoneApplicationPage
    {
        SettingsManager SettingsManager;
        int TimesAppOpened;
        
        public PivotPage1()
        {
            InitializeComponent();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SettingsManager = new SettingsManager();

            TimesAppOpened= SettingsManager.GetValue("TimesAppOpened", 1);

            if (TimesAppOpened < 4)
            {
                SettingsManager.SetValue("TimesAppOpened", TimesAppOpened + 1);
            }
            else if (TimesAppOpened == 4)
            {
              
                 var result = MessageBox.Show("Gostou do Mario Sound's? Que tal avaliar ele na loja?","avaliação", MessageBoxButton.OKCancel);
               if (result == MessageBoxResult.OK)
                {
                    MarketplaceReviewTask review = new MarketplaceReviewTask();
                    review.Show();
                    SettingsManager.SetValue("TimesAppOpened", TimesAppOpened + 1);
                }
            }

        }
        int cli = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (cli)
            {
                case 0:
                    {
                        MUSICA.Source = (new Uri("Super Mario Sunshine.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cli = 1;
                        break;
                    }
                case 1:
                    {
                        MUSICA.Source = (new Uri("hahahou.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cli = 2;
                        break;
                    }
                case 2:
                    {
                        MUSICA.Source = (new Uri("sorte.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cli = 3;
                        break;

                    }
                case 3:
                    {
                        MUSICA.Source = (new Uri("mama.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cli = 4;
                        break;
                    }
                case 4:
                    {
                        MUSICA.Source = (new Uri("mario3.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cli = 5;
                        break;
                    }
                case 5:
                    {
                        MUSICA.Source = (new Uri("mario out.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cli = 0;
                        break;
                    }
            }
        }

        int cla = 0;
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            switch (cla)
            {
                case 0:
                    {
                        btnimgpeach.ImageSource = btnpea.ImageSource;
                        MUSICA.Source = (new Uri("1.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cla = 1;
                        break;
                    }
                case 1:
                    {
                       
                        MUSICA.Source = (new Uri("2.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cla = 2;
                        break;
                    }
                case 2:
                    {
                        MUSICA.Source = (new Uri("3.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cla = 3;
                        break;

                    }
                case 3:
                    {
                        MUSICA.Source = (new Uri("4-tu.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cla = 4;
                        break;
                    }
                case 4:
                    {
                        MUSICA.Source = (new Uri("5.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cla = 5;
                        break;
                    }
                case 5:
                    {
                        
                        btnimgpeach.ImageSource= btnvish.ImageSource;
                        MUSICA.Source = (new Uri("grita.mp3", UriKind.Relative));
                        MUSICA.Play();
                        cla = 0;
                        break;
                    }
            }
        }

        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}