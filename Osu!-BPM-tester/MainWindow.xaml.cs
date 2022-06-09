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

namespace Osu__BPM_tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this initialize thing is basically a method that loads when the page loads. so if you want anything to happen before the user can to anything, put it here
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        //command that triggers when the user presses the button. therefore called Button_Click ^
        {
            MessageBox.Show("In osu! you have 2 inputs on your keyboard, to press the circles ingame. Therefore choose 2 keys on your keyboard that you wanna use!");
            //Messagebox.show is like an alertbox that appears in the middle of the screen. You cant contínue with the program before you close the messagebox ^
            Main.Content = new Counter(); 
            //this command uses the frame from MainWindow.xaml for help, so the program knows where the code came from and where it is going ^
        }
    }
}
