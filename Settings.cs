// Copyright © 2020 Andrew Vardeman.  Published under the MIT license.
// See license.txt in the AzureMultiTranslator distribution or repository for the
// full text of the license.

using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace AzureMultiTranslator
{
    public class Settings : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _saveSubscriptionKey;
        public bool SaveSubscriptionKey
        {
            get => _saveSubscriptionKey;
            set => SetField(ref _saveSubscriptionKey, value);
        }

        private string _subscriptionKey;
        [JsonConverter(typeof(EncryptingJsonConverter), "###AzureMultiTranslator###")]
        public string SubscriptionKey
        {
            get => _subscriptionKey;
            set => SetField(ref _subscriptionKey, value);
        }

        private string _endpoint;
        public string Endpoint
        {
            get => _endpoint;
            set => SetField(ref _endpoint, value);
        }

        private decimal _maxChars = 5000;

        public decimal MaxChars
        {
            get => _maxChars;
            set => SetField(ref _maxChars, value);
        }


        private bool _html = true;
        public bool Html
        {
            get => _html;
            set => SetField(ref _html, value);
        }

        private bool _backTranslate = true;
        public bool BackTranslate
        {
            get => _backTranslate;
            set => SetField(ref _backTranslate, value);
        }

        private BindingList<string> _languages = new BindingList<string>();
        public BindingList<string> Languages
        {
            get => _languages;
        }

        private Size _windowSize = new Size(700, 500);
        public Size WindowSize
        {
            get => _windowSize;
            set => SetField(ref _windowSize, value);
        }

        private Point _windowLocation = new Point(0, 0);
        public Point WindowLocation
        {
            get => _windowLocation;
            set => SetField(ref _windowLocation, value);
        }

        private int _mainSplitContainerSplitterDistance = 300;
        public int MainSplitContainerSplitterDistance
        {
            get => _mainSplitContainerSplitterDistance;
            set => SetField(ref _mainSplitContainerSplitterDistance, value);
        }

        private int _translationPaneSplitContainerSplitterDistance = 150;
        public int TranslationsPaneSplitContainerSplitterDistance
        {
            get => _translationPaneSplitContainerSplitterDistance;
            set => SetField(ref _translationPaneSplitContainerSplitterDistance, value);
        }

        private int _translationsTextBoxesSplitContainerSplitterDistance = 300;
        public int TranslationsTextBoxesSplitContainerSplitterDistance
        {
            get => _translationsTextBoxesSplitContainerSplitterDistance;
            set => SetField(ref _translationsTextBoxesSplitContainerSplitterDistance, value);
        }

        private bool _maximized = false;
        public bool Maximized
        {
            get => _maximized;
            set => SetField(ref _maximized, value);
        }

        public Settings()
        {
            Endpoint = "https://api.cognitive.microsofttranslator.com";
            _languages.ListChanged += Languages_ListChanged;
        }

        private void Languages_ListChanged(object sender, ListChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Languages));
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
