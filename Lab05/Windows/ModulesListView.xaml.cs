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
    /// Interaction logic for ModulesListView.xaml
    /// </summary>
    public partial class ModulesListView : Window
    {
        public ModulesListView(MyProcess process)
        {
            InitializeComponent();
            DataContext = new ModulesListViewModel(process);
        }
    }
}
