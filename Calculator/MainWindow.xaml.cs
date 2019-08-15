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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Addition_ButtonClick(object sender, RoutedEventArgs e)
        {
            OperateInt(1);
        }
        private void Subtract_ButtonClick(object sender, RoutedEventArgs e)
        {
            OperateInt(2);
        }
        private void Multiplication_ButtonClick(object sender, RoutedEventArgs e)
        {
            OperateInt(3);
        }
        private void Division_ButtonClick(object sender, RoutedEventArgs e)
        {
            OperateInt(4);
        }
        private void OperateInt(int operate)
        {
            int firstInput = int.Parse(firstInputBox.Text);
            int secondInput = int.Parse(secondInputBox.Text);

            int result = 0;
            switch (operate)
            {
                case 1:
                    result = firstInput + secondInput;
                    break;
                case 2:
                    result = firstInput - secondInput;
                    break;
                case 3:
                    result = firstInput * secondInput;
                    break;
                case 4:
                    result = firstInput / secondInput;
                    break;
            }
            resultBox.Text = result + "";    
        }
    }
}
