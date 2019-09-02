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
using GA.BaseHelper;
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
            using(RetailContext ctx=new RetailContext())
            {
                var renzhe = ctx.Heros.ToList().FindAll(p => p.RaceId.Contains($"{(int)RaceEnum.yuedeerren}"));

                var iconInfo = ((HeroEnum)renzhe.First().Id).GetAttribute<IconAttribute>();

            }

            EquipmentWin win = new EquipmentWin();
            //win.Owner = this;
            win.Show();
        }

        private void EquipmentSmartButton_Click(object sender, RoutedEventArgs e)
        {
            EquipmentSmartWin win = new EquipmentSmartWin();
            //win.Owner = this;
            win.Show();
        }
    }
}
