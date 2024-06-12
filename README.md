# Sklep Motorowy

## Opis projektu
Projekt polega na stworzeniu aplikacji do zarządzania sklepem motorowym, która pozwala na logowanie i rejestrację użytkowników, zarządzanie produktami oraz przetwarzanie zamówień.

Struktura bazy danych:
![image](https://github.com/izalke/onion-architeture/assets/104392855/7368536e-88ea-4cf9-affa-d540aea14b60)

    
## Wymagania
- .NET 8
- Visual Studio 2022
- SQL Server

## Instalacja
1. Sklonuj repozytorium z tego GitHub:
    ```bash
    git clone https://github.com/izalke/onion-architeture.git
    ```
2. Otwórz projekt w Visual Studio.
3. Skonfiguruj połączenie z bazą danych w pliku `appsettings.json`.
4. Uruchom migracje EF Core:
    ```bash
    dotnet ef database update
    ```
5. Uruchom aplikację:
    ```bash
    dotnet run
    ```

## Konfiguracja
Plik `appsettings.json` powinien zawierać ustawienia połączenia z bazą danych oraz inne niezbędne konfiguracje.

Migracja i stworzenie bazy danych:
    ```
    I. W appsettings.json zmień w lini 10 Server=WHITE na Server=[nazwa swojego serwera MsSQL]
    II. Tools -> Nuget Package Manager -> Console
    III. W konsoli wpisz: update-database -> add-migration Migration -> update-database
    ```


## Testowanie
Aby uruchomić testy jednostkowe, użyj poniższej komendy:
```bash
dotnet test

