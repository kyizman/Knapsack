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
using System.Collections;

using MahApps.Metro.Controls;

namespace Knapsack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchBT_Click(object sender, RoutedEventArgs e)
        {

           


            int[] x = new int[] { int.Parse(KG1.Text), int.Parse(KG5.Text), int.Parse(KG10.Text), int.Parse(KG15.Text), int.Parse(KG20.Text),int.Parse(KG25.Text) };
            ArrayList itlest = new();
           


            Random ss = new Random();
            for (int y = 0; y < 30; y++)
            {
                items temp= new items(ss.Next(1,10),ss.Next(1,20));
                itlest.Add(temp);


            }

            Genetic gen = new Genetic();
            gen.KnapsackProblem(itlest, 30);

            for (int y=0; y<x.Length;y++)
            {

                for(int q = 0; q< x[y];q++)
                {

                    
                }
            }




        }
    }
}
