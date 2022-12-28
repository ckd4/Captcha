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
using CaptchaClass;

namespace Captcha
{
    public partial class MainWindow : Window
    {
        CaptchaC C;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C = new CaptchaC(Convert.ToUInt32(SymbolsTB.Text), Convert.ToUInt32(DigitsTB.Text), Convert.ToBoolean(RepeatCB.IsChecked));
                C.Generate();
                CaptchaLabel.Content = C.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void CheckBT_Click(object sender, RoutedEventArgs e)
        {
            if (CaptchaLabel.Content.ToString() == CheckTB.Text)
                LabelValid.Content = "Captcha is valid";
            else
                LabelValid.Content = "Captcha is not valid!";
        }
    }
}
