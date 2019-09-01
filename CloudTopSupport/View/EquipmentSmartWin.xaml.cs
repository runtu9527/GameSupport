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
using CloudTopSupport.ViewModel;
namespace CloudTopSupport.View
{
    /// <summary>
    /// EquipmentSmartWin.xaml 的交互逻辑
    /// </summary>
    public partial class EquipmentSmartWin : Window
    {
        public ViewModel.EquipmentViewModel VM = new ViewModel.EquipmentViewModel();
        public EquipmentSmartWin()
        {
            InitializeComponent();

            this.DataContext = VM;
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            Grid grid = sender as Grid;
            Point pt = Mouse.GetPosition(grid);
            VM.MouseX = (int)pt.X;
            VM.MouseY = (int)pt.Y;
        }
    }
}
