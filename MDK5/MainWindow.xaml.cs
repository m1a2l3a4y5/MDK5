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

namespace MDK5
{
    //Создать класс Triangle(треугольник) с полями-сторонами.Создать необходимые методы и свойства.
    //Определить метод вычисления периметра.Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения размеров треугольника в 2 раза.

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        Triangle triangle = new Triangle();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Расчёт(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(сторонаА.Text, out int a) && int.TryParse(сторонаВ.Text, out int b) && int.TryParse(сторонаС.Text, out int c) && a > 0 && b > 0 && c > 0)
            {            
                triangle.SetParams(a, b, c); // Установка параметров треугольника
                периметр.Text = triangle.CalcPerimeter().ToString();
            }
            else MessageBox.Show("Ошибка, стороны треугольника должны быть положительными числами");
        }

        private void Увеличение(object sender, RoutedEventArgs e)
        {
            
            if (int.TryParse(сторонаА.Text, out int a) && int.TryParse(сторонаВ.Text, out int b) && int.TryParse(сторонаС.Text, out int c) && a > 0 && b > 0 && c > 0)
            {             
                    triangle.SetParams(a, b, c, true); // Увеличение размеров треугольника
                    // Ты выводила текст с полей ввода
                    // А не из triangle
                    // Если будет ошибку писать, допиши каждому triangle ToString
                    удвА.Text = triangle.A;
                    удвВ.Text = triangle.B;
                    удвС.Text = triangle.C;              
            }
            else MessageBox.Show("Ошибка, должны быть заполнены текстбоксы со сторонами");

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Рубан Л. ИСП-31 Практическая работа №1:Создать класс Triangle(треугольник) с полями-сторонами.Создать необходимые методы и свойства.Определить метод вычисления периметра.Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения размеров треугольника в 2 раза.");
        }

        private void Очистка1(object sender, RoutedEventArgs e)
        {
            удвА.Clear();
            удвВ.Clear();
            удвС.Clear();
            сторонаА.Clear();
            сторонаВ.Clear();
            сторонаС.Clear();
            периметр.Clear();
        }
    }
}
