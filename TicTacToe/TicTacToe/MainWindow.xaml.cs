using System.Windows;
using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;


namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Private Members

        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private MarkType[] mResults;

        /// <summary>
        /// True if it is Player 1's turn (X) or player 2's turn (O)
        /// </summary>
        private bool mPlayer1Turn;


        /// <summary>
        /// True if game has ended
        /// </summary>
        private bool mGameEnded;

        #endregion

        #region Contructor 

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        #endregion
        /// <summary>
        /// Starts a new game and clears all values back to the start
        /// </summary>
        private void NewGame()
        {
            // Create a new blank array of free cells
            mResults = new MarkType[9];

            // Setting for free for every new class instances
            for (var i = 0; i < mResults.Length; i++)
            {
                mResults[i] = MarkType.Free;
            }

            // Make sure it's player 1 
            mPlayer1Turn = true;

            // Interate Every Button on the grid...
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                //lamdba expression change background, foregournd and content to deafult values
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;


            });


            // Make sure the game hasn't finished
            mGameEnded = false;

        }
        /// <summary>
        /// Handles a button click event
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The events of the click</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Start a new game on the click after it finished
            if (mGameEnded)
            {
                NewGame();
                return;
            }

            // Cast the sender to a button
            var button = (Button)sender;

            // Find the buttons position in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            // Don't do anything if the cell already has a value in it
            if (mResults[index] != MarkType.Free)
            {
                return;
            }

            // Set the cell value based on which players turn it is
            mResults[index] = mPlayer1Turn ? MarkType.Cross : MarkType.Nought;

            button.Content = mPlayer1Turn ? "X" : "O";


            if (!mPlayer1Turn)
                button.Foreground = Brushes.Red;
            //if (mPlayer1Turn)
            //  mResults[index] = MarkType.Cross;
            //else
            //  mResults[index] = MarkType.Nought;

            //if (mPlayer1Turn)
             //   mPlayer1Turn = false;
            //else
             //   mPlayer1Turn = true;
             // toggles the players turn
            mPlayer1Turn ^= true;


            // Check for a winner
            CheckForWinner();



        }

        private void CheckForWinner()
        {
            // Check for horizontal wins
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0]) {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
            }


            // Check for horizontal wins
            if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
            }

            // Check for horizontal wins
            if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
            }


            // Check for vertical Wins
            // column 0

            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }

            // column 1
            if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }


            // column 2
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }


            // Check for cric-cross wins
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
            }

            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                mGameEnded = true;

                // Highlight winning cells in gree
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;
            }



            // Check for no wingger and full board
            if (!mResults.Any(result => result == MarkType.Free))
            {
                mGameEnded = true;

                // Turn all cells organe
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;

                });
            }

        }
    }
}