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
using CloudTopSupport.Entity;
using CloudTopSupport.View;
namespace CloudTopSupport
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void EquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            EquipmentWin win = new EquipmentWin();
            win.Owner = this;
            win.Show();
        }

        private void EquipmentSmartButton_Click(object sender, RoutedEventArgs e)
        {
            EquipmentSmartWin win = new EquipmentSmartWin();
            win.Owner = this;
            win.Show();
        }
    }
}
