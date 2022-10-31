//// See https://aka.ms/new-console-template for more information
//using System.Diagnostics.Contracts;

//Console.WriteLine("Hello, World!");




//int[] arrayUser = { 2, 6, 7, 5, 3, 9 };

//Console.WriteLine("Quanti numeri vuoi inserire?");
////prendi il numero dal utente
//int Number = Convert.ToInt32(Console.ReadLine());
////crea un array vuoto in cui verranno inseriti i numeri che inserisce l'utente
//int[] array = new int[Number];
////fai un ciclo per il numero scelto dall' utente
//for (int i = 0; i < Number; i++)
//{   
//    //indica quanti numeri ha inserito
//    Console.WriteLine("Inserisci il numero " + ( i + 1));
//    //assegna il numero richiesto al array
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}

////Stampare l’array di numeri fornito a video
//StampaArray(array);

////Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato;
//int[] arrayQuadrato = ElevaArrayAlQuadrato(array);
//StampaArray(arrayQuadrato);

////Stampare la somma di tutti i numeri
//int somma = SommaElementiArray(array);
//Console.WriteLine(somma);


////Stampare la somma di tutti i numeri elevati al quadrati
//int sommaQuadrato = SommaElementiArray(arrayQuadrato);
//Console.WriteLine(sommaQuadrato);

////fattoriale di un numero
//Console.WriteLine("inserisci un numero fattoriale");
//int NumberFattoriale = Convert.ToInt32(Console.ReadLine());
//Fattoriale(NumberFattoriale);

////successione di fibonaci
//Console.WriteLine("inserisci un numero");
//int NumberFabonaci = Convert.ToInt32(Console.ReadLine());
//FibonacciNonRec(NumberFabonaci);


////In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare
////operazioni complesse nei vostri programma principale.

////Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

//void StampaArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++) { 
//        Console.WriteLine(array[i]); 
//    }
//}


//int quadrato(int x)
//{

//    x *= x;

//    return x;

//}

//int[] ElevaArrayAlQuadrato(int[] array)
//{
//    int[] arrayQuadrato = new int[array.Length];

//    for (int i = 0; i < array.Length; i++)
//    {
//        arrayQuadrato[i] = quadrato(array[i]);

//    }
//    return arrayQuadrato;

//}

//int SommaElementiArray(int[] array)
//{
//    int totArray = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        totArray += array[i];
//    }
//    return totArray;
//}


////Fattoriale di un numero
//void Fattoriale(int n) {

//    for (int i = n - 1; i > 0; i--)
//    {
//        n *= i;
//    }
//    Console.WriteLine(n);

//}

////fibonaci iterativo
//void FibonacciNonRec(int n)
//{
//    int a = 0;
//    int b = 1;
//    int temp = a;
//    for (int i = 0; i < n; i++)
//    {
//        temp = a;
//        a = b;
//        b = temp + b;
//    }
//    Console.WriteLine(a);
//}



//Realizzare un programma in grado di CRIPTARE e DECRIPTARE una stringa inserita nell’utente con la strategia di criptazione nota come “IL CIFRARIO DI CESARE”
//l’utente inserisce una stringa da criptare / decriptare
//l’utente inserisce una chiave numerica per effettuare la criptazione / decriptazione della stringa inserita
Console.WriteLine("Inserisci un parola da cifrare");
string parola = Console.ReadLine();
Console.WriteLine("inserisci una chiave");
int number = Convert.ToInt32(Console.ReadLine());

encrypt(parola, number);


void encrypt(string testo, int chiave)
{

    string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    testo = testo.ToUpper();

    string testocifrato = "";

    int c = Convert.ToInt32(chiave);
    if (c < 0)
    {
        c = c + 26;
    }

    for (int i = 0; i < testo.Length; i++)
    {
        char ch = testo[i];

        if (ch >= 'A' & ch <= 'Z')
        {
            int pos = alfabeto.IndexOf(ch);
            pos = (pos + c) % 26;
            testocifrato += alfabeto[pos];
        }


    }

    Console.WriteLine(testocifrato);

}






