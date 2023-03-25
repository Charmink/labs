namespace labs;

public class Program
{
    static void Main(string[] args)
    {
        IQueue<string> players = new MyQueue<string>();
        List<string> names = new List<string>(
            new [] { "Алиса", "Георгий", "Яков", "Валентина", "Елизавета", "Андрей" });

        foreach (var name in names)
        {
            players.Enqueue(name);
        }
        HotPotato game = new HotPotato(players);

        Random random = new Random();

        while (!game.GameOver)
        {
            int n = random.Next(1, 10);
            string playerOut = game.Play(n);
            
            Console.WriteLine(playerOut + " выбывает!");

        }
        Console.WriteLine("Победитель: " + game.Winner);
    }
}