using System.Diagnostics;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnSendCode.PropertyChanged += BtnSendCode_PropertyChanged;
            container.PropertyChanged += Input_PropertyChanged;
        }

        private void Input_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Width")
            {
                Debug.WriteLine(container.Width);
            }
        }

        private void BtnSendCode_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Width")
            {
                Debug.WriteLine(btnSendCode.Width);
            }
        }
    }
}
