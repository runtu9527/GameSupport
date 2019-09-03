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
    public partial class HeroInfoWin : BaseTransparencyWindow
    {
        public HeroInfoViewModel VM = new HeroInfoViewModel();
        private HeroRace selectedRace = null;
        private HeroProfession selectedProfession = null;
        private FeeModel selectedFee = null;
      
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

     
        private void RaceImgRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null) return;
            HeroRace race = rb?.DataContext as HeroRace;
            if (race == null) return;
            if ((bool)rb.IsChecked)
            {
                if (selectedRace == race)
                {
                    rb.IsChecked = false;
                    selectedRace = null;
                }
                else
                {
                    selectedRace = race;
                }
            }
            RefrechHeros();
        }

        private void ProfessionImgRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null) return;
            HeroProfession profession = rb?.DataContext as HeroProfession;
            if (profession == null) return;
            if ((bool)rb.IsChecked)
            {
                if (selectedProfession == profession)
                {
                    rb.IsChecked = false;
                    selectedProfession = null;
                }
                else
                {
                    selectedProfession = profession;
                }
            }
            RefrechHeros();
        }

        private void FeeImgRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null) return;
            FeeModel fee = rb?.DataContext as FeeModel;
            if (fee == null) return;
            if ((bool)rb.IsChecked)
            {
                if (selectedFee == fee)
                {
                    rb.IsChecked = false;
                    selectedFee = null;
                }
                else
                {
                    selectedFee = fee;
                }
            }
            RefrechHeros();
        }

        public void RefrechHeros()
        {
            using (RetailContext context = new RetailContext())
            {
                var list = context.Heros.ToList();
                if (selectedRace != null)
                {
                    list = list.FindAll(p => p.RaceId.Split(',').Contains(selectedRace.Id.ToString()));
                }
                if (selectedProfession != null)
                {
                    list = list.FindAll(p => p.ProfessionId.Split(',').Contains(selectedProfession.Id.ToString()));
                }
                if (selectedFee != null)
                {
                    list = list.FindAll(p => p.Fee==int.Parse(selectedFee.Fee));
                }
                VM.HeroList = new ObservableCollection<Hero>(list);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
