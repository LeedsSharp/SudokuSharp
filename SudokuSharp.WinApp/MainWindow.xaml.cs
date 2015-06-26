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
        private int?[,] _currentPuzzle;

        public MainWindow()
        {
            InitializeComponent();
            _theBoard = new BoardViewModel();
            DataContext = _theBoard;
            SetRandomPuzzle();
        }

        private void OnNew(object sender, RoutedEventArgs e)
        {
            SetRandomPuzzle();
        }

        private void OnSolve(object sender, RoutedEventArgs e)
        {
            // Todo: Solve it
        }

        private void SetRandomPuzzle()
        {
            _currentPuzzle = SampleData.GetRandomPuzzle();
            _theBoard.NewPuzzle(_currentPuzzle);
        }
    }
}
