List<string> words = new List<string>() { "ayna", "esya","meyve" };
var choosingWord = getRandomWord(words);
char[] charWord = choosingWord.ToCharArray();
var puzzledWord = convertToPuzzle(choosingWord);
byte lifeCount = 3;
bool gameOver = true;
while (gameOver)
{
    if (lifeCount <= 3 && lifeCount>0)
    {
        
        showOnScreen(puzzledWord);
        Console.ReadLine();
        char suggestedLetter = getLetterFromUser();
        if (isLetterFindInWord(choosingWord, suggestedLetter))
        {
            puzzledWord = replaceStarWithLetter(choosingWord, puzzledWord, suggestedLetter);
            lifeCount -=1;
        }
        else
        {
            lifeCount -=1;
            Console.WriteLine("Tahmininiz doğru değil");
        }
    }

    else
    {
        Console.WriteLine("Hakkınız bitti. Kaybettiniz.");
        gameOver = false;
    }


}

string getRandomWord(List<string> words) //Random bir kelime seçer.
{
    var index = new Random().Next(words.Count);
    return words[index];
}

string convertToPuzzle(string word) //Kelimenin her harfini * olarak gösterir.
{
    string puzzle = string.Empty;
    for (int i = 0; i < word.Length; i++)
    {
        puzzle += "*";
    }
    return puzzle;

}

void showOnScreen(string word) //Ekranda gösterir.
{
    Console.WriteLine(word);
}

char getLetterFromUser() //Kullanıcıdan harf alınır.
{
    Console.WriteLine("Bir harf giriniz....");

    return Console.ReadLine()[0];
}

bool isLetterFindInWord(string word, char letter) //Harf kelime içerisinde var mı kontrolü yapar
{
    return word.ToLower().Contains(letter);
}

string replaceStarWithLetter(string word, string puzzle, char harf) //Çıkan harfin * ını harf yapar
{
    char[] charPuzzle = puzzle.ToCharArray();
    for (int i = 0; i <word.Length; i++)
    {
        if (word[i] == harf)
        {   
            charPuzzle[i]= harf;
        }
    }
    return new string(charPuzzle);
       
}

