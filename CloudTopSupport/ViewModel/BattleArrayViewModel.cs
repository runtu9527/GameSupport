using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GA.BaseHelper;
namespace CloudTopSupport.ViewModel
{
    public class BattleArrayViewModel : BaseNotifyPropertyChanged
    {
        private string battleImg = "";
        public string BattleImg
        {
            get
            {
                return battleImg;
            }
            set
            {
                battleImg = value;
                NotifyOfPropertyChange(() => BattleImg);
            }
        }

        private ObservableCollection<string> battleImgList = new ObservableCollection<string>();
        public ObservableCollection<string> BattleImgList
        {
            get
            {
                return battleImgList;
            }
            set
            {
                battleImgList = value;
                NotifyOfPropertyChange(() => BattleImgList);
            }
        }
    }
}
