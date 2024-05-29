# Vyhledávač 3000

A simple program for searching the current list of cadastral areas for GEPRO's sales department

# Základní funkce programu

- Program umí přes CLI TortoiseSVN stáhnout nejnovější soubor Identcis.csv pomocí pevné adresy v SVN repozitáři GEPRO
- Obsahuje také vybrání lokálního souboru (ukázkový soubor Identcis.csv v repozitáři)
- Dokáže soubor vypsat do interaktivní tabulky (pouze pro čtení)
- Pomocí vyhledávacího okna a podrobnějích voleb zobrazí požadované informace

# Práce s programem

V úvodním okně je na výběr ze dvou možností. Pro nahrání ze SVN je potřeba mít **přístup na lokální server GEPRO** (být v síti, nebo použití VPN). Pokud se vybírá soubor manuálně, je potřeba, aby byl ve **správném formátu** - stejném, jako na SVN serveru.

Po vybrání souboru se všechny řádky souboru přepíší do tabulky - může někdy pár vteřin trvat.

## Vyhledávání v tabulce

Po otevření nového okna se dá v tabulce jednoduše vyhledávat **zadáním textu do pole**. Dá se prohledávat **celá tabulka**, nebo jen **4 nejčastější sloupce** pro hledání: Název a kód obce a název a kód katas. území.
Navíc jde také zvolit, zda má text **přesně odpovídat** zadanému textu, nebo ho může i **obsahovat**.

Vypíší se všechny řádky, u kterých se **alespoň v jednom sloupci** našla shoda.

# Programátorská příručka

Aplikace je vytvořena na platformě **Windows Forms C#** verze **.NET 8.0**. Je proto zapotřebí mít stažené .NET 8 SDK a ve Visual Studiu stažený balíček *Vývoj desktopových aplikací pomocí .NET*. Projekt se otevírá souborem *Vyhledavac3000.sln*.

## Změnil se počet sloupců v tabulce

1. V návrháři formuláře *FormList.cs* upravte ovládacímu prvku `DataGridView` sloupce podle situace.
    - Nakliknutím na prvek se u něj vpravo nahoře zobrazí šipka doprava
    - Po rozkliknutí vybereme možnost *Upravit sloupce…*
2. V C# kódu formuláře *FormList.cs* se musí upravit u každého výskytu definice Listu s daty Tuple tak, aby **počet proměných** (typu řetězec) v něm **korespondoval s počtem sloupců** v tabulce.
    - Vyskytuje se:
        - Na začátku kódu pod konstruktorem (řádek 14)
        - V parametru funkce `WriteToTable` (řádek 71)
        - V obslužné metodě tlačítka `TbSearch_Click` (řádek 108)
    - List<(string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string)>
    - Počet *string* - 17 = 17 sloupců
3. Ve funkci `LoadFile` upravte přiřazování oddělených dat do příslušných políček - přispůsobit počtu sloupců
4. Podobným způsobem ve funkci `WriteToTable` **upravte přidávání dat** do tabulky v cyklu foreach tak, aby čísla **odpovídala tabulce** (zde indexy Itemů začínají od 1!)
5. V obslužné metodě `BtSearch_Click` upravte filtr tak, aby odpovídal nově uspořádaným datům
    - Upravte čísla v polích indexů sloupců tak, aby odpovídala tabulce (`int[][] columnsToSearch`)

## Přidání nového hledání ve specifických sloupcích

1. V návrháři formuláře *FormList.cs* **upravte ovládacímu prvku** `CbSearchBy` (ComboBox volící množinu prohledávaných sloupců) **vlastnost** `Items` - přidejte vlastní možnost, pojmenujte dle libosti
2. V C# kódu formuláře *FormList.cs* **přidejte do enum** `SearchBy` **novou možnost** Vašeho hledání (nejlépe dodržte jednoduchost a tvar stávajících)
    - Dejte si pozor, abyste dodrželi stejné pořadí prvků jako u ComboBoxu
3. V obslužné metodě BtSearch_Click přidejte opět **ve stejném pořadí** nové pole sloupců, které chcete prohledávat, pomocí indexů (začínajících od 0)

## Změnila se cesta v SVN

1. V C# kódu formuláře *FormStart.cs* **upravte** v obslužné metodě `BtSvnLoad_Click` na prvním řádku **řetězec** `svnUrl` na **aktuální adresu**.
