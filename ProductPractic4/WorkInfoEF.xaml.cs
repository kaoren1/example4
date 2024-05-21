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

namespace ProductPractic4
{
    /// <summary>
    /// Логика взаимодействия для WorkInfoEF.xaml
    /// </summary>
    public partial class WorkInfoEF : Page
    {
        PractisEntities pr = new PractisEntities();
        public WorkInfoEF()
        {
            InitializeComponent();
            WorkInfoTable.ItemsSource = pr.WorkInfo.ToList();
            Filtr.ItemsSource = pr.WorkInfo.ToList();
            Filtr.DisplayMemberPath = "WorkPost";
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoTable.ItemsSource = pr.WorkInfo.ToList().Where(item => item.WorkPost.Contains(SearchText.Text)).ToList();
        }

        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filtr.SelectedItem != null)
            {
                string selectedTitle = (Filtr.SelectedItem as WorkInfo).WorkPost;
                WorkInfoTable.ItemsSource = pr.WorkInfo.Where(item => item.WorkPost == selectedTitle).ToList();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoTable.ItemsSource = pr.WorkInfo.ToList();
        }
    }
}
