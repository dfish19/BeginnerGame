Console.WriteLine("Welcome to the arena. Do not go outside of the lines. READY.......FIGHT!");
Console.WriteLine();

var warriorMan = 20;
var assailantGuy = 20;

var warriorHit = 5;
var assailantHit = 5;
var powerHit = 10;

var rechargeHealth = 5;

var random = new Random();

while (warriorMan > 0 && assailantGuy > 0)
{
    Console.WriteLine("Player Turn"); 
    Console.WriteLine($"Player HP - {warriorMan}. Enemy HP - {assailantGuy}");
    Console.WriteLine();
    Console.WriteLine("Enter 'a' to attack 'p' for power hit or 'h' to heal!");
    

    string choice = Console.ReadLine();

    if (choice == "a")
    {
        Console.WriteLine();
        assailantGuy -= warriorHit;
        
        Console.WriteLine($"Player attack enemy and deals {warriorHit} damage!");
            
    }
    if(choice == "h")
    {
        Console.WriteLine();
        warriorMan += rechargeHealth;
        Console.WriteLine($"Player restores {rechargeHealth} health points!");
    }
    if (choice == "p")
    {
        Console.WriteLine();
        assailantGuy -= powerHit;
    }

    if (assailantGuy > 0)
    {
        Console.WriteLine("Enemy Turn");
        Console.WriteLine($"Player HP - {warriorMan}. Enemy HP - {assailantGuy}");
        var enemyChoice = random.Next(0,3);

        if (enemyChoice == 0)
        {
            Console.WriteLine();
            warriorMan -= assailantHit;
            Console.WriteLine($"Enemy attacks and deals {assailantHit} damage!");
        }
        else if(enemyChoice == 1)
        {
            Console.WriteLine();
            assailantGuy += rechargeHealth;
            Console.WriteLine($"Enemy restores {rechargeHealth} health points!");
        }
        else
        {
            Console.WriteLine();
            assailantGuy += powerHit;
        }
    }

    
}
if (warriorMan > 0)
{
    Console.WriteLine();
    Console.WriteLine("Supreme Warrior...You won!");
}
else
{
    Console.WriteLine();
    Console.WriteLine("You lose! Improve your skills and try again!");
}