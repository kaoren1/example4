using ProductPractic4.PractisDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для WorkInfoData.xaml
    /// </summary>
    public partial class WorkInfoData : Page
    {
        WorkInfoTableAdapter WorkInfoTableAdapter = new WorkInfoTableAdapter();
        public WorkInfoData()
        {
            InitializeComponent();
            WorkInfoTable.ItemsSource = WorkInfoTableAdapter.GetData();
            Filtr.ItemsSource = WorkInfoTableAdapter.GetData();
            Filtr.DisplayMemberPath = "WorkPost";
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoTable.ItemsSource = WorkInfoTableAdapter.SearchByWorkPost(SearchText.Text);
        }

        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filtr.ItemsSource != null)
            {
                var id = (int)(Filtr.SelectedItem as DataRowView).Row[0];
                WorkInfoTable.ItemsSource = WorkInfoTableAdapter.FindByID(id);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoTable.ItemsSource = WorkInfoTableAdapter.GetData();
        }
    }
}
