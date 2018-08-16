﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.WarehouseTransfer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail(int transferId)
        {
            InitializeComponent();
            BindingContext = new ProductTransferDetailViewModel(transferId);
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new SubMenu());
        }
        public void ButtonBackClick()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();

        }
    }
}