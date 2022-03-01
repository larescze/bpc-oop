# BPC-OOP

## Počítačové cvičení č. 4

1. Vytvořte vlastní třídu StringStatistics pro statistické vyhodnocování řetězců. Vytvořte
konstruktor s jedním argumentem typu string.
2. Vytvořte metody vracející počet slov, počet řádků, počet vět, pole nejdelších slov, pole
nejkratších slov, pole nejčetnějších slov a setříděné pole slov dle abecedy. Pro rozdělení na
slova zohledněte existenci interpunkčních znamének v textu. Konec řádku je reprezentován
znakem \n. Konec věty identifikujte jako tečku, vykřičník či otazník, za nimiž následuje velké
písmeno nebo konec řetězce.
3. V metodě Main inicializujte instanci StringStatistics vzorovým textem textem a provolejte
jednotlivé metody a výsledky zobrazte na konzoli. Použijte následující vzorový text:
```
string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
+ "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
+ "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
+ "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
+ "posledni veta!";
```