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

namespace pr9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exCLick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void infoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сделано Кульковой А. \r\nОписать, используя структуру, данные на учеников (фамилия, улица, дом, квартира).\r\n Вывести результат на экран.\r\n Вывести информацию, сколько учеников живет на заданной улице. ");
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(surtb.Text, out int value) != true & Int32.TryParse(sttb.Text, out value) != true & Int32.TryParse(hotb.Text, out value) == true & Int32.TryParse(aptb.Text, out value) == true)
            {
                string surname = surtb.Text, street = sttb.Text; int home = Convert.ToInt32(hotb.Text), apartment = Convert.ToInt32(aptb.Text);
                student st = new student(surname, street, home, apartment);
                string info = $"Ученик {st.Surname} живёт по адресу: г.Рязань, ул. {st.Street}, дом {st.Home}, квартира {st.Apartment}";
                lb1.Items.Add(info);
            }
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            lb1.Items.Clear();
            surtb.Text = "";
            sttb.Text = "";
            hotb.Text = "";
            aptb.Text = "";
        }

        private void FindClick(object sender, RoutedEventArgs e)
        {
            int count=0;
            for(int i = 0; i<lb1.Items.Count; i++)
            {
                if(Convert.ToString(lb1.Items[i]).Contains(sttb.Text) == true)
                {
                    count++;
                }
            }
            MessageBox.Show($"На данной улице проживают {count} учеников");
        }

        private void DelClick(object sender, RoutedEventArgs e)
        {
            lb1.Items.Remove(lb1.SelectedItem);
        }
    }
}
