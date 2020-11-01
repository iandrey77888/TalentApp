using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TalentClub.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TalentClub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView;

        public MainPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPageMasterMenuItem> MenuItems { get; set; }

            public MainPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPageMasterMenuItem>(new[]
                {
                    new MainPageMasterMenuItem { Id = 0, Title = "Лента", TargetType=typeof(NewsPage), Path="ListIcon.png" },
                    new MainPageMasterMenuItem { Id = 1, Title = "Личный кабинет", TargetType=typeof(ContentPage), Path="AccountIcon.png" },
                    new MainPageMasterMenuItem { Id = 2, Title = "Наставники", TargetType=typeof(ContentPage), Path="MentorIcon.png" },
                    new MainPageMasterMenuItem { Id = 3, Title = "Сообщения", TargetType=typeof(ContentPage), Path="MessageIcon.png" },
                    new MainPageMasterMenuItem { Id = 4, Title = "Образовательный маршрут", TargetType=typeof(ContentPage), Path="WayIcon.png" },
                    new MainPageMasterMenuItem { Id = 6, Title = "Профориентация", TargetType=typeof(ContentPage), Path="ProfIcon.png" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}