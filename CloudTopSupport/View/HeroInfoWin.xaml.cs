using CloudTopSupport.Entity;
using CloudTopSupport.ViewModel;
using GA.BaseHelper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CloudTopSupport.View
{
    /// <summary>
    /// HeroInfoWin.xaml 的交互逻辑
    /// </summary>
    public partial class HeroInfoWin : BaseWindow
    {
        public HeroInfoViewModel VM = new HeroInfoViewModel();
        public HeroInfoWin()
        {
            InitializeComponent();

            this.DataContext = VM;

            using (RetailContext context = new RetailContext())
            {
                VM.RaceList = new ObservableCollection<HeroRace>(context.HeroRace);
                VM.ProfessionList = new ObservableCollection<HeroProfession>(context.HeroProfession);
                VM.HeroList = new ObservableCollection<Hero>(context.Heros);
            }
        }
    }
}
