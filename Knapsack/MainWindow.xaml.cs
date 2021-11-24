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
            List<items> itlest= new List<items>();
            items temp;


            for(int y=0; y<x.Length;y++)
            {

                for(int q = 0; q< x[y];q++)
                {

                    switch(y)
                    {
                        case 0:
                            temp = new items(1);
                            itlest.Add(temp);
                             break;

                        case 1:
                            temp = new items(5);
                            itlest.Add(temp);
                            break;
                        case 2:
                            temp = new items(10);
                            itlest.Add(temp);
                            break;
                        case 3:
                            temp = new items(15);
                            itlest.Add(temp);
                            break;
                        case 4:
                            temp = new items(20);
                            itlest.Add(temp);
                            break;
                        case 5:
                            temp = new items(25);
                            itlest.Add(temp);
                            break;
                    }

                }
            }




        }
    }
}
