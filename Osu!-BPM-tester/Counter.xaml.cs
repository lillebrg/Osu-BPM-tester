using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Windows.Threading;

namespace Osu__BPM_tester
{
    /// <summary>
    /// Interaction logic for Counter.xaml
    /// </summary>
    public partial class Counter : Page
    {
        public double count;
        private int time = 10;
        private DispatcherTimer Timer;
        
        public Counter()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Time_Tick;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
//this is the timer that counts down from 10 seconds and changes color every second.
            if (time > 0)
            {
                if (time <= 10)
                {
                    if (time%2==0)
                    {
                        txbTimer.Foreground = Brushes.Red;  
                    }
                    else
                    {
                        txbTimer.Foreground = Brushes.White;
                    }

                    time--;
                    txbTimer.Text = String.Format("00:0{0}:0{1}", time / 60, time % 60);
                }
                else
                {
                    time--;
                    txbTimer.Text = String.Format("00:0{0}:{1}", time / 60, time % 60);
                }

            }
            else
            {
                Timer.Stop();
            }

        }
        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            do
            {
                if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.D))
                {
                    Timer.Start();
                    txtCounter.Text = count++.ToString();
                    txtarrow.Opacity = 0;
                    txbTimer.Opacity = 100;
//everytime the keybinds that has been said is being pressed, it will add one 
                    
                }
                if (time == 0)
                {
                    tapbox.Visibility = Visibility.Hidden;
                    txtCounter.Text = $"You tapped '{count}' times, which means your avg bpm is {count / 4*6}!";
                }
            } while (time == -1);
        }
    }
}
