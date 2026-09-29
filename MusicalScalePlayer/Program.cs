namespace MusicalScalePlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MusicPlayer player = new MusicPlayer();


            while (true)
            {
                Console.WriteLine("1. Play all notes\n" +
                    "2. Play list of given notes\n" +
                    "3. Get input from user\n" +
                    "4. Exit");
                _ = int.TryParse(Console.ReadLine(), out int option);
                switch (option)
                {
                    case 1:
                        player.PlayAllNotes();
                        break;

                    case 2:
                        player.PlayAllNotes();
                        break;

                    case 3:
                        player.GetInput();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Enter a valid option");
                        continue;
                }
            }
        }
    }
}
