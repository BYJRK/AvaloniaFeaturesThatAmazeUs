using Avalonia.Controls;

namespace AvaloniaFeaturesThatAmazeUs.Basics
{
    public partial class MainWindow : Window
    {
        public string[] Animals { get; } =
            new[] { "Cat", "Dog", "Pig", "Cow", "Chicken", "Horse", "Sheep", "Goat", "Duck", };

        public MainWindow()
        {
            InitializeComponent();
            
            // 这是一段注释
        }
    }
}
