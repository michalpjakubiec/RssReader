-Model
--Model ConferenceUser (polaL imie, nazwa, email, Avatar)

-Controller
--Get (lista zarejestrowanych) - HttpGet
--SaveUser (zapisuje na konferencje) - HttpPost

-Widok
--Formularz (bez walidacji, napisany r�cznie)
--Lista (tabela)

Wymagania:
--AFT
--Zapisanych u�ytkownik�w trzymamy w pami�ci (lista - pole statyczne)
--Boostrap
--1! strona
-Zastosowa� wrzorzec Post Redirect Get

public class ConferenceUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public  Avatar { get; set; }
}