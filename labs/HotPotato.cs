using labs;

public class HotPotato
{
    private IQueue<string> players;

    public HotPotato(IQueue<string> players)
    {
        this.players = players;
    }

    public string Play(int n)
    {
        for (int i = 1; i < n; i++)
        {
            players.Enqueue(players.Dequeue());
            
        }
        string playerOut = players.Dequeue();

        return playerOut;
    }

    public bool GameOver => players.Count == 1;

    public string Winner
    {
        get
        {
            if (!GameOver)
            {
                throw new InvalidOperationException("Игра еще не окончена");
            }

            return players.Dequeue();
        }
    }
}