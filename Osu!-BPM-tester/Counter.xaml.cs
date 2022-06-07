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
        public Counter(string Inp1, string Inp2)
        {
            Key I1, I2;
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Time_Tick;
//time_tick is a void. So when the code runs down to that line, the codebehind is activated.
            Inp1.ToUpper();
            Inp2.ToUpper();
//setting the variables to Upper case, since that will be easier to use.

            if (Inp1 == "Q")
            {
                I1 = Key.Q;
            }
            //else if (Inp1 == "W")
            //{
            //    I1 = Key.W;
            //}
            //else if (Inp1 == "E")
            //{
            //    I1 = Key.E;
            //}
            //else if (Inp1 == "R")
            //{
            //    I1 = Key.R;
            //}
            //else if (Inp1 == "A")
            //{
            //    I1 = Key.A;
            //}
            //else if (Inp1 == "S")
            //{
            //    I1 = Key.S;
            //}
            //else if (Inp1 == "D")
            //{
            //    I1 = Key.D;
            //}
            //else if (Inp1 == "F")
            //{
            //    I1 = Key.F;
            //}
            //else if (Inp1 == "Z")
            //{
            //    I1 = Key.Z;
            //}
            //else if (Inp1 == "X")
            //{
            //    I1 = Key.X;
            //}
            //else if (Inp1 == "C")
            //{
            //    I1 = Key.C;
            //}
            //else if (Inp1 == "V")
            //{
            //    I1 = Key.V;
            //}
//--------------------------------------------------//
            if (Inp2 == "E")
            {
                I2 = Key.E;
            }
            //else if (Inp2 == "W")
            //{
            //    I2 = Key.W;
            //}
            //else if (Inp2 == "E")
            //{
            //    I2 = Key.E;
            //}
            //else if (Inp2 == "R")
            //{
            //    I2 = Key.R;
            //}
            //else if (Inp2 == "A")
            //{
            //    I2 = Key.A;
            //}
            //else if (Inp2 == "S")
            //{
            //    I2 = Key.S;
            //}
            //else if (Inp2 == "D")
            //{
            //    I2 = Key.D;
            //}
            //else if (Inp2 == "F")
            //{
            //    I2 = Key.F;
            //}
            //else if (Inp2 == "Z")
            //{
            //    I2 = Key.Z;
            //}
            //else if (Inp2 == "X")
            //{
            //    I2 = Key.X;
            //}
            //else if (Inp2 == "C")
            //{
            //    I2 = Key.C;
            //}
            //else if (Inp2 == "V")
            //{
            //    I2 = Key.V;
            //}
            //hardcoded everything
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
                if (Keyboard.IsKeyDown(I1) || Keyboard.IsKeyDown(I2))
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
