using System;
using System.Collections.Generic;

class Player
{
    public int PlayerId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class CricketTeam
{
    private List<Player> players;

    public CricketTeam()
    {
        players = new List<Player>();
    }

    public void AddPlayer(int playerId, string name, int age)
    {
        if (players.Count >= 11)
        {
            Console.WriteLine("Team already has 11 players. Cannot add more.");
            return;
        }

        Player newPlayer = new Player { PlayerId = playerId, Name = name, Age = age };
        players.Add(newPlayer);
        Console.WriteLine($"Player {name} added to the team.");
    }

    public void RemovePlayerById(int playerId)
    {
        Player playerToRemove = players.Find(player => player.PlayerId == playerId);
        if (playerToRemove != null)
        {
            players.Remove(playerToRemove);
            Console.WriteLine($"Player {playerToRemove.Name} (ID: {playerToRemove.PlayerId}) removed from the team.");
        }
        else
        {
            Console.WriteLine($"Player with ID {playerId} not found in the team.");
        }
    }

    public Player GetPlayerDetailsById(int playerId)
    {
        return players.Find(player => player.PlayerId == playerId);
    }

    public Player GetPlayerDetailsByName(string name)
    {
        return players.Find(player => player.Name == name);
    }

    public List<Player> GetAllPlayers()
    {
        return players;
    }
}

class Program
{
    static void Main()
    {
        CricketTeam team = new CricketTeam();
        team.AddPlayer(1, "sravani", 25);
        team.AddPlayer(2, "swathi", 28);
        team.AddPlayer(3, "Swapna", 30);

        int playerIdToFind = 2;
        Player player = team.GetPlayerDetailsById(playerIdToFind);
        if (player != null)
        {
            Console.WriteLine($"Player found by ID: {player.Name}, Age: {player.Age}");
        }
        else
        {
            Console.WriteLine($"Player with ID {playerIdToFind} not found.");
        }

        string playerNameToFind = "Swapna";
        player = team.GetPlayerDetailsByName(playerNameToFind);
        if (player != null)
        {
            Console.WriteLine($"Player found by name: {player.Name}, Age: {player.Age}");
        }
        else
        {
            Console.WriteLine($"Player with name {playerNameToFind} not found.");
        }
        Console.ReadKey();
    }
}
