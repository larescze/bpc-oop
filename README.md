# BPC-OOP

## Počítačové cvičení č. 10

1. Vytvořte nový databázový soubor SQL serveru Vyuka.mdf.
2. Navrhněte schéma databáze, které bude udržovat informace o výuce: Seznam předmětů (zkratka, název předmětu) a seznam studentů (jméno, příjmení, datum narození, ID studenta).
3. Navrhněte správné tabulky a sloupce v tabulkách se správnými typy, případnou spojovací tabulku (student může mít zapsáno více předmětů a zároveň v předmětu může být zapsáno více studentů). Tvorbu tabulek zapište do SQL skriptu.
4. Vytvořte vhodné primární a cizí klíče.
5. Přidejte tabulku Hodnocení s primárním klíčem sestávající ze dvou sloupců (ID studenta a zkratka předmětu) a datem hodnocení a samotným číselným hodnocením studenta.
6. Naplňte tabulky vhodnými daty.
7. Vytvořte skript, do kterého zapíšete následující SELECT dotazy:
8. Dotaz, kde vypíšete všechny studenty a předměty které mají zapsané. Použijte LEFT JOIN.
9. Dotaz, kde vypíšete příjmení studentů a počet studentů, kteří mají stejné příjmení. Seřaďte je sestupně dle četnosti příjmení. Použijte GROUP BY.
10. Dotaz, kde vypíšete předměty, ve kterých je zapsáno méně než 3 studenti.
11. Dotaz, kde vypíšete všechny předměty a nejlepší, nejhorší a průměrné hodnocení v předmětu. Dále pak počet hodnocených studentů v předmětu. Použijte GROUP BY.