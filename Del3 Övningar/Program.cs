Console.WriteLine(GetChoice("Adam", "Imad", "Janan"));

string GetChoice(string string1, string string2, string string3)
{
    string[] stringArray = [string1, string2, string3];
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(stringArray[i]);
    }
    Console.WriteLine("Välj en av stringarna, genom att skriva in siffror, 1-3");
    int answer = 5;
    bool pareCorrect = false;
    while (!pareCorrect || answer <= 0 || answer > 3)
    {
        string userInput = Console.ReadLine();
        pareCorrect = int.TryParse(userInput, out answer);
        if (!pareCorrect || answer <= 0 || answer > 3)
        {
            Console.WriteLine("Skriv ett giltigt siffra är du snäll");
        }
    }
    string result = stringArray[answer - 1];
    return result;
}

Console.ReadLine();