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
using System.IO;

namespace lab_106_game_increase_score_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            start();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("file.txt", $"{Name.Text}{Environment.NewLine}{Score.Text} {Environment.NewLine}{Level.Text}");

        }

        private void start()
        {
           Name.Text = File.ReadAllLines("file.txt")[0];
           Score.Text = File.ReadAllLines("file.txt")[1];
           Level.Text = File.ReadAllLines("file.txt")[2];

        }

        private void PlusScore_Click(object sender, RoutedEventArgs e)
        {
            int score = Convert.ToInt32(Score.Text);
            score++;
            Score.Text = score.ToString();
                
        }

        private void MinScore_Click(object sender, RoutedEventArgs e)
        {
            int score = Convert.ToInt32(Score.Text);
            score--;
            Score.Text = score.ToString();
        }




        //Create a GAMING HOME PAGE
        //Name of gamer (saved to text file)
        //Level reached (stored to text file) 
        //Top score
        //Prize for BEST PRESENTED INTERFACE

        //Next iteration : add an up/down button to increase the score

    }
}
