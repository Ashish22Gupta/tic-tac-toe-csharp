using System;
public class HelloWorld {
    
    public static void Main(string[] args) {
        Random rand = new Random();

        char[,] board = new char[3,3];
        int steps = 1, i, j;

        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                board[i,j] = '-';
            }
        }

        Console.WriteLine("Current Empty Places");

        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                Console.Write("|"+board[i,j]);
            }
            Console.Write("|");
            Console.WriteLine();
        }

        Console.WriteLine();

        while(steps <= 9){
            int user, computer;
            bool flag = true;
            Console.WriteLine("Select the place between 1 to 9");
            Console.WriteLine();
            
            Console.Write("Enter Selected Place:- ");
            if(!int.TryParse(Console.ReadLine(), out user) || user<=0 || user>=9){
                flag = false;
                while(flag == false){
                    Console.WriteLine();
                    Console.WriteLine("You Must Select between 1 to 9!");
                    Console.Write("Selected Postion Again:- ");
                    if (!int.TryParse(Console.ReadLine(), out user) || user<=0 || user>=9){
                        flag = true;
                    }
                    break;
                }
            }

            Console.WriteLine("Your Selected Place:- "+user);
            steps++;

            if(user == 1){
                board[0,0] = 'X';
            }else if(user == 2){
                board[0,1] = 'X';
            }else if(user == 3){
                board[0,2] = 'X';
            }else if(user == 4){
                board[1,0] = 'X';
            }else if(user == 5){
                board[1,1] = 'X';
            }else if(user == 6){
                board[1,2] = 'X';
            }else if(user == 7){
                board[2,0] = 'X';
            }else if(user == 8){
                board[2,1] = 'X';
            }else if(user == 9){
                board[2,2] = 'X';
            }

            for(i=0;i<3;i++){
                for(j=0;j<3;j++){
                    Console.Write(board[i,j]+" ");
                }
                Console.WriteLine();
            }
    
            Console.WriteLine();
    
            computer = rand.Next(1, 10);
            Console.WriteLine("Computer Selected Place:- "+computer);
            steps++;   
        }
    }
}
