using CRYPTOKliker.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRYPTOKliker
{
    /// <summary>
    /// Логика взаимодействия для TRADEWindow.xaml
    /// </summary>
    public partial class TRADEWindow : Window
    {
        


        public TRADEWindow(int click)
        {
            InitializeComponent();
            bububu.Text = click.ToString();
        }




        //private void Perevod_Click(object sender, RoutedEventArgs e)
        //{
        //    if (double.TryParse(KTONVVOD.Text, out double sum))
        //    {
        //        double convertedrub = sum * 0.0005 - 0.00025;//фомула для подсчета волюты 
        //        RUBOTV.Text = convertedrub.ToString();

        //    }



        //}



        private void Perewod_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(KTONVOD.Text, out double sum))
            {
                double converteddollar = sum * 0.00005 - 0.000025;//фомула для подсчета волюты
                DOLLARS.Text = converteddollar.ToString();




            }
        }

        //private async void VIVOD_Click(object sender, RoutedEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(KTONVVOD.Text)) // Проверяем, что KTONVVOD пусто
        //    {
        //        // Если KTONVVOD пусто, открываем новую страницу
        //        ErrorWindow errorWindow = new ErrorWindow();
        //        errorWindow.Show();

        //        await Task.Delay(2000);
        //        errorWindow.Close();
        //    }
        //    else
        //    {
        //        VivodWindow vivodWindow = new VivodWindow();
        //        vivodWindow.Show();

        //        await Task.Delay(2000);
        //        vivodWindow.Close();
        //    }
        //    KTONVVOD.Text = "";
        //    RUBOTV.Text = "";
        //    KTONVOD.Text = "";
        //    DOLLARS.Text = "";

           
        //}

        private void KTONVVOD_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(KTONVVOD.Text, out int sum))
            {
                int currentValueRub = int.Parse(bububu.Text);
                int newValue = currentValueRub - sum;
                bububu.Text = (currentValueRub - sum).ToString(); //функция нужна для того чтобы пользователь когда вводил сумму, то при значении меньше нуля окно закрывалось не давая уйти в минус 
                if (newValue < 0)
                {
                    this.Close();

                }
            }
        }

        private void KTONVOD_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(KTONVOD.Text, out int sum))
            {
                int currentValueDoll = int.Parse(bububu.Text);
                int newValue = currentValueDoll - sum;
                bububu.Text = (currentValueDoll - sum).ToString(); //функция нужна для того чтобы пользователь когда вводил сумму, то при значении меньше нуля окно закрывалось не давая уйти в минус 
                if (newValue < 0)
                {
                    this.Close();

                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnProopertyChangend([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }

}
