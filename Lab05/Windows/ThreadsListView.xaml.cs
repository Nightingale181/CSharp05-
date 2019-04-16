using Lab05.Models;
using Lab05.ViewModel;
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
using System.Windows.Shapes;

namespace Lab05.Windows
{
    /// <summary>
    /// Interaction logic for ThreadsListView.xaml
    /// </summary>
    public partial class ThreadsListView : Window
    {
        public ThreadsListView(MyProcess process)
        {
            InitializeComponent();
            DataContext = new ThreadsListViewModel(process);
        }
    }
}
