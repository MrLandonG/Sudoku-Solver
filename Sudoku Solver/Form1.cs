using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    public partial class mForm : Form
    {

        // Sample Sudoku puzzle
        private static int[,] mPuzzle =
        {
            {9, 0, 0, 1, 0, 0, 0, 0, 5},
            {0, 0, 5, 0, 9, 0, 2, 0, 1},
            {8, 0, 0, 0, 4, 0, 0, 0, 0},
            {0, 0, 0, 0, 8, 0, 0, 0, 0},
            {0, 0, 0, 7, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 2, 6, 0, 0, 9},
            {2, 0, 0, 3, 0, 0, 0, 0, 6},
            {0, 0, 0, 2, 0, 0, 9, 0, 0},
            {0, 0, 1, 9, 0, 4, 5, 7, 0}
        };

        public mForm()
        {
            InitializeComponent();
            DrawBoard();
        }

        private void DrawBoard()
        {
            mTableLayoutPanel.ColumnCount = mPuzzle.GetLength(1);

            for (int i = 0; i < mPuzzle.GetLength(0); i++)
            {
                for (int j = 0; j < mPuzzle.GetLength(1); j++)
                {
                    // Programically creates custom labels
                    TextBox mTextBox = new TextBox
                    {
                        BorderStyle = BorderStyle.Fixed3D,
                        Height = 60,
                        Width = 60,
                        Multiline = true,
                        TextAlign = HorizontalAlignment.Center,
                        Font = new Font("Arial", 36)
                    };

                    // Turns zero's from the sample puzzle into blanks and non-zero's are set as label text
                    if (mPuzzle[i, j] != 0)
                    {
                        mTextBox.Text = mPuzzle[i, j].ToString();
                        mTextBox.BackColor = Color.FromArgb(145, 237, 114);
                        mTextBox.Enabled = false;
                    }

                    // Adds labels to tablelayoutpanel
                    mTableLayoutPanel.Controls.Add(mTextBox);
                }
            }
        }

        private void mButtonSolve_Click(object sender, EventArgs e)
        {
            Solve();
        }

        private bool Solve()
        {
            // Iterate through the entire grid looking for an empty (0) cell
            for (int i = 0; i < mPuzzle.GetLength(0); i++)
            {
                for (int j = 0; j < mPuzzle.GetLength(1); j++)
                {
                    // Checks if the cell is empty
                    if (mPuzzle[i, j] == 0)
                    {
                        // Try possible numbers
                        for (int number = 1; number <= 9; number++)
                        {
                            // Checks if the possible number appears in row, column, or region
                            if (Verify(mPuzzle, i, j, number))
                            {
                                mPuzzle[i, j] = number;
                                mTableLayoutPanel.GetControlFromPosition(j, i).Text = number.ToString();
                                mTableLayoutPanel.GetControlFromPosition(j, i).BackColor = Color.FromArgb(237, 235, 114);

                                // Backtracks
                                if (Solve())
                                {
                                    return true;
                                }

                                else
                                {
                                    mPuzzle[i, j] = 0;
                                    mTableLayoutPanel.GetControlFromPosition(j, i).Text = 0.ToString();
                                    mTableLayoutPanel.GetControlFromPosition(j, i).BackColor = Color.FromArgb(186, 82, 82);
                                }

                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        // A possible number is one which doesn't appear in it's row, column, or region
        private bool Verify(int[,] mPuzzle, int mRows, int mColumns, int number)
        {
            return CheckRow(mRows, number) && CheckColumn(mColumns, number) && CheckRegion(mRows, mColumns, number);
        }

        // Checks if the possible number appears in the same row
        private bool CheckRow(int mRows, int number)
        {
            for (int i = 0; i < mPuzzle.GetLength(0); i++)
            {
                if (mPuzzle[mRows, i] == number)
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if the possible number appears in the same column
        private bool CheckColumn(int mColumns, int number)
        {
            for (int i = 0; i < mPuzzle.GetLength(1); i++)
            {
                if (mPuzzle[i, mColumns] == number)
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if the possible number appears in the same region
        private bool CheckRegion(int mRows, int mColumns, int number)
        {

            int RegionRow = mRows - mRows % 3;
            int RegionColumn = mColumns - mColumns % 3;

            for (int i = RegionRow; i < (RegionRow + 3); i++)
            {
                for (int j = RegionColumn; j < (RegionColumn + 3); j++)
                {
                    if (mPuzzle[i, j] == number)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
