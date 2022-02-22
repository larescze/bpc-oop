# BPC-OOP

## Počítačové cvičení č. 3

1. Vytvořte vlastní třídu Matrix pro práci s maticemi. Hodnoty v matici budou typu double. Vnitřně matici ukládejte do datového členu, který bude typu double[,]. Vytvořte konstruktor s jedním argumentem typu dvourozměrné pole double[,].
2. Implementujte operátory +, -, *, ==, !=, unární operátor -. Implementujte metodu ToString pro zobrazení matice na konzoli. Napište metodu vracející determinant matice pro rozměry do velikosti 3x3. Chybové stavy (např. nekompatibilita matic při operacích, u determinantu pokud není matice čtvercová či je větší než 3x3) ošetřete výjimkami.
3. V metodě Main provolejte jednotlivé operátory a metody a s využitím Matlabu ověřte správnost výpočtů v těchto operátorech a metodách.