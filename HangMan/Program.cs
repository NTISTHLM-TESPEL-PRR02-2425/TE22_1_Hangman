/*
- Ett ord väljs


Skriva ut så många _ som det finns i ordet

Ta in en gissning
Byt ut _ mot bokstaven där den finns i ordet
Om bokstaven inte finns, rita en till del av gubben

Om alla _ har blivit bokstäver: #winning
Om hela gubben är utritad: #losing
*/


string word = "couch";

string[] hiddenWord = { "_", "_", "_", "_", "_" };

Console.WriteLine("Välkommen till hangman!");

Console.WriteLine(string.Join(" ", hiddenWord));

// foreach(string letter in hiddenWord)
// {
//   Console.Write(letter);
// }

Console.WriteLine("\nGissa en bokstav!");
while (true)
{
  string guess = Console.ReadLine();

  if (word.Contains(guess[0]))
  {
    Console.WriteLine("yay");
  }
  else
  {
    Console.WriteLine("boo");
  }
}