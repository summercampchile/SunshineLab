using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace _247
{
    class DialogBox
    {
        public DialogBox()
        {
            // Create the Canvas
            Canvas myCanvas = new Canvas();

            myCanvas.Width = 400;
            myCanvas.Height = 400;

            // Create the child Button elements
            Button myButton1 = new Button();
            Button myButton2 = new Button();
            Button myButton3 = new Button();
            Button myButton4 = new Button();

            // Set Positioning attached properties on Button elements
            Canvas.SetTop(myButton1, 50);
            myButton1.Content = "Canvas.Top=50";
            Canvas.SetTop(myButton2, 100);
            myButton2.Content = "Canvas.Bottom=50";
            Canvas.SetLeft(myButton3, 50);
            myButton3.Content = "Canvas.Left=50";
            Canvas.SetLeft(myButton4, 50);
            myButton4.Content = "Canvas.Right=50";


            // Add Buttons to the Canvas' Children collection
            myCanvas.Children.Add(myButton1);
            myCanvas.Children.Add(myButton2);
            myCanvas.Children.Add(myButton3);
            myCanvas.Children.Add(myButton4);
            
           
        }
    }
}
