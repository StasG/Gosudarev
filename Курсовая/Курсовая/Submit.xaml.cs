using BusinessLogic;
using Internet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Курсовая
{
    /// <summary>
    /// Логика взаимодействия для Submit.xaml
    /// </summary>
    public partial class Submit : Page
    {
        public Submit()
        {
            InitializeComponent();
            Logic Lo = new Logic();
            for (int i = 0; i < Lo.ReturnNum(); i++)
            {
                Label l1 = new Label();
                l1.Width = 200;
                l1.Height = 30;
                l1.Foreground = Brushes.White;
                l1.HorizontalAlignment = HorizontalAlignment.Center;
                l1.VerticalAlignment = VerticalAlignment.Center;
                Label l2 = new Label();
                l2.Width = 100;
                l2.Height = 30;
                l2.Foreground = Brushes.Yellow;
                if (Lo.Compare(i))
                {
                    l2.Visibility = Visibility.Visible;
                }
                else
                {
                    l2.Visibility = Visibility.Hidden;
                }
                l2.HorizontalAlignment = HorizontalAlignment.Center;
                l2.VerticalAlignment = VerticalAlignment.Center;
                Label l3 = new Label();
                l3.Width = 100;
                l3.Height = 30;
                l3.Foreground = Brushes.White;
                l3.HorizontalAlignment = HorizontalAlignment.Center;
                l3.VerticalAlignment = VerticalAlignment.Center;
                StackPanel sp = new StackPanel();
                sp.Orientation = Orientation.Horizontal;
                sp.Height = 60;
                l1.Content = Lo.ReadBasename(i);
                l2.Content = "Обновлено";
                l3.Content = Lo.ReadBasepage(i);
                sp.Children.Add(l1);
                sp.Children.Add(l2);
                sp.Children.Add(l3);
                PodpiskaStack.Children.Add(sp);
            }
        }
    }
}
