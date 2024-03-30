using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CRYPTOKliker.ViewModel.Helpers
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        private int clickCount;

        public int ClickCount
        {
            get { return clickCount; }
            set
            {
                if (clickCount != value)
                {
                    clickCount = value;
                    OnPropertyChanged();
                }
            }
        }

        public BindingCommand ClickCommand { get; set; }
        public BindingCommand TradeComand { get; set; }
        public TextBox KTONVVOD { get; private set; }
        public TextBox RUBOTV { get; private set; }
        public TextBox KTONVOD { get; private set; }
        public TextBox DOLLARS { get; private set; }
         public BindingCommand VivestiComand  { get; set; }  

        //public BindingCommand PerevodComand { get; set; }
        //public TextBox RUBOTV { get;  set; }
        //public TextBox KTONVVOD { get;  set; }

        public MainViewModel()
        {

            

            ClickCommand = new BindingCommand(_ => IncrementClickCount());
            ClickCount = 0;

            TradeComand = new BindingCommand(_ => TradeOkno());
            VivestiComand = new BindingCommand(_ => Vivesti());




           // PerevodComand = new BindingCommand(_ => Perevod(KTONVVOD, RUBOTV));

        }

        //private void Perevod(object kTONVVOD, object rUBOTV)
        //{
        //    throw new NotImplementedException();
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void IncrementClickCount()
        {
            ClickCount += 2;
        }

        public  void TradeOkno()
        {
            TRADEWindow tradeWindow = new TRADEWindow(clickCount);
            tradeWindow.Show();

        }


        //public void Perevod(TextBox KTONVVOD, TextBox RUBOTV) 
        //{

        //    if (double.TryParse(KTONVVOD.Text, out double sum))
        //    {
        //        double convertedrub = sum * 0.0005 - 0.00025;//фомула для подсчета волюты 
        //        RUBOTV.Text = convertedrub.ToString();

        //    }

        //} анологично с вводом и выводом в dollars 
        //для xaml Text="{Binding KTONVVOD}"  Text="{Binding RUBOTV}" Command="{Binding PerevodComand}" 


        public async void Vivesti()
        {
            if (string.IsNullOrEmpty(KTONVVOD.Text)) // Проверяем, что KTONVVOD пусто
            {
                // Если KTONVVOD пусто, открываем новую страницу
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Show();

                await Task.Delay(2000);
                errorWindow.Close();
            }
            else
            {
                VivodWindow vivodWindow = new VivodWindow();
                vivodWindow.Show();

                await Task.Delay(2000);
                vivodWindow.Close();
            }
            KTONVVOD.Text = "";
            RUBOTV.Text = "";
            KTONVOD.Text = "";
            DOLLARS.Text = "";


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


    }
}
    

