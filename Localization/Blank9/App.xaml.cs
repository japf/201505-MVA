﻿using System;
using System.Threading.Tasks;
using Blank9.Common;
using Windows.ApplicationModel.Activation;

namespace Blank9
{
    sealed partial class App : Common.BootStrapper
    {
        public App()
        {
            InitializeComponent();
        }

        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            NavigationService.Navigate(typeof(Views.MainPage));
            return Task.FromResult<object>(null);
        }
    }
}
