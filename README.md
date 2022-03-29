# BPC-OOP

## Počítačové cvičení č. 8

1. Vytvořte třídu RocniTeplota sestávající z vlastnosti Rok a vlastnosti MesicniTeploty, která bude reprezentována typem ``List<double>``. Nezapomeňte na inicializaci v konstruktoru.
2. Vytvořte dále v této třídě vlastnosti určené jen pro čtení: MaxTeplota, MinTeplota a PrumRocniTeplota. Hodnotu vypočítávejte s obsahu seznamu MesicniTeploty.
3. Vytvořte třídu ArchivTeplot, která bude udržovat v privátním datovém členu _archiv seznam typů RocniTeplota, pro rychlé vyhledávání v seznamu použijte typ SortedDictionary.
4. Vytvořte metody Load a Save s argumentem cesta k souboru pro načtení a uložení průměrných měsíčních teplot. Soubor bude ve formátu: 2010: -2,4; 1,5; 4,5; ... Kde za rokem je dvojtečka, pak následuje 12 průměrných teplot oddělených středníkem. Každý rok je na novém řádku.
5. Vytvořte metodu Kalibrace, která ke všem měřením přičte konstantu předanou v argumentu.
6. Vytvořte metodu Vyhledej pro vyhledání hodnoty typu RocniTeplota pro rok daný argumentem.
7. Vytvořte metodu TiskTeplot pro tisk všech teplot.
8. Vytvořte metodu TiskPrumernychRocnichTeplot pro tisk průměrných teplot po jednotlivých rocích:
9. Vytvořte metodu TiskPrumernychMesicnichTeplot pro tisk průměrných teplot v daném měsíci za všechny roky:
10. V metodě Main ukažte načtení ze souboru, tisk teplot a tisk průměrných hodnot, kalibraci o teplotu -0,1 a následné uložení do nového souboru.