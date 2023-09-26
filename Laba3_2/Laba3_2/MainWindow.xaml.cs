using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba3_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (incCanvas == null)
                return;
            incCanvas.DefaultDrawingAttributes.Width = e.NewValue;
            incCanvas.DefaultDrawingAttributes.Height = e.NewValue;
            incCanvas.EraserShape = new RectangleStylusShape(e.NewValue, e.NewValue);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (incCanvas == null)
                return;
            ComboBox element = sender as ComboBox;
            if (element == null)
                return;
            ComboBoxItem item = element.SelectedItem as ComboBoxItem;
            if (item == null)
                return;
            string color_hex = item.Tag.ToString();
            Color color = (Color)ColorConverter.ConvertFromString(color_hex);
            incCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            switch (radioButton.Tag)
            {
                case "draw":
                    incCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "edit":
                    incCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
                case "remove":
                    incCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                default:
                    break;
            }
        }
    }
}
