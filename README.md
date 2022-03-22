# BPC-OOP

## Počítačové cvičení č. 7

1. Vytvořte rozhraní I2D s jednou metodou Plocha.
2. Vytvořte abstraktní třídu Objekt2D, která bude implementovat pomocí abstraktní metody Plocha rozhraní I2D a bude implementovat CompareTo z IComparable (bude porovnávat objekty na základě plochy).
3. Vytvořte třídy: Kruh, Obdelnik, Elipsa, Trojuhelnik a Ctverec, které budou mít za bázovou třídu Objekt2D. Pro jednotlivé třídy implementujte požadovaný abstraktní člen Plocha a metodu ToString.
4. Vytvořte třídu Extremy se dvěma statickými generickými metodami Nejvetsi a Nejmensi, které vrací typ T a argumentem je pole typů T. Generický typ bude vždy implementovat rozhraní IComparable (na konci hlavičky generických metod bude where T:IComparable), abyste mohli volat CompareTo v těchto statických metodách.
5. Do metody Main napište ukázku naplnění různých polí typů int[], string[], Kruh[], Obdelnik[]... i pole Objekt2D[] s různými objekty. Zavolejte na jednotlivá pole generické metody Nejvetsi a Nejmensi. Nalezený objekt vždy zobrazte pomocí ToString.
6. Pomocí LINQ vyfiltrujte z pole int[] s hodnotami 1, 3, 5, 7, 9 pouze hodnoty v intervalu 4 až 8. Výsledek zobrazte na konzoli.