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
    public partial class InnerPage : ContentPage
    {
        private Page _root;
        public SimpleVM smm;
        public InnerPage(ContentPage root)
        {
            _root = root;
            smm = new SimpleVM();
            smm.User = new User("YAROL");
            BindingContext = smm;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _root.Parent.BindingContext = _root.BindingContext;
            ((ContentPage)_root.Parent).Content = ((ContentPage)_root).Content;
        }
    }
}