Console.WriteLine("\nOperadores Logicos");

/*
 
  && E (and)
    O operador Lógico (&&) retorna (True) se (ambas) as expressões forem (verdadeiras).
    
  || --> Ou (or)
    O operador lógico (||) retorna (True) se pelo menos uma das expressões for (verdadeiros).
    
  ! --> Navegação (not)
    O operador lógico (!) inverte o valor de uma expressão booleana.
  
 */


int numero1 = 1;
int numero2 = 2;

// Operador Lógico ( && )
bool valido = numero1 < 8 && numero1 < 9;
Console.WriteLine(valido);

// Operador Lógico 
bool valido2 = numero1 > 10 || numero2 < 8;
Console.WriteLine(valido2);