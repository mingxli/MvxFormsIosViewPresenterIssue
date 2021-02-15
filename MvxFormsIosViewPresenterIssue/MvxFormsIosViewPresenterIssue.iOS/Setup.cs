using System;
using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.Forms.Platforms.Ios.Presenters;
using MvvmCross.Logging;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.Platforms.Ios.Presenters;
using MvxFormsIosViewPresenterIssue.Core;

namespace MvxFormsIosViewPresenterIssue.iOS
{
    public class Setup : MvxFormsIosSetup<App, FormsApp>
    {
        public override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.Console;

        protected override IMvxIosViewPresenter CreateViewPresenter()
        {
            var presenter = new MvxFormsIosViewPresenter((MvxApplicationDelegate)ApplicationDelegate, Window, FormsApplication);
            return presenter;
        }
    }
}
