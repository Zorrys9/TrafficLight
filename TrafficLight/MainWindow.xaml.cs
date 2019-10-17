using Logic;
using System;
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

        readonly DispatcherTimer timer;
        public int count = 0;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                TrafficLightColor.CurrentColor = TrafficLightColor.EnumColor.Red;
                timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 5) };
                timer.Tick += TrafficLightColor.Change;
                timer.Tick += ChangeColor;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ChangeColor(object sender, object e)
        {

            switch (TrafficLightColor.CurrentColor)
            { 
                case TrafficLightColor.EnumColor.Red:
                    RedLight.Fill = Brushes.Red;
                    GreenLight.Fill = Brushes.Black;
                    YellowLight.Fill = Brushes.Black;
                    break;
                case TrafficLightColor.EnumColor.Yellow:
                    RedLight.Fill = Brushes.Black;
                    GreenLight.Fill = Brushes.Black;
                    YellowLight.Fill = Brushes.Yellow;
                    break;
                case TrafficLightColor.EnumColor.Green:
                    RedLight.Fill = Brushes.Black;
                    GreenLight.Fill = new SolidColorBrush(Color.FromRgb(0,255,0));
                    YellowLight.Fill = Brushes.Black;
                    break;
            }
        }
    }
}
