﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.ViewModel;
using Xamarin.Forms;

namespace Toolbox.View
{
    public partial class MunitConverter : ContentPage
    {
        private MunitConverterViewModel _viewModel;

        public MunitConverter()
        {
            InitializeComponent();

            Title = "Mesurement Converter";

            _viewModel = new MunitConverterViewModel();

            this.BindingContext = _viewModel;
        }
    }
}
