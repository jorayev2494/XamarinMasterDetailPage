using MyMasterDetailPage.Pages.MDP;
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
	public partial class FirstPage : ContentPage, IPolicePage
    {

        public int Id { get; set; }
        // public string Title { get; set; }
        public Type TargetType { get; set; }

        public FirstPage()
		{
            this.TargetType = typeof(FirstPage);

            BindingContext = this;
            // this.Title = Title;

            InitializeComponent();
		}



	}
}