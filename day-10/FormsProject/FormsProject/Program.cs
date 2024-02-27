using System.Windows.Forms;

namespace FormsProject {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Forms!");
            // Had to add the following to project:
            // < TargetFramework > net8.0 - windows </ TargetFramework >
            // < UseWindowsForms > true </ UseWindowsForms >

            Form myForm = new Form();

            Button okButton = new Button();
            okButton.Text = "OK";
            myForm.Controls.Add(okButton);
            myForm.ShowDialog(); 
        }
    }
}
