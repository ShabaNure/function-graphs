using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;




namespace Курсовая_работа
{
    public partial class MainWindow : Window
    {
        private void Sw(object sender, RoutedEventArgs e)
        {
            Red mainWindow = new Red();
            mainWindow.Show();
            this.Close();
        }
        int num;
        string fun = "";
        string path = @"C:\Users\Admin\Desktop\proj\Курсовая работа\Func.txt";
        string[] str = new string[100];
        double[,] points = new double[1000, 2];
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
        private void list_Selected(object sender, RoutedEventArgs e)
        {
            fun = (string)list.SelectedItem;
            num = (int)list.SelectedIndex;
            sort();
        }
        private void lines()
        {
            image.Children.Clear();
            Line Vert = new Line();
            Vert.X1 = 125;
            Vert.Y1 = 0;
            Vert.X2 = 125;
            Vert.Y2 = 240;
            Vert.Stroke = Brushes.Black;
            image.Children.Add(Vert);
            Line Hor = new Line();
            Hor.X1 = 0;
            Hor.Y1 = 119;
            Hor.X2 = 240;
            Hor.Y2 = 119;
            Hor.Stroke = Brushes.Black;
            image.Children.Add(Hor);
        }
        private void func(int k)
        {
            image.Children.Clear();
            lines();
            for (int i = 0; i < 999; i++)
            {
                if (points[i, 0] >= 110 || points[i, 0] <= -125)
                    continue;
                Line ln = new Line();
                string buf = str[num];
                if (buf.Contains("Tan") || buf.Contains("Ctan"))
                {
                    if (points[i, 1] >= 120 || points[i, 1] <= -60)
                        continue;
                }
                ln.X1 = points[i, 0] + 125;
                ln.Y1 = points[i, 1] + 119;
                ln.X2 = points[i + 1, 0] + 125;
                ln.Y2 = points[i + 1, 1] + 119;
                ln.Stroke = Brushes.Black;
                image.Children.Add(ln);
            }
        }
        private void Sin(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }
            double j = -15;
            for (int i = 0; i < 1000 && j < 50; i++, j += 0.05)
            {
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 * Math.Sin(j * k);
            }
            func(k);

        }
        private void Cos(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }

            double j = -15;
            for (int i = 0; i < 1000 && j < 100; i++, j += 0.05)
            {
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 * Math.Cos(j * k);
            }
            func(k);

        }
        private void Tan(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }

            double j = -15;
            for (int i = 0; i < 1000 && j < 50; i++, j += 0.02)
            {
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 * Math.Tan(Math.PI * j * k);
            }
            func(k);

        }
        private void Ctan(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }

            double j = -15;
            for (int i = 0; i < 1000 && j < 50; i++, j += 0.02)
            {
                if (Math.Tan(j) == 0)
                    continue;
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 / Math.Tan(Math.PI * j * k);
            }
            func(k);

        }
        private void Exp(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }

            double j = -15;
            for (int i = 0; i < 1000 && j < 50; i++, j += 0.05)
            {
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 * Math.Exp(j * k);
            }
            func(k);

        }
        private void Log(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }

            double j = 0.1;
            for (int i = 0; i < 1000 && j < 50; i++, j += 0.05)
            {
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 * Math.Log(j * k);
            }
            func(k);

        }
        private void Por(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }

            double j = -15;
            for (int i = 0; i < 1000 && j < 50; i++, j += 0.05)
            {
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 * Math.Pow(j * k, 2);
            }
            func(k);

        }
        private void Gip(int k)
        {
            for (int i = 0; i < 1000; i++)
            {
                points[i, 0] = 0;
                points[i, 1] = 0;
            }

            double j = -15;
            for (int i = 0; i < 1000 && j < 100; i++, j += 0.05)
            {
                if (j == 0)
                {
                    j = 0.1;
                    continue;
                }
                points[i, 0] = 20 * (j);
                points[i, 1] = -20 / (j * k);
            }
            func(k);

        }
        private void sort()
        {
            int ind = 0;
            if (str[num].Contains("Sin"))
            {
                string buf = str[num];
                buf = buf.Substring(4);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Sin(ind);
            }
            else if (str[num].Contains("Cos"))
            {
                string buf = str[num];
                buf = buf.Substring(4);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Cos(ind);
            }
            else if (str[num].Contains("Tan"))
            {
                string buf = str[num];
                buf = buf.Substring(4);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Tan(ind);

            }
            else if (str[num].Contains("Ctan"))
            {
                string buf = str[num];
                buf = buf.Substring(5);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Ctan(ind);
            }
            else if (str[num].Contains("Exp"))
            {
                string buf = str[num];
                buf = buf.Substring(4);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Exp(ind);
            }
            else if (str[num].Contains("Log"))
            {
                string buf = str[num];
                buf = buf.Substring(4);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Log(ind);
            }
            else if (str[num].Contains("Por"))
            {
                string buf = str[num];
                buf = buf.Substring(4);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Por(ind);
            }
            else if (str[num].Contains("Gip"))
            {
                string buf = str[num];
                buf = buf.Substring(4);
                ind = buf.IndexOf("*");
                buf = buf.Substring(0, ind);
                ind = int.Parse(buf);
                Gip(ind);
            }
            else
            {
                lines();
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            lines();
            files();
        }
    }
}
