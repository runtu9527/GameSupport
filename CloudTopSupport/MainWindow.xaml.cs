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
    public partial class MainWindow : BaseTransparencyWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Loaded -= MainWindow_Loaded;
        }

        private void EquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            var renzhe = HeroConfigHelper.Context.Heros.ToList().FindAll(p => p.RaceId.Contains($"{(int)RaceEnum.yuedeerren}"));

            var iconInfo = ((HeroEnum)renzhe.First().Id).GetAttribute<IconAttribute>();

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

        private void HeroInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            HeroInfoWin win = new HeroInfoWin();
            win.Show();
        }

        private void BattleArrayButton_Click(object sender, RoutedEventArgs e)
        {
            BattleArrayView win = new BattleArrayView();
            win.Show();
        }
    }
}
