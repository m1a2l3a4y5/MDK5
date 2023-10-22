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
        public MainWindow()
        {
            InitializeComponent();

        }
        Triangle triangle = new Triangle();
        private void Расчёт(object sender, RoutedEventArgs e)
        {
            bool f1 = Int32.TryParse(сторонаА.Text, out int a);// проверка на числовой тип данных
            bool f2 = Int32.TryParse(сторонаВ.Text, out int b);
            bool f3 = Int32.TryParse(сторонаС.Text, out int c);
            if (f1 && f2 && f3 && a > 0 && b > 0 && c > 0)
            {            
                triangle.SetParams(a, b, c); // Установка параметров треугольника
                double perimeter = triangle.CalcPerimeter(); // Вычисление периметра
                периметр.Text = Convert.ToString(perimeter);
            }
            else MessageBox.Show("Ошибка, стороны треугольника должны быть положительными числами");
        }

        private void Увеличение(object sender, RoutedEventArgs e)
        {
            bool f1 = Int32.TryParse(сторонаА.Text, out int a);
            bool f2 = Int32.TryParse(сторонаВ.Text, out int b);
            bool f3 = Int32.TryParse(сторонаС.Text, out int c);
            
            if (f1 && f2 && f3 && a > 0 && b > 0 && c > 0 )
            {             
                    triangle.SetParams(a, b, c, true); // Увеличение размеров треугольника

                    удвА.Text = Convert.ToString(a);
                    удвВ.Text = Convert.ToString(b);
                    удвС.Text = Convert.ToString(c);                
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
