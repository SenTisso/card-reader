﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using card_reader.Database;
using card_reader.Models;
using card_reader.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace card_reader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraPage : ZXingScannerPage
    {
        private string Name;
        private string Color;
        private Card SavedCard;
        
        public CameraPage(Card NewCard)
        {
            InitializeComponent();

            this.SavedCard = NewCard;
        }

        async public void Handle_OnScanResult(Result result)
        {
            SavedCard.BarcodeContent = result.Text;
            SavedCard.BarcodeFormat = result.BarcodeFormat;

            // ulozi kartu do DB
            int id = await App.Database.CreateCard(SavedCard);

            if (id >= 0)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    // spusti stranku CardDetail a preda ji CardDetailViewModel, cemuz preda tu kartu
                    Navigation.PushAsync(new CardDetailPage(SavedCard, true));
                });
            }
        }
    }
}
