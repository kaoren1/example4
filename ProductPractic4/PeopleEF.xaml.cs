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
using ProductPractic4.PractisDataSetTableAdapters;

namespace ProductPractic4
{
    /// <summary>
    /// Логика взаимодействия для PeopleEF.xaml
    /// </summary>
    public partial class PeopleEF : Page
    {
        PractisEntities pr = new PractisEntities();
        public PeopleEF()
        {
            InitializeComponent();
            PeopleTable.ItemsSource = pr.People.ToList();
            Filtr.ItemsSource = pr.People.ToList();
            Filtr.DisplayMemberPath = "SurnamePeople";
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            PeopleTable.ItemsSource = pr.People.ToList().Where(item => item.SurnamePeople.Contains(SearchText.Text)).ToList();
        }

        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filtr.ItemsSource != null)
            {
                string selectedSurname = (Filtr.SelectedItem as People).SurnamePeople;
                PeopleTable.ItemsSource = pr.People.Where(item => item.SurnamePeople == selectedSurname).ToList();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            PeopleTable.ItemsSource = pr.People.ToList();
        }
    }
}
