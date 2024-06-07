# Sklep Motorowy

## Opis projektu
Projekt polega na stworzeniu aplikacji do zarządzania sklepem motorowym, która pozwala na logowanie i rejestrację użytkowników, zarządzanie produktami oraz przetwarzanie zamówień.

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

## Testowanie
Aby uruchomić testy jednostkowe, użyj poniższej komendy:
```bash
dotnet test
