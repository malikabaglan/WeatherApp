﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WeatherApp.Views
{
    public partial class CustomNavigationView :NavigationPage
    {
        public CustomNavigationView() : base()
        {
            InitializeComponent();
        }

        public CustomNavigationView(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}