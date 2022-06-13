using System;
using System.IO;
using System.Windows;
using System.Windows.Input;


namespace Курсовая_работа
{
    public partial class Red : Window
    {
        public Red()
        {
            InitializeComponent();
            files();
        }
        private void Sw(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        string fun = "";
        string path = @"C:\Users\Admin\Desktop\proj\Курсовая работа\Func.txt";
        string[] str = new string[100];
        private void files()
        {
            str = File.ReadAllLines(path);
            list.Items.Clear();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                    list.Items.Add(str[i]);
            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                fun = In.Text;
                File.AppendAllText(path, fun);
                File.AppendAllText(path, Environment.NewLine);
                files();
                In.Text = "";
            }
        }
        private void but_Click(object sender, RoutedEventArgs e)
        {
            string arr = (string)list.SelectedItem;
            if (arr != null)
            {
                list.Items.CopyTo(str, 0);
                str[list.SelectedIndex] = "";
                File.Delete(path);
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != "")
                    {
                        File.AppendAllText(path, str[i]);
                        File.AppendAllText(path, Environment.NewLine);
                    }
                }
                files();
            }

        }
        private void inf(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sin - Синус\nCos - Косинус\nTan - Тангенс\nCtan - Котангенс\nExp - Експонента\nLog - Логорифм\nPor - Порабола\nGip - Гіпербола");
        }
    }
}