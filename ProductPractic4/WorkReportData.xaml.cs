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
    /// Логика взаимодействия для WorkReportData.xaml
    /// </summary>
    public partial class WorkReportData : Page
    {
        WorkReportTableAdapter workReportTableAdapter = new WorkReportTableAdapter();
        public WorkReportData()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
