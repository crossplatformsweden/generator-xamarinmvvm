using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InvalidNameSpace
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }
    }
}