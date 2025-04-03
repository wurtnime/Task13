using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp.Tasks;

// Artem Vavilonovich and ego prostata

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnExecuteButtonClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaskNumberTextBox.Text, out int taskNumber) && taskNumber >= 1 && taskNumber <= 30)
            {
                ErrorMessageText.Text = ""; 
                TaskDescriptionText.Text = GetTaskDescription(taskNumber); 
                LoadInputFields(taskNumber); 
                ResultText.Text = ""; 
            }
            else
            {
                ErrorMessageText.Text = "Неверный номер задания. Введите число от 1 до 30.";
                TaskDescriptionText.Text = ""; 
                InputPanel.Children.Clear(); 
                ResultText.Text = ""; 
            }
        }

        private string GetTaskDescription(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    return "Задание 1: Перевод двоичного числа в десятичное.";
                case 2:
                    return "Задание 2: Перевод двоичного числа в восьмеричное.";
                case 3:
                    return "Задание 3: Перевод двоичного числа в шестнадцатеричное.";
                case 4:
                    return "Задание 4: Перевод дробного двоичного числа в десятичное.";
                case 5:
                    return "Задание 5: Перевод дробного двоичного числа в восьмеричное.";
                case 6:
                    return "Задание 6: Перевод дробного двоичного числа в шестнадцатеричное.";
                case 7:
                    return "Задание 7: Изменение разрядности цифр в массиве.";
                case 8:
                    return "Задание 8: Перевод массива из восьмеричных чисел в десятичные.";
                case 9:
                    return "Задание 9: Получение массива из старших разрядов.";
                case 10:
                    return "Задание 10: Объединение и сортировка двух массивов.";
                case 11:
                    return "Задание 11: Удаление элементов, встречающихся более двух раз.";
                case 12:
                    return "Задание 12: Поиск местоположения двух одинаковых элементов.";
                case 13:
                    return "Задание 13: Циклический сдвиг двоичного числа влево на две позиции.";
                case 14:
                    return "Задание 14: Упорядочивание двоичных чисел по убыванию и вычисление суммы.";
                case 15:
                    return "Задание 15: Упорядочивание двоичных чисел по возрастанию и вычисление среднего.";
                case 16:
                    return "Задание 16: Поменять местами максимальный и минимальный элементы.";
                case 17:
                    return "Задание 17: Циклический сдвиг двоичного числа вправо на одну позицию.";
                case 18:
                    return "Задание 18: Разность сумм возрастающих и убывающих участков массива.";
                case 19:
                    return "Задание 19: Проверка на арифметическую прогрессию.";
                case 20:
                    return "Задание 20: Проверка на геометрическую прогрессию.";
                case 21:
                    return "Задание 21: Индексы элементов, больших, чем справа.";
                case 22:
                    return "Задание 22: Номер последнего элемента, удовлетворяющего условию.";
                case 23:
                    return "Задание 23: Количество чисел между максимальным и минимальным элементами.";
                case 24:
                    return "Задание 24: Циклический сдвиг массива вправо на одну позицию.";
                case 25:
                    return "Задание 25: Циклический сдвиг массива влево на одну позицию и сумма.";
                case 26:
                    return "Задание 26: Увеличение каждого элемента массива на двоичное число 1010.";
                case 27:
                    return "Задание 27: Нахождение элемента, наиболее близкого к заданному числу R.";
                case 28:
                    return "Задание 28: Нахождение элемента, наиболее удаленного от заданного двоичного числа D.";
                case 29:
                    return "Задание 29: Сложение положительного и отрицательного двоичных чисел.";
                case 30:
                    return "Задание 30: Перевод массива десятичных чисел в двоичные.";
                default:
                    return "Описание задания отсутствует.";
            }
        }

        private void LoadInputFields(int taskNumber)
        {
            InputPanel.Children.Clear(); 

            switch (taskNumber)
            {
                case 1:
                    AddInputField("Введите двоичное число:", "binaryInput");
                    AddButton("Перевести", () => ExecuteTask1());
                    break;
                case 2:
                    AddInputField("Введите двоичное число:", "binaryInput");
                    AddButton("Перевести", () => ExecuteTask2());
                    break;
                case 3:
                    AddInputField("Введите двоичное число:", "binaryInput");
                    AddButton("Перевести", () => ExecuteTask3());
                    break;
                case 4:
                    AddInputField("Введите дробное двоичное число (например, 101.101):", "binaryInput");
                    AddButton("Перевести", () => ExecuteTask4());
                    break;
                case 5:
                    AddInputField("Введите дробное двоичное число (например, 101.101):", "binaryInput");
                    AddButton("Перевести", () => ExecuteTask5());
                    break;
                case 6:
                    AddInputField("Введите дробное двоичное число (например, 101.101):", "binaryInput");
                    AddButton("Перевести", () => ExecuteTask6());
                    break;
                case 7:
                    AddInputField("Введите массив двузначных чисел через пробел:", "arrayInput");
                    AddButton("Изменить разрядность", () => ExecuteTask7());
                    break;
                case 8:
                    AddInputField("Введите массив восьмеричных чисел через пробел:", "arrayInput");
                    AddButton("Перевести в десятичные", () => ExecuteTask8());
                    break;
                case 9:
                    AddInputField("Введите массив двузначных чисел через пробел:", "arrayInput");
                    AddButton("Получить старшие разряды", () => ExecuteTask9());
                    break;
                case 10:
                    AddInputField("Введите первый массив действительных чисел через пробел:", "array1Input");
                    AddInputField("Введите второй массив действительных чисел через пробел:", "array2Input");
                    AddButton("Объединить и отсортировать", () => ExecuteTask10());
                    break;
                case 11:
                    AddInputField("Введите массив двоичных чисел через пробел:", "arrayInput");
                    AddButton("Удалить дубликаты", () => ExecuteTask11());
                    break;
                case 12:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Найти одинаковые элементы", () => ExecuteTask12());
                    break;
                case 13:
                    AddInputField("Введите двоичное число:", "binaryInput");
                    AddButton("Сдвинуть влево", () => ExecuteTask13());
                    break;
                case 14:
                    AddInputField("Введите массив двоичных чисел через пробел:", "arrayInput");
                    AddButton("Упорядочить и вычислить сумму", () => ExecuteTask14());
                    break;
                case 15:
                    AddInputField("Введите массив двоичных чисел через пробел:", "arrayInput");
                    AddButton("Упорядочить и вычислить среднее", () => ExecuteTask15());
                    break;
                case 16:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Поменять местами max и min", () => ExecuteTask16());
                    break;
                case 17:
                    AddInputField("Введите двоичное число:", "binaryInput");
                    AddButton("Сдвинуть вправо", () => ExecuteTask17());
                    break;
                case 18:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Вычислить разность сумм", () => ExecuteTask18());
                    break;
                case 19:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Проверить арифметическую прогрессию", () => ExecuteTask19());
                    break;
                case 20:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Проверить геометрическую прогрессию", () => ExecuteTask20());
                    break;
                case 21:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Найти индексы", () => ExecuteTask21());
                    break;
                case 22:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Найти последний элемент", () => ExecuteTask22());
                    break;
                case 23:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Найти количество чисел между max и min", () => ExecuteTask23());
                    break;
                case 24:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Сдвинуть вправо", () => ExecuteTask24());
                    break;
                case 25:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Сдвинуть влево и вычислить сумму", () => ExecuteTask25());
                    break;
                case 26:
                    AddInputField("Введите массив чисел через пробел:", "arrayInput");
                    AddButton("Увеличить на 1010", () => ExecuteTask26());
                    break;
                case 27:
                    AddInputField("Введите массив действительных чисел через пробел:", "arrayInput");
                    AddInputField("Введите число R:", "rInput");
                    AddButton("Найти ближайший элемент", () => ExecuteTask27());
                    break;
                case 28:
                    AddInputField("Введите массив двоичных чисел через пробел:", "arrayInput");
                    AddInputField("Введите двоичное число D:", "dInput");
                    AddButton("Найти наиболее удаленный элемент", () => ExecuteTask28());
                    break;
                case 29:
                    AddInputField("Введите положительное двоичное число:", "positiveBinaryInput");
                    AddInputField("Введите отрицательное двоичное число:", "negativeBinaryInput");
                    AddButton("Сложить числа", () => ExecuteTask29());
                    break;
                case 30:
                    AddInputField("Введите массив десятичных чисел через пробел:", "arrayInput");
                    AddButton("Перевести в двоичные", () => ExecuteTask30());
                    break;
                default:
                    ErrorMessageText.Text = "Задание еще не реализовано.";
                    break;
            }
        }

        private void AddInputField(string label, string name)
        {
            var stackPanel = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 5, 0, 5) };
            stackPanel.Children.Add(new TextBlock { Text = label, FontSize = 14, Margin = new Thickness(0, 0, 10, 0) });
            stackPanel.Children.Add(new TextBox { Name = name, Width = 200, FontSize = 14 });
            InputPanel.Children.Add(stackPanel);
        }

        private void AddButton(string content, Action onClick)
        {
            var button = new Button { Content = content, FontSize = 14, Margin = new Thickness(0, 10, 0, 0), Padding = new Thickness(10, 5, 10, 5) };
            button.Click += (sender, e) => onClick();
            InputPanel.Children.Add(button);
        }

        private void ExecuteTask1()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task1();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask2()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task2();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask3()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task3();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask4()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task4();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask5()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task5();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask6()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task6();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask7()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task7();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask8()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                string[] array = arrayInput.Split(' ');
                var task = new Task8();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask9()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task9();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask10()
        {
            var array1InputTextBox = FindChild<TextBox>(InputPanel, "array1Input");
            var array2InputTextBox = FindChild<TextBox>(InputPanel, "array2Input");
            string array1Input = array1InputTextBox?.Text;
            string array2Input = array2InputTextBox?.Text;

            try
            {
                double[] array1 = Array.ConvertAll(array1Input.Split(' '), double.Parse);
                double[] array2 = Array.ConvertAll(array2Input.Split(' '), double.Parse);
                var task = new Task10();
                ResultText.Text = task.Execute(array1, array2);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask11()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task11();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask12()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task12();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask13()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task13();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask14()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                string[] array = arrayInput.Split(' ');
                var task = new Task14();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask15()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                string[] array = arrayInput.Split(' ');
                var task = new Task15();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask16()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task16();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask17()
        {
            var binaryInputTextBox = FindChild<TextBox>(InputPanel, "binaryInput");
            string binaryInput = binaryInputTextBox?.Text;

            var task = new Task17();
            ResultText.Text = task.Execute(binaryInput);
        }

        private void ExecuteTask18()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task18();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask19()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task19();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask20()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task20();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask21()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task21();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask22()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task22();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask23()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task23();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask24()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task24();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask25()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task25();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask26()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task26();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private void ExecuteTask27()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            var rInputTextBox = FindChild<TextBox>(InputPanel, "rInput");
            string arrayInput = arrayInputTextBox?.Text;
            string rInput = rInputTextBox?.Text;

            try
            {
                double[] array = Array.ConvertAll(arrayInput.Split(' '), double.Parse);
                double R = double.Parse(rInput);
                var task = new Task27();
                ResultText.Text = task.Execute(array, R);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод данных.";
            }
        }

        private void ExecuteTask28()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            var dInputTextBox = FindChild<TextBox>(InputPanel, "dInput");
            string arrayInput = arrayInputTextBox?.Text;
            string dInput = dInputTextBox?.Text;

            try
            {
                string[] array = arrayInput.Split(' ');
                var task = new Task28();
                ResultText.Text = task.Execute(array, dInput);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод данных.";
            }
        }

        private void ExecuteTask29()
        {
            var positiveBinaryInputTextBox = FindChild<TextBox>(InputPanel, "positiveBinaryInput");
            var negativeBinaryInputTextBox = FindChild<TextBox>(InputPanel, "negativeBinaryInput");
            string positiveBinaryInput = positiveBinaryInputTextBox?.Text;
            string negativeBinaryInput = negativeBinaryInputTextBox?.Text;

            var task = new Task29();
            ResultText.Text = task.Execute(positiveBinaryInput, negativeBinaryInput);
        }

        private void ExecuteTask30()
        {
            var arrayInputTextBox = FindChild<TextBox>(InputPanel, "arrayInput");
            string arrayInput = arrayInputTextBox?.Text;

            try
            {
                int[] array = Array.ConvertAll(arrayInput.Split(' '), int.Parse);
                var task = new Task30();
                ResultText.Text = task.Execute(array);
            }
            catch
            {
                ResultText.Text = "Ошибка: некорректный ввод массива.";
            }
        }

        private T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is T && ((FrameworkElement)child).Name == childName)
                {
                    return (T)child;
                }
                var result = FindChild<T>(child, childName);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }
    }
}