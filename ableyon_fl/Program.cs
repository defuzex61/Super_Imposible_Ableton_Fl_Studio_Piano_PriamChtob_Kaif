namespace ableyon_fl
{
    internal class Program
    {
        static void Main(string[] args)//Это просто ташкент какой-то, просто бред
        {
             Console.WriteLine("Почти фл студио ");
                Console.WriteLine("Выберите октаву f1 - f7, ноты почти как в флке ");
            
            do
            {
                ConsoleKeyInfo Octave = Console.ReadKey();
                switch (Octave.Key)
                {
                    case ConsoleKey.F1:

                        Console.WriteLine("Октава 0");
                        do
                        {
                            Octaves(1);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                    break;
                    case ConsoleKey.F2:
                        Console.WriteLine("Октава 1");
                        do
                        {
                            Octaves(2);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                   break;
                    case ConsoleKey.F3:
                        Console.WriteLine("Октава 2");
                        do
                        {
                            Octaves(2^2);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                   break;
                    case ConsoleKey.F4:
                        Console.WriteLine("Октава 3");
                        do
                        {
                            Octaves(2^3);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                   break;
                    case ConsoleKey.F5:
                        Console.WriteLine("Октава 4");
                        do
                        {
                            Octaves(2^4);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                        break;
                    case ConsoleKey.F6:
                        Console.WriteLine("Октава 5");
                        do
                        {
                            Octaves(2^5);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                        break;
                    case ConsoleKey.F7:
                        Console.WriteLine("Октава 6");
                        do
                        {
                            Octaves(2^6);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                        break;
                    case ConsoleKey.F8:
                        Console.WriteLine("Октава 7");
                        do
                        {
                            Octaves(2^7);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                        break;
                    case ConsoleKey.F9:
                        Console.WriteLine("Октава 8");
                        do
                        {
                            Octaves(2^8);
                        } while (Console.ReadKey().Key != ConsoleKey.Backspace);
                        Console.Clear();
                        Console.WriteLine("Вы вышли из октавы, для полного выхода нажмите enter ");
                        break;
                  
                }

            } while (Console.ReadKey().Key  != ConsoleKey.Enter);


        }
        static void Octaves(int pipka )
        {
            int[] Oktava = {  163, 173, 183, 194, 206, 218, 231, 245, 259, 275, 291, 308 };
                
            ConsoleKeyInfo nota =Console.ReadKey() ;
           
                    switch (nota.Key)
                    {
                        case ConsoleKey.Z:
                            Console.Beep(Oktava[0] * pipka, 300);
                            break;
                        case ConsoleKey.S:
                            Console.Beep(Oktava[2] * pipka, 300);
                            break;
                        case ConsoleKey.X:
                            Console.Beep(Oktava[3] * pipka, 300);
                            break;
                        case ConsoleKey.C:
                            Console.Beep(Oktava[4] * pipka, 300);
                            break;
                         case ConsoleKey.F:
                              Console.Beep(Oktava[5] * pipka, 300);
                             break;
                case ConsoleKey.V:
                    Console.Beep(Oktava[6] * pipka, 300);
                    break;
                case ConsoleKey.B:
                    Console.Beep(Oktava[7] * pipka, 300);
                    break;
                case ConsoleKey.H:
                    Console.Beep(Oktava[8] * pipka, 300);
                    break;
                case ConsoleKey.N:
                    Console.Beep(Oktava[9] * pipka, 300);
                    break;
                case ConsoleKey.K:
                    Console.Beep(Oktava[10] * pipka, 300);
                    break;
                case ConsoleKey.A:
                    Console.Beep(Oktava[11] * pipka, 300);
                    break;
                


            }


        }   
        

    }
}