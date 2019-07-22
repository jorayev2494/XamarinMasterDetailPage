using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMasterDetailPage.Pages.MDP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }
    }

    class MyMasterDetailPageMasterViewModel : INotifyPropertyChanged
    {
        // public ObservableCollection<MyMasterDetailPageMenuItem> MenuItems { get; set; }

        public List<Page> MenuItems { get; set; }
            
        public MyMasterDetailPageMasterViewModel()
        {
            //MenuItems = new ObservableCollection<MyMasterDetailPageMenuItem>(new[]
            //{
            //    new MyMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
            //    new MyMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
            //    new MyMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
            //    new MyMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
            //    new MyMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
            //});

            MenuItems = new List<Page>();
            MenuItems.Add(new FirstPage() { Id = 5, Title = "FirstPage" });
            MenuItems.Add(new SecondPage() { Id = 6, Title = "LastPage" });
            MenuItems.Add(new FirstTabbedPage() { Id = 7, Title = "First Tabbed Page" });

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