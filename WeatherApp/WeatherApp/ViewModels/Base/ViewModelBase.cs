﻿using System;
using System.Threading.Tasks;
using WeatherApp.Services.Dialog;
using WeatherApp.Services.Navigation;
using WeatherApp.Services.Settings;

namespace WeatherApp.ViewModels.Base
{
    public class ViewModelBase: ExtendedBindableObject
    {
        protected readonly IDialogService DialogService;
        protected readonly INavigationService NavigationService;

        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        public ViewModelBase()
        {
            DialogService = ViewModelLocator.Resolve<IDialogService>();
            NavigationService = ViewModelLocator.Resolve<INavigationService>();

            var settingsService = ViewModelLocator.Resolve<ISettingsService>();

           
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}