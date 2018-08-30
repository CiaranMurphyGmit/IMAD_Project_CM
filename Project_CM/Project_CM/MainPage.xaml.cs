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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Project_CM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Button clong = CLongitudeInfo;
            Button zelement = ZElementInfo;
            Button sruler = SRulerInfo;
            Button aries = Aries;
            Button taurus = Taurus;
            Button gemini = Gemini;
            Button cancer = Cancer;
            Button leo = Leo;
            Button virgo = Virgo;
            Button libra = Libra;
            Button scorpio = Scorpio;
            Button sagittarius = Sagittarius;
            Button capricorn = Capricorn;
            Button aquarius = Aquarius;
            Button pisces = Pisces;
        }

        private void Button_Click_CLongitudeInfo(object sender, RoutedEventArgs e)
        {
            Info.Text = "In astronomy, a celestial coordinate\n system (or celestial reference system)\n is a system for specifying positions\n of celestial objects: satellites,\n planets, stars, galaxies, and so on.\n Coordinate systems can specify an\n object's position in three-dimensional\n space or plot merely its direction\n on a celestial sphere, if\n the object's distance is unknown or\n trivial.\n";
        }

        private void Button_Click_ZElementInfo(object sender, RoutedEventArgs e)
        {
            Info.Text = "In astrology, a triplicity is\n a group of three signs belonging to\n the same element.";
        }

        private void Button_Click_SRulerInfo(object sender, RoutedEventArgs e)
        {
            Info.Text = "In astrology, a planet's domicile (or\n less commonly house, not to\n be confused with the astrological\n house system) is the zodiac sign\n over which it has rulership. This is\n a separate concept from the houses of\n the horoscope. A planetary ruler is given\n to each sign, over which the planet\n is said to have a more powerful\n influence when positioned therein.\n A planet is considered to be in domal\n dignity when it is positioned in the\n sign it rules. This is the strongest\n of the five essential dignities\n of a planet.";
        }

        private void Button_Click_Aries(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Aries.png")); //Changes the image displayed at top of screen

            // Below is the code for changing the text displayed on screen
            PName.Text = "Aries";
            PMeaning.Text = "The Ram";
            PPosition.Text = "1st Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 0° to 30°";
            PDuration.Text = "Duration: March 20th - April 20th";
            PZElement.Text = "Zodiac Element: Fire";
            PZQuality.Text = "Zodiac Quality: Cardinal";
            PSRuler.Text = "Sign Ruler: Mars";
        }

        private void Button_Click_Taurus(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Taurus.png"));

            PName.Text = "Taurus";
            PMeaning.Text = "The Bull";
            PPosition.Text = "2nd Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 30° to 60°";
            PDuration.Text = "Duration: April 20th - May 21st";
            PZElement.Text = "Zodiac Element: Earth";
            PZQuality.Text = "Zodiac Quality: Fixed";
            PSRuler.Text = "Sign Ruler: Venus (ancient), Earth (modern)";
        }

        private void Button_Click_Gemini(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Gemini.png"));

            PName.Text = "Gemini";
            PMeaning.Text = "The Twins";
            PPosition.Text = "3rd Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 60° to 90°";
            PDuration.Text = "Duration: May 21st - June 21st";
            PZElement.Text = "Zodiac Element: Air";
            PZQuality.Text = "Zodiac Quality: Mutable";
            PSRuler.Text = "Sign Ruler: Mercury";
        }

        private void Button_Click_Cancer(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Cancer.png"));

            PName.Text = "Cancer";
            PMeaning.Text = "The Crab";
            PPosition.Text = "4th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 90° to 120°";
            PDuration.Text = "Duration: June 21st - July 22nd";
            PZElement.Text = "Zodiac Element: Water";
            PZQuality.Text = "Zodiac Quality: Cardinal";
            PSRuler.Text = "Sign Ruler: Moon";
        }

        private void Button_Click_Leo(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Leo.png"));

            PName.Text = "Leo";
            PMeaning.Text = "The Lion";
            PPosition.Text = "5th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 120° to 150°";
            PDuration.Text = "Duration: July 22nd - August 23rd";
            PZElement.Text = "Zodiac Element: Fire";
            PZQuality.Text = "Zodiac Quality: Fixed";
            PSRuler.Text = "Sign Ruler: Sun";
        }

        private void Button_Click_Virgo(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Virgo.png"));

            PName.Text = "Virgo";
            PMeaning.Text = "The Maiden";
            PPosition.Text = "6th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 150° to 180°";
            PDuration.Text = "Duration: August 23rd - September 23rd";
            PZElement.Text = "Zodiac Element: Earth";
            PZQuality.Text = "Zodiac Quality: Mutable";
            PSRuler.Text = "Sign Ruler: Mercury (ancient), Ceres (modern)";
        }

        private void Button_Click_Libra(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Libra.png"));

            PName.Text = "Libra";
            PMeaning.Text = "The Scales";
            PPosition.Text = "7th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 180° to 210°";
            PDuration.Text = "Duration: September 23rd - October 23rd";
            PZElement.Text = "Zodiac Element: Air";
            PZQuality.Text = "Zodiac Quality: Cardinal";
            PSRuler.Text = "Sign Ruler: Venus";
        }

        private void Button_Click_Scorpio(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Scorpio.png"));

            PName.Text = "Scorpio";
            PMeaning.Text = "The Scorpion";
            PPosition.Text = "8th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 210° to 240°";
            PDuration.Text = "Duration: October 23rd - November 22nd";
            PZElement.Text = "Zodiac Element: Water";
            PZQuality.Text = "Zodiac Quality: Fixed";
            PSRuler.Text = "Sign Ruler: Mars (ancient), Pluto (modern)";
        }

        private void Button_Click_Sagittarius(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Sagittarius.png"));

            PName.Text = "Sagittarius";
            PMeaning.Text = "The Archer";
            PPosition.Text = "9th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 240° to 270°";
            PDuration.Text = "Duration: November 22nd - December 21st";
            PZElement.Text = "Zodiac Element: Fire";
            PZQuality.Text = "Zodiac Quality: Mutable";
            PSRuler.Text = "Sign Ruler: Jupiter";
        }

        private void Button_Click_Capricorn(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Capricorn.png"));

            PName.Text = "Capricorn";
            PMeaning.Text = "The Mountain Sea-Goat";
            PPosition.Text = "10th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 270° to 300°";
            PDuration.Text = "Duration: December 21st - January 20th";
            PZElement.Text = "Zodiac Element: Earth";
            PZQuality.Text = "Zodiac Quality: Cardinal";
            PSRuler.Text = "Sign Ruler: Saturn";
        }

        private void Button_Click_Aquarius(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Aquarius.png"));

            PName.Text = "Aquarius";
            PMeaning.Text = "The Water-Bearer";
            PPosition.Text = "11th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 300° to 330°";
            PDuration.Text = "Duration: January 20th - February 18th";
            PZElement.Text = "Zodiac Element: Air";
            PZQuality.Text = "Zodiac Quality: Fixed";
            PSRuler.Text = "Sign Ruler: Saturn (ancient), Uranus (modern)";
        }

        private void Button_Click_Pisces(object sender, RoutedEventArgs e)
        {
            DisplaySign.Source = new BitmapImage(new Uri(base.BaseUri, "Assets/Pisces.png"));

            PName.Text = "Pisces";
            PMeaning.Text = "The Fish";
            PPosition.Text = "12th Astrological Sign in the Zodiac";
            PCLongitude.Text = "Celestial longitude: 330° to 360°";
            PDuration.Text = "Duration: February 18th - March 20th";
            PZElement.Text = "Zodiac Element: Water";
            PZQuality.Text = "Zodiac Quality: Mutable";
            PSRuler.Text = "Sign Ruler: Jupiter (ancient), Neptune (modern)";
        }
    }
}