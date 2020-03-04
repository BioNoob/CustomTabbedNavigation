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
    public partial class BlanckPage : ContentPage
    {
        public BlanckPage(ContentPage content)
        {
            this.Title = content.Title;
            this.Content = content.Content;
            this.BindingContext = content.BindingContext;
            this.Icon = content.Icon;
            content.Parent = this;
            InitializeComponent();
        }
    }
}