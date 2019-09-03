using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GA.BaseHelper;
using System.Collections.ObjectModel;
using CloudTopSupport.Entity;
namespace CloudTopSupport.ViewModel
{
    public class HeroInfoViewModel:BaseNotifyPropertyChanged
    {
        public HeroInfoViewModel()
        {
            FeeList = new ObservableCollection<FeeModel>();
            for (int i = 1; i <= 5; i++)
            {
                FeeModel fee = new FeeModel();
                fee.Fee = i.ToString();
                FeeList.Add(fee);
            }
        }
        private ObservableCollection<FeeModel> feeList = new ObservableCollection<FeeModel>();
        public ObservableCollection<FeeModel> FeeList
        {
            get
            {
                return feeList;
            }
            set
            {
                feeList = value;
                NotifyOfPropertyChange(() => FeeList);
            }
        }

        private ObservableCollection<HeroRace> raceList = new ObservableCollection<HeroRace>();
        public ObservableCollection<HeroRace> RaceList
        {
            get
            {
                return raceList;
            }
            set
            {
                raceList = value;
                NotifyOfPropertyChange(() => RaceList);
            }
        }

        private ObservableCollection<HeroProfession> professionList = new ObservableCollection<HeroProfession>();
        public ObservableCollection<HeroProfession> ProfessionList
        {
            get
            {
                return professionList;
            }
            set
            {
                professionList = value;
                NotifyOfPropertyChange(() => ProfessionList);
            }
        }

        private ObservableCollection<Hero> heroList = new ObservableCollection<Hero>();
        public ObservableCollection<Hero> HeroList
        {
            get
            {
                return heroList;
            }
            set
            {
                heroList = value;
                NotifyOfPropertyChange(() => HeroList);
            }
        }
    }

    public class FeeModel:BaseNotifyPropertyChanged
    {
        public string Fee { get; set; } = "1";
    }
}
