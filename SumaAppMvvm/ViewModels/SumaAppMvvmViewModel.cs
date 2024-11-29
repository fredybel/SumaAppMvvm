
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaAppMvvmViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double suma;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            
            try
            {
               
                Suma = A + B;

               
            }


            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }
        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            Suma = 0;

        }
    }
    }


