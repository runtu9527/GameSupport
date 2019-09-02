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
}
