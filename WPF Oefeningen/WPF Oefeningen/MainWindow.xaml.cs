using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_Oefeningen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
        class Winkelwagen
        {
            public string Name;
            public string Amount;
            public float Price;

            public Winkelwagen(string Name, string Amount, float Price)
            {
                this.Name = Name;
                this.Amount = Amount;
                this.Price = Price;

            }
        }
            public MainWindow()
        {
            InitializeComponent();
           
        }


        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menu.Margin = new Thickness(0, 0, 0, 0);
        }
        private void Shop_car_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Kassa.Margin = new Thickness(-75, 0, 0, 0);
        }
        private void Shop_car_back_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Kassa.Margin = new Thickness(286, 0, -358, 0);
        }
        private void Rect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var mouseWasDownOn = e.Source as FrameworkElement;
            string elementName = mouseWasDownOn.Name;
            if (elementName == "rect_Pop")
            {
                //dit was echt slecht
                cat_Placeholder1.Content = "Populair";
                item_1.Source = new BitmapImage(new Uri("Images/cola logo.png", UriKind.Relative));
                item_2.Source = new BitmapImage(new Uri("Images/fanta logo.png", UriKind.Relative));
                item_3.Source = new BitmapImage(new Uri("Images/M&M.png", UriKind.Relative));
                item_4.Source = new BitmapImage(new Uri("Images/Salty pops.png", UriKind.Relative));
                item_5.Source = new BitmapImage(new Uri("Images/Sweet pops.png", UriKind.Relative));
                item_6.Source = new BitmapImage(new Uri("Images/doritos lgo.png", UriKind.Relative));
                item_1.Name = "Cola";
                item_2.Name = "Fanta";
                item_3.Name = "M_M";
                item_4.Name = "Salty_popcorn";
                item_5.Name = "Sweet_popcorn";
                item_6.Name = "Doritos";



            }
            else if (elementName == "rect_Drinken")
            {
                cat_Placeholder1.Content = "Drinken";
                item_1.Source = new BitmapImage(new Uri("Images/cola logo.png", UriKind.Relative));
                item_2.Source = new BitmapImage(new Uri("Images/fanta logo.png", UriKind.Relative));
                item_3.Source = new BitmapImage(new Uri("Images/sprite logo 3.png", UriKind.Relative));
                item_4.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_5.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_6.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_1.Name = "Cola";
                item_2.Name = "Fanta";
                item_3.Name = "Sprite";
                //float item_1_price = 1,50;
            }
            else if (elementName == "rect_Snacks")
            {
                cat_Placeholder1.Content = "Snacks";
                item_1.Source = new BitmapImage(new Uri("Images/doritos lgo.png", UriKind.Relative));
                item_2.Source = new BitmapImage(new Uri("Images/lays naturel.png", UriKind.Relative));
                item_3.Source = new BitmapImage(new Uri("Images/paprika lays 2.png", UriKind.Relative));
                item_4.Source = new BitmapImage(new Uri("Images/Salty pops.png", UriKind.Relative));
                item_5.Source = new BitmapImage(new Uri("Images/Sweet pops.png", UriKind.Relative));
                item_6.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_1.Name = "Doritos";
                item_2.Name = "Lays_natural";
                item_3.Name = "Lays_paprika";
                item_4.Name = "Salty_popcorn";
                item_5.Name = "Sweet_popcorn";
            }
            else if(elementName == "rect_Snoep")
            {
                cat_Placeholder1.Content = "Snoep";
                item_1.Source = new BitmapImage(new Uri("Images/M&M.png", UriKind.Relative));
                item_2.Source = new BitmapImage(new Uri("Images/schepsnoep.png", UriKind.Relative));
                item_3.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_4.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_5.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_6.Source = new BitmapImage(new Uri("Images/", UriKind.Relative));
                item_1.Name = "M_M";
                item_2.Name = "Schepsnoep";
            }

        }
        private void Product_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var mouseWasDownOn = e.Source as FrameworkElement;
            string elementName = mouseWasDownOn.Name;
            List<Winkelwagen> inhoud = new List<Winkelwagen>();
            inhoud.Add(new Winkelwagen(elementName, "1", 1));
            inhoud.ForEach(Console.WriteLine);
            foreach (Object Winkelwagen in inhoud)
            {
                Console.WriteLine(inhoud);
            }
        }
        private void btn_back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menu.Margin = new Thickness(-260, 0, 260, 0);
        }
        private void inloggen_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(ip.Text);
            if (ip.Text == null || ip.Text == "" || ip.Text == "Ip adress")
            {
                MessageBox.Show("please enter an ip adress");
            }
            else
            {
                ip_menu.Margin = new Thickness(800, 0, -1500, 0);
            }
       }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}