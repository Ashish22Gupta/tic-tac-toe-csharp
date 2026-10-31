using System;
public class InsertDefaultValue{
    public void AddValue(char[,] board)
    {
        int i,j;
        
for (i=0;i<3;i++
)
        {
            for (j=0;j<3;j++)
            {
                board[i,j]='-';
            }
        }
    }
}

public class ShowMatrix{
    public void showboard(char[,] board)
    {
        int i,j;
        for(i=0;i<3;i++)
        {
            for (j=0;j<3;j++)
            {
                Console.Write("|"+board[i,j]);
            }
            Console.WriteLine("|");
        }
    }
}

public class UserInput{
    public void ShowUserInput(char[,] board,int user)
    {
        int row,col;
        row = (user-1)/3;
        col = (user-1)%3;
        board[row,col] = 'X';
    }
}

public class ComputerInput{
    public void ShowComputerInput(char[,] board,int computer)
    {
        int row,col;
        row=(computer-1)/3;
        col=(computer-1)%3;
        board[row,col]='O';
    }
}

public class RemainingSpaces{
    public int ShowSpaces(char[,] board,int[] RemainingPlaces)
    {
        int i,j,index=0;
        for(i=0;i<3;i++)
        {
            for (j=0;j<3;j++)
            {
                if (board[i,j]=='-')
                {
                    RemainingPlaces[index]=(i*3)+j+1;
                    index++;
                }
            }
        }
        for (i=0;i<index;i++)
        {
            Console.Write(RemainingPlaces[i]+" ");
        }
        return index;
    }
}

public class Winner
{
    public bool CheckWinner(char[,] board)
    {
        if ((board[0,0]=='X' && board[0,1]=='X' && board[0,2]=='X') ||
            (board[1,0]=='X' && board[1,1]=='X' && board[1,2]=='X') ||
            (board[2,0]=='X' && board[2,1]=='X' && board[2,2]=='X')){
            Console.WriteLine("*** You Win! Computer Loses! ***");
            return true;
        }

        if ((board[0,0]=='X' && board[1,0]=='X' && board[2,0]=='X') ||
            (board[0,1]=='X' && board[1,1]=='X' && board[2,1]=='X') ||
            (board[0,2]=='X' && board[1,2]=='X' && board[2,2]=='X')){
            Console.WriteLine("*** You Win! Computer Loses! ***");
            return true;
        }

        if ((board[0,0]=='X' && board[1,1]=='X' && board[2,2]=='X') ||
            (board[0,2]=='X' && board[1,1]=='X' && board[2,0]=='X')){
            Console.WriteLine("*** You Win! Computer Loses! ***");
            return true;
        }

        if ((board[0,0]=='O' && board[0,1]=='O' && board[0,2]=='O') ||
            (board[1,0]=='O' && board[1,1]=='O' && board[1,2]=='O') ||
            (board[2,0]=='O' && board[2,1]=='O' && board[2,2]=='O')){
            Console.WriteLine("*** Computer Wins! You Lose! ***");
            return true;
        }

        if ((board[0,0]=='O' && board[1,0]=='O' && board[2,0]=='O') ||
            (board[0,1]=='O' && board[1,1]=='O' && board[2,1]=='O') ||
            (board[0,2]=='O' && board[1,2]=='O' && board[2,2]=='O')){
            Console.WriteLine("*** Computer Wins! You Lose! ***");
            return true;
        }

        if ((board[0,0]=='O' && board[1,1]=='O' && board[2,2]=='O') ||
            (board[0,2]=='O' && board[1,1]=='O' && board[2,0]=='O')){
            Console.WriteLine("*** Computer Wins! You Lose! ***");
            return true;
        }
        return false;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rand = new Random();

        char[,] board = new char[3, 3
];
        int[] RemainingPlaces = new int[9];

        InsertDefaultValue DefultValue = new InsertDefaultValue();
        DefultValue.AddValue(board);

        ShowMatrix boardplaces = new ShowMatrix();
        RemainingSpaces EmptySpaces = new RemainingSpaces();
        UserInput UserSelection = new UserInput();
        ComputerInput ComputerSelection = new ComputerInput();
        Winner gameChecker = new Winner(); 

        Console.WriteLine("Current Empty Places");
        boardplaces.showboard(board);

        int moves = 0;
        bool userTurn = true;
        bool gameOver = false;

        while (moves < 9 && !gameOver)
        {
            if (userTurn)
            {
                int user;
                while (true)
                {
                    int row,col;
                    Console.Write("\nSelect the place between:- ");
                    EmptySpaces.ShowSpaces(board, RemainingPlaces);
                    Console.Write("\n\nSelected Place:- ");

                    string input = Console.ReadLine();
                    Console.WriteLine();
                    if (!int.TryParse(input, out user) || user < 1 || user > 9)
                    {
                        Console.Write("||--- You Must Select Place Between ");
                        EmptySpaces.ShowSpaces(board, RemainingPlaces);
                        Console.Write("---||\n");
                        continue;
                    }

                    row = (user - 1) / 3;
                    col = (user - 1) % 3;

                    if (board[row, col] != '-')
                    {
                        Console.WriteLine("That place is already filled. Choose another.");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("Your Selected Place:- " + user);
                UserSelection.ShowUserInput(board, user);

                moves++;
                boardplaces.showboard(board);
                if (gameChecker.CheckWinner(board))
                {
                    gameOver = true;
                    break; 
                }
                userTurn = false;
            }
            else
            {
                Console.Write("\nRemaining Places:- ");
                int remainingCount = EmptySpaces.ShowSpaces(board, RemainingPlaces);

                if (remainingCount == 0)
                {
                    break;
                }

                int computer = RemainingPlaces[rand.Next(remainingCount)];

                Console.WriteLine("\nComputer Selected Place:- " + computer);
                ComputerSelection.ShowComputerInput(board, computer);

                moves++;
                boardplaces.showboard(board);
                if (gameChecker.CheckWinner(board))
                {
                    gameOver = true;
                    break;
                }
                userTurn = true;
            }

            if (!gameOver && moves == 9)
            {
                Console.WriteLine("\n*** It's A Draw! ***");
            }
        }
    }
}
