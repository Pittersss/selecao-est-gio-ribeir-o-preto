//Problema 1
bool FibonacciCheck(int number)
{
    int predecessor1 = 0;
    int predecessor2 = 1;
    while (predecessor1 + predecessor2 < number)
    {
        int aux = predecessor2;
        predecessor2 += predecessor1;
        predecessor1 = aux; 
    }
    return (predecessor1 + predecessor2) == number;
}

//Problema 2

bool HaveA(string word)
{
   return word.Contains('A') || word.Contains('a');
}

int quantityOfA(string word)
{
    int myCounter = 0;

    if (HaveA(word))
    {
        for(int i = 0; i < word.Length; i++)
        {
            if(word[i] == 'A' || word[i] == 'a')
            {
                myCounter += 1;
            }
        }
    }
    
    return myCounter;
}

//Problema 3

/*int indice = 12;
int soma = 0;
int k = 1;

while(k < indice)
{
    k = k + 1;
    soma = soma + k;
}
*/

//Valor final da Soma = 77

//Problema 4

//a) 1, 3, 5, 7, 9
//b) 2, 4, 8, 16, 32, 64, 128
//c) 0, 1, 4, 9, 16, 25, 36, 49
//d) 4, 16, 36, 64, 100
//e) 1, 1, 2, 3, 5, 8, 13
//f) 2, 10, 12, 16, 17, 18, 19, 10, 20, 30, 34, ...

//Problema 5

//Inicialmente, eu ligaria dois interruptores aleatórios e iria para uma sala aleatória:
//Caso 1: Chego na sala e lâmpada está apagada => O interruptor que sobrou é o dessa lâmpada
    //Como não foi dito que dessa sala sou impossibilitado de ver as lâmpadas das outras salas
    //Olho as duas salas restantes com as luzes ligadas
    //Volto para sala principal e desligo um dos interruptores
    //Vou para a mesma sala e por eliminação vendo a sala que a lâmpada apagou determino os respectivos 
    //Interruptores
//Caso 2: Chego em uma sala que está com a lâmpada ligada
    //Como não foi dito que dessa sala sou impossibilitado de ver as lâmpadas das outras salas
    //Olho a sala que está ligada e a outra que está desligada
    //Volto para a sala principal e desligo um dos interruptores que havia ligado e volto para a mesma sala
        //Caso 1: Volto para a mesma sala e a luz está apagada, logo concluo os 3 interruptores
            //O que eu apaguei é da sala que estou
            //O que ficou ligado é do interruptor que deixei ligado
            //A outra apagada é do interruptor que não mexi
        //Caso 2: Volto para a mesma sala e a luz está ligada, olho as outras salas
            //Vejo se que a outra que estava ligada apagou e concluo seu interruptor
            //A que eu estou é a do interruptor ligado
            //Concluo que a outra sala apagada é do interruptor que eu não mexi



