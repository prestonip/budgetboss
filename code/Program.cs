class Program
{
    static void Main(string[] args)
    {
        // Create a new player
        Player player = new Player(50000.0, 25, "Employed", "Bachelor's Degree");

        // Add assets to the player
        player.AddAsset("House", 250000.0);
        player.AddAsset("Car", 20000.0);

        // Remove an asset from the player
        player.RemoveAsset("Car");

        // Print player information
        Console.WriteLine(player);

        // Calculate and print net worth
        Console.WriteLine($"Net Worth: {player.CalculateNetWorth():C}");
    }
}
