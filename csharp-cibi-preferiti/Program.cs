// See https://aka.ms/new-console-template for more information


//un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
//L’array deve essere già inizializzato nel programma,
//e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
string[] cibi = { "pasta", "pomodoro", "grana", "pinoli", "pizzette", "calamari", "insalata" };

//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//-La lunghezza della classifica
Console.WriteLine($"ti piacciono {cibi.Length} cibi");

//- La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Console.WriteLine($"in ordine sono: \n");
for (var i = 0; i < cibi.Length; i++)
{
    Console.WriteLine($"{i+1}: {cibi[i]}");

}
Console.WriteLine($"\n");

//-Il vostro cibo top (prima posizione della classifica)
Console.WriteLine($"il tuo preferito è: {cibi[0]} \n");



//-Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Console.WriteLine($"quello che meno ti piace: {cibi[cibi.Length - 1]} \n");


//**BONUS**
//Stampate a video anche il cibo di mezza classifica,
//cioè che si trova nella posizione **mediana.**
//Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
//In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.
//****

var mediana = cibi.Length / 2;




//se la length è pari
if (cibi.Length % 2 == 0)
{
    Console.Write($"i cibi a metà sono: \n" +
        $"{mediana}: {cibi[mediana-1]} \n" +
        $"{mediana+1}: {cibi[mediana]} ");
}
//se la length è dispari
else
{
    Console.Write($"il cibo a metà è {mediana+1}: {cibi[mediana]}");

}




Console.WriteLine($"\n\n\n\n\n\n\n\n");