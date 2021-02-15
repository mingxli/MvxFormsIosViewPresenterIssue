using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvxFormsIosViewPresenterIssue
{
    public partial class FormsApp : Application
    {
        public FormsApp()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
