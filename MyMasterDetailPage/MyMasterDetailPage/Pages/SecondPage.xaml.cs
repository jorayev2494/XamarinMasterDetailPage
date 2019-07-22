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
	public partial class SecondPage : ContentPage, IPolicePage
	{

        public int Id { get; set; }
        public Type TargetType { get; set; }

        public SecondPage()
        {
            this.TargetType = typeof(FirstPage);
            BindingContext = this;

            InitializeComponent();
        }
    }
}