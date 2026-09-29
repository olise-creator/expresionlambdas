using DemoExpressionLambda;

// Passer un comportement en paramètre à une fonction : Callback 
static bool EstPair(int x)
{
    return x % 2 == 0;
}

List<int> nombres = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

// Les types délégués génériques Func et Action : une variable qui va contenir une fonction.

// Lambda 

// Expression lambda en Callback (retour à FindAll)

// LINQ et expressions lambda


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
