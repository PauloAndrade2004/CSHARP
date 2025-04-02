Console.WriteLine("Operadores Relacionais");


/*

    (==) Igualdade.
    (>) Maior.
    (<) Menor.
    (<=) Menor Igual.
    (>=) Maior Igual.
    (!=) Diferente.

    Operador Relacional:
        * Tem como retorno uma operacao Booleana ou seja, (True) ou (False).
        * Podemos utilizar o Operador (==) para comparar texto ou seja, Tipo String.

 */


// Exemplos Comparando número:
Console.WriteLine("\n==== Comparando Números ====");
int numero1 = 5;
int numero2 = 7;

Console.WriteLine(numero1 == numero2); // Fasle
Console.WriteLine(numero1 != numero2); // True
Console.WriteLine(numero1 > numero2); // False
Console.WriteLine(numero1 < numero2); // True
Console.WriteLine(numero1 >= numero2); // False
Console.WriteLine(numero1 <= numero2); // True

// Exemplo Comparando Textos (String)
Console.WriteLine("==== Comprando String ====");
string nome1 = "Paulo Cesar";
string nome2 = "Gabrielle Oliveira";

bool comprandoString = nome1 == nome2; // Adicionamos o bool porque retorna True ou False.
Console.WriteLine(comprandoString);