
using CommunityToolkit.Mvvm.ComponentModel;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaAppMvvmViewModel : ObservableObject
    {
        [ObservableProperty]
        private double n1;

        [ObservableProperty]
        private double n2;


        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }
    }
}
