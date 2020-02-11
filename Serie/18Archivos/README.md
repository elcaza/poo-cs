# Programa que traduce de una entrada binaria a ASCII

## Compilado

    csc .\BinarioToText.cs

## Correrlo
+ Debe existir un archivo bynary.txt
+ Se creará un archivo text.txt
    + En caso de existir este se añadirá el contenido

    .\BinarioToText.exe

## Archivo entrada

El archivo entrada puede tener los siguientes formatos:

Una serie de multiples bytes sin espacios

    01101110011000110110100001100001001011000010000001100100011001010010000001100011

Una serie de multiples bytes con saltos de línea

    01101110011000110110100001100001001011000010000001100100011001010010000001100011
    0110111001101111
    01101101
    01100010
    
**No es posible ingresar bytes que lleven espacios** pues dará un error

    01101110 01101111 01101110 01101111 01101110 01101111
    01101101