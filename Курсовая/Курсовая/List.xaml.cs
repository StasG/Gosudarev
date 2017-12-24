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
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Page
    {
        public List()
        {
            InitializeComponent();
            Logic Lo = new Logic();
            if (Lo.CreateLenta())
            {
                for (int i = 0; i < Amounts.AmountLenta(); i++)
                {
                    Label l1 = new Label();
                    l1.Width = 250;
                    l1.Height = 30;
                    l1.Foreground = Brushes.White;
                    Label l2 = new Label();
                    l2.Width = 100;
                    l2.Height = 30;
                    l2.Foreground = Brushes.White;
                    Button b = new Button();
                    b.Width = 90;
                    b.Height = 30;
                    b.Tag = i;
                    b.Click+= ButtonClick;
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    b.VerticalAlignment = VerticalAlignment.Center;
                    b.Content = "Добавить";
                    StackPanel sp = new StackPanel();
                    sp.Orientation = Orientation.Horizontal;
                    sp.Height = 60;
                    l1.Content = Lo.name(i);
                    l2.Content = Lo.LastPage(i);
                    sp.Children.Add(l1);
                    sp.Children.Add(l2);
                    sp.Children.Add(b);
                    LentaStack.Children.Add(sp);
                }
            }
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Logic Lo = new Logic();
            Lo.CreateLenta();
            Int32 i = (int)(sender as Button).Tag;
            Lo.AddToBase(Lo.name(i), Lo.LastPage(i).ToString());
        }
    }
}
