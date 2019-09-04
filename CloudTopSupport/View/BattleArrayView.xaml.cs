using CloudTopSupport.ViewModel;
using GA.BaseHelper;
using System;
using System.Collections.ObjectModel;
using System.Windows;
namespace CloudTopSupport.View
{
    /// <summary>
    /// BattleArrayView.xaml 的交互逻辑
    /// </summary>
    public partial class BattleArrayView : BaseTransparencyWindow
    {
        public BattleArrayViewModel VM = new BattleArrayViewModel();
        private int selectIndex = 0;
        public BattleArrayView()
        {
            InitializeComponent();

            this.DataContext = VM;

            Init();
        }

        private void Init()
        {
            VM.BattleImgList = new ObservableCollection<string>();
            string[] imgs = System.IO.Directory.GetFiles(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "BattleArray"));
            if (imgs.Length > 0)
            {
                foreach (var item in imgs)
                {
                    string imgName = System.IO.Path.GetFileName(item);
                    VM.BattleImgList.Add($"pack://siteoforigin:,,,/Image/BattleArray/{imgName}");
                }
            }
            VM.BattleImg = VM.BattleImgList[0];
        }

        private void NextImgBtn_Click(object sender, RoutedEventArgs e)
        {
            selectIndex++;
            if (selectIndex >= VM.BattleImgList.Count)
            {
                selectIndex = 0;
            }
            VM.BattleImg = VM.BattleImgList[selectIndex];
        }

        private void BackImgBtn_Click(object sender, RoutedEventArgs e)
        {
            selectIndex--;
            if (selectIndex < 0)
            {
                selectIndex = VM.BattleImgList.Count - 1;
            }
            VM.BattleImg = VM.BattleImgList[selectIndex];
        }
    }
}
