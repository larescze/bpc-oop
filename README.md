# BPC-OOP 

## Počítačové cvičení č. 2

1. Vytvořte vlastní třídu Complex pro práci s komplexními čísly (nepoužívejte Complex z
System.Numerics). Konstruktor třídy bude mít dva argumenty typu double s reálnou a
imaginární částí. Hodnoty budou uloženy v členských proměnných Realna a Imaginarni.
Implementujte operátory +, -, *, /, ==, !=, unární operátor -. Implementujte metodu ToString
pro zobrazení komplexního čísla na konzoli. Napište metody vracející komplexně sdružené
číslo, modul a argument.

2. Vytvořte třídu TestComplex se statickou metodou Test se dvěma argumenty Complex
(budou obsahovat skutečnou a očekávanou hodnotu) a argumentem typu string pro název
testu. Metoda vypíše na konzoli název testu a OK, když se obě komplexní hodnoty liší o
hodnotu menší než epsilon, a napíše Chyba: Očekávaná hodnota: …, Skutečná hodnota: …
v případě chyby (odchylka větší než konstanta Epsilon, kterou nastavíte na 1E-6).

3. Otestujte operátory +, -, *, /, unární operátor - a metodu vracející komplexně sdružené číslo
z bodu 1. pomocí třídy TestComplex z bodu 2. Vytiskněte výsledky operátorů ==, != a
výsledky metod modul a argument.
