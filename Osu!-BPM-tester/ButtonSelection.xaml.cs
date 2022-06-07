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
    /// Interaction logic for ButtonSelection.xaml
    /// </summary>
    public partial class ButtonSelection : Page
    {
        public string inp1;
        public string inp2;
        public ButtonSelection()
        {
            InitializeComponent();
            //this initialize thing is basically a method that loads when the page loads. so if you want anything to happen before the user can to anything, put it here

        }

        public void btnDone_Click(object sender, RoutedEventArgs e)
        {
            inp1 = input1.Text;
            inp2 = input2.Text;
            ButtonSelect.Content = new Counter(inp1, inp2);
            //this command uses the frame from MainWindow.xaml for help, so the program knows where the code came from and where it is going ^
            //this time i added the to variables to go with the next pictures becuase i need to use them for the keybind system
        }
    }
}
