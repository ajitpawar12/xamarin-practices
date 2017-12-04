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
using XFApp.Views;

namespace XFApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XAppMasterMaster : ContentPage
    {
        public ListView ListView;

        public XAppMasterMaster()
        {
            InitializeComponent();

            BindingContext = new XAppMasterMasterViewModel();
            ListView = MenuItemsListView;
        }

        class XAppMasterMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<XAppMasterMenuItem> MenuItems { get; set; }

            public XAppMasterMasterViewModel()
            {
                MenuItems = new ObservableCollection<XAppMasterMenuItem>(new[]
                {
                    new XAppMasterMenuItem { Id = 0, Title = "Add Employee",TargetType = typeof(AddEmployeePage)},
                    new XAppMasterMenuItem { Id = 1, Title = "Employee List",TargetType = typeof(EmployeeListPage)},
                    new XAppMasterMenuItem { Id = 2, Title = "List View Page",TargetType = typeof(ListViewPage)},
                    new XAppMasterMenuItem { Id = 3, Title = "Mvvm Demo" ,TargetType = typeof(MvvmDemoPage)},
                    new XAppMasterMenuItem { Id = 4, Title = "Page 5" },
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