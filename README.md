# BPC-OOP

## Počítačové cvičení č. 6

1. Vytvořte abstraktní základní třídu GrObjekt a z něj odvozené abstraktní třídy Objekt2D a Objekt3D.
2. Vytvořte polymorfní rozhraní v GrObjekt. Bude definováno bezargumentovou metodou bez návratové hodnoty s názvem Kresli.
3. Vytvořte polymorfní rozhraní v Objekt2D. Bude definováno bezargumentovou metodou s návratovou hodnotou typu double a názvem SpoctiPlochu.
4. Vytvořte polymorfní rozhraní v Objekt3D. Bude definováno dvěma bezargumentovými metodami s návratovou hodnotou typu double a názvy SpoctiPovrch a SpoctiObjem.
5. Vytvořte třídy: Kruh, Obdelnik, Elipsa, Trojuhelnik, Kvadr, Valec, Koule a Jehlan odvozené z Objekt2D či Objekt3D. Vytvořte nezbytné datové členy popisující rozměry objektu a vytvořte konstruktory, které tyto datové členy naplní. Ve třídách pak implementujte metody požadované polymorfním rozhraním.
6. Pozn.: Metoda Kresli bude pro jednoduchost psát na konzolu např. text typu: „Valec (r = 1,54; v = 5,41)“.
7. Do metody Main napište ukázku naplnění pole typů GrObjekt konkrétními grafickými objekty. Procházejte pole, provolávejte metodu Kresli a s využitím operátoru is sečtěte celkovou plochu, celkový povrch a celkový objem.