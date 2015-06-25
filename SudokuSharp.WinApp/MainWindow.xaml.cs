using System.Windows;
using SudokuSharp.ViewModels;

namespace SudokuSharp.WinApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BoardViewModel _theBoard;

        public MainWindow()
        {
            InitializeComponent();
            _theBoard = new BoardViewModel();
            DataContext = _theBoard;
        }

        private void OnNew(object sender, RoutedEventArgs e)
        {
            _theBoard.NewPuzzle(SampleData.StarterPuzzles[0]);
         
            // Todo: Populate with random board
        }

        private void OnSolve(object sender, RoutedEventArgs e)
        {
            // Todo: Solve it
        }
    }
}
