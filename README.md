# BPC-OOP

## Počítačové cvičení č. 11

1. Použijte databázový soubor SQL serveru z předchozích cvičení Vyuka.mdf.
2. Pomocí aplikace Visual Studio Installer se ujistěte, že máte ve Visual Studiu nainstalovanou komponentu „Nástroje LINQ to SQL“.
3. Vytvořte v třídu LINQ to SQL Classes a přetáhněte sem všechny tabulky z databáze.
4. Vytvořte metodu, která naplní databázi vzorovými daty pomocí LINQ to SQL. Tuto metodu pak provoláte na začátku programu v metodě Main. V této metodě otestujte před každým vložením, zdali tam již záznam s tímto primárním klíčem neexistuje, pokud ano, vkládání záznamu přeskočte. Pro test existence využijte extension metodu Any nad LINQ to SQL tabulkou.
5. Vytvořte pohled (VIEW) ve kterém vypíšete předměty spolu s počty zapsaných studentů. Vytvořte metodu, která zobrazí data z toho VIEW v konzolovém okně seřazená dle počtu studentů sestupně.
6. Vytvořte metody StudentiPredmetu s návratovou hodnotou typu IEnumerable<Student> a PredmetyStudenta s návratovou hodnotou typu IEnumerable<Predmet>, které vrací studenty předmětu zadaného zkratkou v argumentu a předměty, které má student, zadaný pomocí Id v argumentu metody, zapsané.
7. Nově implementované metody vzorově provolejte v metodě Main.
8. Vytiskněte seznam předmětů spolu s průměrnou známkou v tomto předmětu. Známky budou čerpány z tabulky Hodnoceni.