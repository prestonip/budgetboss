using System;
using System.Collections.Generic;

public class Player
{
    public double Money { get; set; }
    public int Age { get; set; }
    public string EmploymentStatus { get; set; }
    public string EducationLevel { get; set; }
    public Dictionary<string, double> Assets { get; } = new Dictionary<string, double>();

    // Constructor to initialize the Player object
    public Player(double money, int age, string employmentStatus, string educationLevel)
    {
        Money = money;
        Age = age;
        EmploymentStatus = employmentStatus;
        EducationLevel = educationLevel;
    }

    // Method to add an asset to the player's assets
    public void AddAsset(string assetName, double assetValue)
    {
        if (!Assets.ContainsKey(assetName))
        {
            Assets.Add(assetName, assetValue);
        }
        else
        {
            Assets[assetName] += assetValue;
        }
    }

    // Method to remove an asset from the player's assets
    public void RemoveAsset(string assetName)
    {
        if (Assets.ContainsKey(assetName))
        {
            Assets.Remove(assetName);
        }
    }

    // Method to calculate the total net worth of the player
    public double CalculateNetWorth()
    {
        double netWorth = Money;
        foreach (var asset in Assets.Values)
        {
            netWorth += asset;
        }
        return netWorth;
    }

    // Override ToString method to provide a string representation of the Player object
    public override string ToString()
    {
        return $"Name: {Age} | Age: {Age} | Employment: {EmploymentStatus} | Education: {EducationLevel} | Money: {Money:C} | Net Worth: {CalculateNetWorth():C}";
    }
}
