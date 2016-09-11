﻿// Programar em Python #12 - if, else if e else

using System;

namespace Base {
    class IfElseIfEElse {
        /*
            (if - se) condição for verdadeira {
                o código dentro do if é executado
            }
            (else if - senão se) condição for verdadeira (só ocorre o else if caso a condição de if seja falsa) {
                o código dentro do else if é executado
            }
            (else - senão) sem condição (só ocorre caso a condição de if e de else if sejam falsas) {
                o código dentro do else é executado
            }
        */

        public void Run() {
            int x = 30;

            if (x == 10)
                Console.WriteLine("O valor de x é igual a 10!");
            else if (x == 20)
                Console.WriteLine("O valor de x é igual a 20!");
            else
                Console.WriteLine("O valor de x é diferente de 10 e de 20!");
        }
    }
}