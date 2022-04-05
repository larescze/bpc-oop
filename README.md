# BPC-OOP

## Počítačové cvičení č. 9

1. Vytvořte aplikaci s grafickým uživatelským rozhraním, která bude představovat kalkulačku a-la calc.exe z Windows. Implementujte standardní mód a bez menu.
2. Pro realizaci použijte projekt „WPF App“.
3. Zjednodušte si řešení tak, že neimplementujte horní řádek displeje s historií. Dále
neimplementujte tlačítka odmocnina, % a 1/x.
4. Při řešení oddělte vrstvu uživatelského rozhraní od samotné implementace kalkulačky.
5. Implementujte třídu Calculator, která bude přijímat stisky jednotlivých kláves pomocí metody Tlacitko. Pomocí vlastností Display a Pamet (obě typu string) bude předávat UI vrstvě to, co se má zobrazit. Display bude obsahovat aktuální hodnotu na displeji a Pamet bude obsahovat prázdný řetězec nebo hodnotu „M“.
6. Při implementaci třídy Calculator Vám jistě usnadní řešení zavedení „stavového automatu“ pomocí datového členu _stav.