using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ColorTest
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
      {
         ChangeColor(); //Имитирует смену темы (Спустя 3 секнуды присвоит CBackg-50 другой цвет)
      }

      async void ChangeColor()
      {
         await Task.Delay(3000);
         Application.Current.Resources["CBackg-50"] = Color.FromRgb(255, 0, 0);
      }
   }
}