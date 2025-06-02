# Expense Tracker

## 📘 Opis aplikacji

**Expense Tracker** to aplikacja desktopowa (Windows Forms), służąca do zarządzania osobistymi finansami. Umożliwia:

- Dodawanie kont użytkowników
- Rejestrowanie przychodów i wydatków
- Przeglądanie transakcji w podziale na kategorie
- Tworzenie własnych kategorii
- Przegląd salda i wykresów z podsumowaniem finansów
- Edytowanie i usuwanie transakcji
- Obsługę wielu kont finansowych

## 🗄️ Technologia

- **Język**: C#
- **GUI**: Windows Forms (.NET)
- **ORM**: Entity Framework Core
- **Baza danych**: PostgreSQL

---

## 🧩 Struktura projektu

- ExpenseTracker/
  - Data/
    - Models/
      - Account.cs
      - Category.cs
      - Transaction.cs
    - AppDbContext.cs
    - DbSeeder.cs
  - Forms/
    - AccountCreationForms.cs
    - AccountSelectionForms.cs
    - MainForm.cs
  - Migrations/
  - Resources/
    - salary.png
  - Services/
    - Implementations/
      - CategoryService.cs
      - SummaryService.cs
      - TransactionService.cs
    - Interfaces/
      - IAccountService.cs
      - ICategoryService.cs
      - ITransactionService.cs
    - Models/
      - AccountSummary.cs
  - UserControls/
    - CategoryView.cs
    - DashboardView.cs
    - TransactionControl.cs
    - TransactionView.cs
  - app.config
  - appsettings.json

- README.md



---

## 🧬 Model bazy danych

### Tabela: `Accounts`
| Kolumna     | Typ        | Opis                |
|-------------|------------|---------------------|
| AccountId   | int        | Klucz główny        |
| Name        | string     | Nazwa konta         |

### Tabela: `Categories`
| Kolumna     | Typ        | Opis                            |
|-------------|------------|---------------------------------|
| CategoryId  | int        | Klucz główny                    |
| Name        | string     | Nazwa kategorii                 |
| Type        | enum       | Income / Expense                |
| AccountId   | int        | Powiązanie z kontem użytkownika|

### Tabela: `Transactions`
| Kolumna      | Typ        | Opis                            |
|--------------|------------|---------------------------------|
| TransactionId| int        | Klucz główny                    |
| Amount       | decimal    | Kwota transakcji                |
| Date         | DateTime   | Data operacji (UTC)             |
| Description  | string     | Opis transakcji                 |
| CategoryId   | int        | Kategoria                       |
| AccountId    | int        | Powiązanie z kontem             |

---

## ⚙️ Konfiguracja i uruchomienie

### 1. Wymagania:
- .NET 9 
- PostgreSQL 14 lub nowszy
- Visual Studio 2022 lub nowszy

### 2. Ustawienia połączenia z bazą danych

W pliku `appsettings.json`:

```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Host=localhost;Database=expense_db;Username=postgres;Password=balica"
    }
}
