using Logic;
using Logic.Enums;
using System;
using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace TrafficLight
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public readonly DispatcherTimer timer;
        public int count = 0;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                TrafficLightColor.CurrentColor = EnumColor.Stop;
                timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 4) };
                timer.Tick += TrafficLightColor.Change;
                timer.Tick += ChangeColor;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ChangeColor(object sender, object e) // хз куда убрать... Я  тупой
        {

            switch (TrafficLightColor.CurrentColor)
            { 
                case EnumColor.Go:
                    RedLight.Fill = Brushes.Black;
                    GreenLight.Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    YellowLight.Fill = Brushes.Black;
                    break;
                case EnumColor.Wait:
                    RedLight.Fill = Brushes.Black;
                    GreenLight.Fill = Brushes.Black;
                    YellowLight.Fill = Brushes.Yellow;
                    break;
                case EnumColor.Stop:

                    RedLight.Fill = Brushes.Red;
                    GreenLight.Fill = Brushes.Black;
                    YellowLight.Fill = Brushes.Black;

                    break;
                case EnumColor.Ready:
                    RedLight.Fill = Brushes.Red;
                    GreenLight.Fill = Brushes.Black;
                    YellowLight.Fill = Brushes.Yellow;
                    break;
                case EnumColor.None:
                    timer.Interval = new TimeSpan(0, 0, 1);
                    RedLight.Fill = Brushes.Black;
                    GreenLight.Fill = Brushes.Black;
                    YellowLight.Fill = Brushes.Black;
                    break;
            }
        }
    }
}
