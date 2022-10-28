// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




int[] arrayUser = { 2, 6, 7, 5, 3, 9 };
//Stampare l’array di numeri fornito a video
StampaArray(arrayUser);

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato;
int[] arrayQuadrato = ElevaArrayAlQuadrato(arrayUser);
StampaArray(arrayQuadrato);

//Stampare la somma di tutti i numeri
int somma = SommaElementiArray(arrayUser);
StampaArray(somma);


//Stampare la somma di tutti i numeri elevati al quadrati
int sommaQuadrato = quadrato(somma);
StampaArray(sommaQuadrato);
//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare
//operazioni complesse nei vostri programma principale.

//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArray

void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { 
        Console.WriteLine(array[i]); 
    }
}

int quadrato(int x)
{

    x *= x;

    return x;

}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQuadrato = new int[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        arrayQuadrato[i] = quadrato(array[i]);
       
    }
    return arrayQuadrato;

}

int SommaElementiArray(int[] array)
{
    int totArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        totArray += array[i];
    }
    return totArray;
}

