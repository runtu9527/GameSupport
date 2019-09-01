
using GA.BaseHelper;

namespace CloudTopSupport.ViewModel
{
    public class EquipmentViewModel : BaseNotifyPropertyChanged
    {
        private int mouseX;
        public int MouseX
        {
            get
            {
                return mouseX;
            }
            set
            {
                mouseX = value;
                NotifyOfPropertyChange(() => MouseX);
            }
        }

        private int mouseY;
        public int MouseY
        {
            get
            {
                return mouseY;
            }
            set
            {
                mouseY = value;
                NotifyOfPropertyChange(() => MouseY);
            }
        }
    }
}
