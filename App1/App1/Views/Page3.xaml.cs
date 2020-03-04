using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        SimpleVM sm;
        public Page3()
        {
            sm = new SimpleVM();
            sm.User = new User("ANTON");
            this.BindingContext = sm;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            var op = new InnerPage(this);
            this.Parent.BindingContext = op.BindingContext;
            ((ContentPage)this.Parent).Content = op.Content;

        }
    }
}