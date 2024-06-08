using System;

namespace SnakeAndLadder{
    
    class Player{
        
        public int Ladder1 = 3;
        public int Ladder2 = 8;
        public int Ladder3 = 28;
        public int Ladder4 = 58;
        public int Ladder5 = 75;
        public int Ladder6 = 80;
        public int Ladder7 = 90;
            
        public int Snake1 = 17;
        public int Snake2 = 52;
        public int Snake3 = 57;
        public int Snake4 = 62;
        public int Snake5 = 88;
        public int Snake6 = 95;
        public int Snake7 = 97;
        
        public string name;
        
        public int position = 0;
        public int score = 0;
        public int generatedNumber;
        
        public void setName(){
            Console.Write("Enter Player1 Name: ");
            name = Console.ReadLine();
        }
        
        
        public void throwDice(){
            Random rnd = new Random();
            generatedNumber = rnd.Next(1,6);
            Console.WriteLine("It is "+generatedNumber);
        }
        
        public void updateScore(){
            score += generatedNumber;
        }
        
        public void checkForLadderAndSnake(){
            if(score==Ladder1){
                Console.WriteLine("Hurry! You have taken Ladder1 and reached 21");
                score = 21;
            }
            else if(score==Ladder2){
                Console.WriteLine("Hurry! You have taken Ladder2 and reached 30");
                score = 30;
            }
            else if(score==Ladder3){
                Console.WriteLine("Hurry! You have taken Ladder3 and reached 84");
                score = 84;
            }
            else if(score==Ladder4){
                Console.WriteLine("Hurry! You have taken Ladder4 and reached 77");
                score = 77;
            }
            else if(score==Ladder5){
                Console.WriteLine("Hurry! You have taken Ladder5 and reached 86");
                score = 86;
            }
            else if(score==Ladder6){
                Console.WriteLine("Hurry! You have taken Ladder6 and reached Finish Line");
                score = 100;
            }
            else if(score==Ladder7){
                Console.WriteLine("Hurry! You have taken Ladder7 and reached 91");
                score = 91;
            }
            else if(score==Snake1){
                Console.WriteLine("OOPS! You got bitten by Snake1 and fallen to 13");
                score = 13;
            }
            else if(score==Snake2){
                Console.WriteLine("OOPS! You got bitten by Snake2 and fallen to 29");
                score = 29;
            }
            else if(score==Snake3){
                Console.WriteLine("OOPS! You got bitten by Snake3 and fallen to 40");
                score = 40;
            }
            else if(score==Snake4){
                Console.WriteLine("OOPS! You got bitten by Snake4 and fallen to 22");
                score = 22;
            }
            else if(score==Snake5){
                Console.WriteLine("OOPS! You got bitten by Snake5 and fallen to 18");
                score = 18;
            }
            else if(score==Snake6){
                Console.WriteLine("OOPS! You got bitten by Snake6 and fallen to 51");
                score = 51;
            }
            else if(score==Snake7){
                Console.WriteLine("OOPS! You got bitten by Snake7 and fallen to 79");
                score = 79;
            }
        }
        
    }
    
    class Game{
            
        string mode;
        
        Player Player1,Player2,Player3,Player4;
        
        public bool isGameOver(){
            if(mode=="2player"){
                if(Player1.score==100 || Player2.score==100){
                    return true;
                }
                else{
                    return false;
                }
            }
            else{
                if((Player1.score==100 && Player2.score==100 && Player3.score==100 && Player4.score!=100) ||
                (Player1.score==100 && Player2.score==100 && Player3.score!=100 && Player4.score==100) ||
                (Player1.score==100 && Player2.score!=100 && Player3.score==100 && Player4.score==100) || 
                (Player1.score!=100 && Player2.score==100 && Player3.score==100 && Player4.score==100)){
                    return true;
                }
                else{
                    return false;
                }
            }
        }
        
        public Game(Player P1,Player P2,string mode){
            Player1 = P1;
            Player2 = P2;
            this.mode = mode;
        }
        
        public Game(Player P1,Player P2,Player P3,Player P4,string mode){
            Player1 = P1;
            Player2 = P2;
            Player3 = P3;
            Player4 = P4;
            this.mode = mode;
        }
        
        
        public void printBoard(){
            for(int i=0;i<21;i++){
                for(int j=0;j<31;j++){
                    if(i%2==1 && j%3==0){
                        Console.Write("|      ");
                    }
                    else if(i%2==0 && j%3==0){
                        Console.Write("+");
                    }
                    else if(i%2==0){
                        Console.Write("---");
                    }
                }
                Console.WriteLine();
            }
        }
        
        public void startGame(){
            
            while(true){
                Console.Write("Player 1 roll the dice, enter any character: ");
                Console.ReadLine();
                Player1.throwDice();
                Player1.updateScore();
                Player1.checkForLadderAndSnake();
                if(Player1.generatedNumber==6){
                    Console.Write("Lucky it's 6 you got another chance!");
                    Console.Write("Player 1 roll the dice, enter any character: ");
                    Console.ReadLine();
                    Player1.throwDice();
                    Player1.updateScore();
                    Player1.checkForLadderAndSnake();
                
                }
                // printBoard();
                if(isGameOver()){
                        break;
                }
                
                Console.Write("Player 2 roll the dice, enter any character: ");
                Console.ReadLine();
                Player2.throwDice();
                Player2.updateScore();
                Player2.checkForLadderAndSnake();
                if(Player2.generatedNumber==6){
                    Console.Write("Lucky it's 6 you got another chance!");
                    Console.Write("Player 2 roll the dice, enter any character: ");
                    Console.ReadLine();
                    Player2.throwDice();
                    Player2.updateScore();
                    Player2.checkForLadderAndSnake();
                }
                // printBoard();
                if(isGameOver()){
                    break;
                }
                if(mode=="4player"){
                    Console.Write("Player 3 roll the dice, enter any character: ");
                    Console.ReadLine();
                    Player3.throwDice();
                    Player3.updateScore();
                    Player3.checkForLadderAndSnake();
                    printBoard();
                    if(Player3.generatedNumber==6){
                    Console.Write("Lucky it's 6 you got another chance!");
                    Console.Write("Player 3 roll the dice, enter any character: ");
                    Console.ReadLine();
                    Player3.throwDice();
                    Player3.updateScore();
                    Player3.checkForLadderAndSnake();
                
                }
                    if(isGameOver()){
                        break;
                    }
                    Console.Write("Player 4 roll the dice, enter any character: ");
                    Console.ReadLine();
                    Player4.throwDice();
                    Player4.updateScore();
                    Player4.checkForLadderAndSnake();
                    printBoard();
                    if(Player4.generatedNumber==6){
                    Console.Write("Lucky it's 6 you got another chance!");
                    Console.Write("Player 1 roll the dice, enter any character: ");
                    Console.ReadLine();
                    Player4.throwDice();
                    Player4.updateScore();
                    Player4.checkForLadderAndSnake();
                
                }
                    if(isGameOver()){
                        break;
                    }
                }
            }
        }
    }

    
    class main{
        
        static void Main(){
            
            string mode;
            
            Console.Write("Select your game mode: \n1.2player\n2.4player\n");
            string s = Console.ReadLine();
            mode = s;
            if(mode =="2player"){
               Player P1 = new Player();
               Player P2 = new Player();
               Game g = new Game(P1,P2,mode);
               g.startGame();
            }
            else{
                Player P1 = new Player();
                Player P2 = new Player();
                Player P3 = new Player();
                Player P4 = new Player();
                Game g = new Game(P1,P2,P3,P4,mode);
                g.startGame();
            }
            
            
    }
}

}
