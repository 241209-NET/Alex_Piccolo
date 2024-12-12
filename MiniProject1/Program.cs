namespace MiniProject1;

class Program
{
    static void Main(string[] args)
    {

        List<string> movieList = []; 
        Boolean isEnd = false; 

        while(isEnd == false){


            Console.WriteLine("Enter a menu selection (int value): ");
            Console.WriteLine("1. Add A New Movie To Your Watch List"); 
            Console.WriteLine("2. Remove a Movie From Your Watch List"); 
            Console.WriteLine("3. List All Movies In Your Watch List"); 

            string? input = Console.ReadLine(); 
            

            try
            {
                int num = int.Parse(input!); 

                switch(num){
                    case 1: 
                        Console.WriteLine("Enter The Name Of The Movie To Add: ");
                        string? newMovie = Console.ReadLine() ?? "Null";
                        movieList.Add(newMovie); 
                        break; 
                    case 2: 
                    Console.WriteLine("Enter The Name Of The Movie To Delete (Must Match Exactly): ");
                        string? deleteMovie = Console.ReadLine() ?? "Null";
                        movieList.Remove(deleteMovie); 
                        break; 
                    case 3: 
                        foreach(string movie in movieList){
                            Console.WriteLine(movie); 
                        }
                        break; 
                    default: 
                        Console.WriteLine("Menu Selection Not Recognized"); 
                        break; 
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected Input"); 
                Console.WriteLine(e.GetType()); 
            }


            //Ask if the user wants to continue or should end the program
            Console.WriteLine("Would you like to continue using your movie list?"); 
            Console.WriteLine("Enter 'yes' to continue, or anything else to end"); 

            string? inputEnd = Console.ReadLine(); 
            if(inputEnd != "yes"){
                isEnd = true; 
            }



        }//end of while loop
    }
}
