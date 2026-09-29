using DemoExpressionLambda;

// Passer un comportement en paramètre à une fonction : Callback 
static bool EstPair(int x)
{
    return x % 2 == 0;
}

List<int> nombres = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
List <int> NombresPairs=nombres.FindAll(EstPair);
foreach (int nb  in NombresPairs)
{
    Console.WriteLine(nb);
}

// Les types délégués génériques Func et Action : une variable qui va contenir une fonction.
//Func<int, bool> fctEstPair = EstPair;
//Action<string> afficher =Console.WriteLine;
//afficher("Salut!,je suis l'action qui prend le role");

// Lambda 
Func<int,bool> fctEstPair =( x) =>   x % 2 == 0; ;
// Expression lambda en Callback (retour à FindAll)
nombres.FindAll(x => x%2==0);
foreach (int x in NombresPairs) {
    Console.WriteLine(x);
}// LINQ et expressions lambda


// Exercice

List<Client> clients = new()
{
    new Client { Id = 1, Prenom = "Léo", Ville = "Gatineau" },
    new Client { Id = 2, Prenom = "Wilona",   Ville = "Montréal" },
    new Client { Id = 3, Prenom = "Rohan",  Ville = "Gatineau" },
    new Client { Id = 4, Prenom = "Luca", Ville = "Ottawa" },
    new Client { Id = 5, Prenom = "Julien",  Ville = "Montréal" },
    new Client { Id = 6, Prenom = "Junior",     Ville = "Sherbrooke" },
    new Client { Id = 7, Prenom = "Jonathan",Ville = "Gatineau" },
    new Client { Id = 8, Prenom = "Kevin",   Ville = "Montréal" }
};

// q1
List<Client> clientsGatineau =clients.Where(c => c.Ville == "Gatineau").ToList();

//q2
List<string> PrenomClients = clients.Select(c=> c.Prenom).ToList();
//q3

//q4
int NombreClient = clients.Count(c => c.Ville == "Montréal");

//q5

