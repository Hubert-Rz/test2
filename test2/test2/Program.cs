// zadanie domowe dzień 4

string imie = "Ewa";
bool kobieta = false;
int wiek = 33;

if (kobieta == true) //kobieta
{
    if (imie == "Ewa" && wiek == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (imie != "Ewa" && wiek < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else //mężczyzna
{
    if (wiek < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    } 
    else if ( imie=="Ewa")
    {
        Console.WriteLine("Czy mężczyzna może mieć na imię Ewa ?");
    }
}