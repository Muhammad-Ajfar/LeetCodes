public class Solution
{
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players);
        Array.Sort(trainers);

        int i = 0; // Pointer for players

        // Iterate through each trainer
        foreach (int trainer in trainers)
        {
            // If all players are matched, break early
            if (i >= players.Length)
                break;

            if (players[i] <= trainer)
                i++;
        }

        // 'i' represents the number of matched players
        return i;
    }
}
