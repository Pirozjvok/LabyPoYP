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

namespace Laba11_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            image1.textBox.Text = "https://postila.ru/data/1e/69/83/7d/1e69837d2677676a2dd64af78393010b9db85c2a6b9acebed9eba21c8f0ba3ee.jpg";
            image2.textBox.Text = "http://rasfokus.ru/images/photos/medium/a187117ea1d3d38f2d1437ad86f2602a.jpg";
            image3.textBox.Text = "https://avatars.mds.yandex.net/i?id=2afa1dcc0bcea8a61e298dc579d1181cf972a5c9-10576312-images-thumbs&n=13";
            image4.textBox.Text = "https://postila.ru/data/1e/69/83/7d/1e69837d2677676a2dd64af78393010b9db85c2a6b9acebed9eba21c8f0ba3ee.jpg";
            image5.textBox.Text = "http://rasfokus.ru/images/photos/medium/a187117ea1d3d38f2d1437ad86f2602a.jpg";
            image6.textBox.Text = "https://avatars.mds.yandex.net/i?id=2afa1dcc0bcea8a61e298dc579d1181cf972a5c9-10576312-images-thumbs&n=13";
        }
    }
}
