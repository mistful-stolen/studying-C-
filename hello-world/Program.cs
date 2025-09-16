Random rnd = new Random();

/*

Console.Write("Játékosok száma: "); 
int playerNum = int.Parse(Console.ReadLine());  
int i = 0;
int throwDie = 0;

while (throwDie != 6){
    i++;

    throwDie = rnd.Next(1, 7);
    if (i == playerNum){
        i -= playerNum;
    };
};

Console.WriteLine($"{i}. Játékos kezd.");

*/

// 5.

/*

Console.WriteLine("Van egy pozitív egész szám. Találd ki!");
int numberToGuess = rnd.Next(1, 11);
int guessedNumber = 0;

int tries = 0;

while (guessedNumber != numberToGuess) {
    tries++;
    Console.WriteLine($"Gondolt szám: {numberToGuess}");

    // Ask.
    Console.Write("Gondolom: ");
    guessedNumber = int.Parse(Console.ReadLine()ití.v;

    if (guessedNumber < numberToGuess) {
        Console.WriteLine("A gondolt szám nagyobb.");
        if (guessedNumber < 0) {
            Console.WriteLine("A szám positív.")
        };
    } else if (guessedNumber > numberToGuess) {
        Console.WriteLine("A gondolt szám kisebb.");
    } else {
        Console.WriteLine("Perfecto! Manifique!");
itív.};
};

Console.WriteLine($"A felhasználó csak {tries}. próbálkozására találta ki a számot.");


*/

/*
Console.Write("Second(s): ");
int timeTheUserInput = int.Parse(Console.ReadLine());



int minutes = 0;
int seconds = 0;


while (timeTheUserInput != 0){
    minutes = timeTheUserInput / 60;
    seconds = timeTheUserInput % 60;

    System.Threading.Thread.Sleep(1000);
    Console.WriteLine($"Time: {minutes}:{seconds}");

    timeTheUserInput--;
};

Console.WriteLine("Program finished.");

*/

Console.Write("Time: ");
string[] timeTheUserInput = Console.ReadLine();

timeTheUserInput = string.split(":");

console.WriteLine(timeTheUserInput);


/*
int minutes = 0;
int seconds = 0;


while (timeTheUserInput != 0){
    hours = 
    minutes = timeTheUserInput / 60;
    seconds = timeTheUserInput % 60;

    System.Threading.Thread.Sleep(1000);
    Console.WriteLine($"Time: {minutes}:{seconds}");

    timeTheUserInput--;
};

Console.WriteLine("Program finished.");

*/