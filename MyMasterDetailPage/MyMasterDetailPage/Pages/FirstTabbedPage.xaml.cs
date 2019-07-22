using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMasterDetailPage.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstTabbedPage : TabbedPage, IPolicePage
    {
        public int Id { get; set; }
        public Type TargetType { get; set; }

        public FirstTabbedPage()
        {
            this.TargetType = typeof(FirstTabbedPage);
            BindingContext = this;

            InitializeComponent();
        }
    }
}