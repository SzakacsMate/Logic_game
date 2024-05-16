using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Logic_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sor = 3, oszlop= 3;
        int[,] m;
        int kor = 0;

        

        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        public void MatrixGen()
        {
            m = new int[sor, oszlop];

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    m[i, j] = 0;
                }
            }
        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {

            
            Játékrész.RowDefinitions.Clear();
            Játékrész.ColumnDefinitions.Clear();
            Játékrész.Children.Clear();
            kor = 0;
            for (int i = 0; i < sor; i++)
            {
                Játékrész.RowDefinitions.Add(new RowDefinition());
            }
            
            for (int i = 0; i < sor; i++)
            {
                Játékrész.ColumnDefinitions.Add(new ColumnDefinition());
                for (int j = 0; j < oszlop; j++)
                {
                    Button b = new();
                    b.HorizontalAlignment = HorizontalAlignment.Stretch;
                    b.VerticalAlignment = VerticalAlignment.Stretch;
                    b.Click += Lerakás_Click;
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    Játékrész.Children.Add(b);
                }
            }
            MatrixGen();
            
        }

        public ImageBrush getImage(int kor)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            if (kor %2==0)
                bitmap.UriSource = new Uri("pack://application:,,,/cross.png");
            else
                bitmap.UriSource = new Uri("pack://application:,,,/circle.png");
            bitmap.EndInit();
            ImageBrush imgBrush = new ImageBrush(bitmap);
            return imgBrush;
        }


        private void Lerakás_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            int sorSz = Grid.GetRow(b);
            int oszlopSz = Grid.GetColumn(b);
            
            
            if (m[sorSz, oszlopSz] == 0 && kor%2==0) 
            {
                b.Background = getImage(kor);
                m[sorSz, oszlopSz] = 1;
                kor++;
            }
            else if (m[sorSz, oszlopSz] == 0 && kor % 2 != 0)
            {
                b.Background = getImage(kor);
                m[sorSz, oszlopSz] = 2;
                kor++;
            }
            EllenorzesX();
            EllenorzesO();

        }
        public void EllenorzesX()
        {
            if (m[0, 0] == 1 && m[0,1]==1 && m[0,2]==1)
            {
                MessageBox.Show("X nyert");
            }
            else if (m[1, 0] == 1 && m[1, 1] == 1 && m[1, 2] == 1)
            {
                MessageBox.Show("X nyert");
            }
            else if (m[2, 0] == 1 && m[2, 1] == 1 && m[2, 2] == 1)
            {
                MessageBox.Show("X nyert");
            }
            else if (m[0, 0] == 1 && m[1, 1] == 1 && m[2, 2] == 1)
            {
                MessageBox.Show("X nyert");
            }
            else if (m[2, 0] == 1 && m[1, 1] == 1 && m[0, 2] == 1)
            {
                MessageBox.Show("X nyert");
            }
            else if (m[0, 0] == 1 && m[1, 0] == 1 && m[2, 0] == 1)
            {
                MessageBox.Show("X nyert");
            }
            else if (m[0, 1] == 1 && m[1, 1] == 1 && m[2, 1] == 1)
            {
                MessageBox.Show("X nyert");
            }
            else if (m[0, 2] == 1 && m[1, 2] == 1 && m[2, 2] == 1)
            {
                MessageBox.Show("X nyert");
            }
        }
        public void EllenorzesO()
        {
            if (m[0, 0] == 2 && m[0, 1] == 2 && m[0, 2] == 2)
            {
                MessageBox.Show("O nyert");
            }
            else if (m[1, 0] == 2 && m[1, 1] == 2 && m[1, 2] == 2)
            {
                MessageBox.Show("O nyert");
            }
            else if (m[2, 0] == 2 && m[2, 1] == 2 && m[2, 2] == 2)
            {
                MessageBox.Show("O nyert");
            }
            else if (m[0, 0] == 2 && m[1, 1] == 2 && m[2, 2] == 2)
            {
                MessageBox.Show("O nyert");
            }
            else if (m[2, 0] == 2 && m[1, 1] == 2 && m[0, 2] == 2)
            {
                MessageBox.Show("O nyert");
            }
            else if (m[0, 0] == 2 && m[1, 0] == 2 && m[2, 0] == 2)
            {
                MessageBox.Show("O nyert");
            }
            else if (m[0, 1] == 2 && m[1, 1] == 2 && m[2, 1] == 2)
            {
                MessageBox.Show("O nyert");
            }
            else if (m[0, 2] == 2 && m[1, 2] == 2 && m[2, 2] == 2)
            {
                MessageBox.Show("O nyert");
            }
        }


    }
}