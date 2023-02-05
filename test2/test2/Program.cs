// zadanie domowe dzień 5

int number = 11559990;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();



for (int i = 0; i < 10; i++)
{
    string iInString = i.ToString();
    int licznik = 0;
    foreach (char letter in letters)
    {
        string letterInString = letter.ToString();
        if (letterInString == iInString)
        {
            licznik++;
        }
    }
Console.WriteLine(i + " => " + licznik);
}
