using Bogus;
using ExercicesLinq;

Randomizer.Seed = new Random(1);

var faker = new Faker<Personne>()
    .RuleFor(p => p.Nom, f => f.Person.LastName)
    .RuleFor(p => p.Prenom, f => f.Person.FirstName)
    .RuleFor(p => p.Age, f => (int)DateTime.Today.Subtract(f.Person.DateOfBirth).TotalDays / 365);

var adresseFaker = new Faker<Adresse>()
    .RuleFor(p => p.Id, f => f.IndexFaker)
    .RuleFor(p => p.AdressePostale, f => f.Address.FullAddress());

var personnes = faker.Generate(100);
var adresses = adresseFaker.Generate(25);
var personnes2 = new List<Personne>(100);
for (int x = 0; x < 100; x++)
{
    if (x % 5 == 0)
    {
        personnes2.Add(personnes[x].Clone());
    }
    else
    {
        personnes2.Add(faker.Generate());
    }
}

int[] index = new int[100];
int i = 0;
int j = 0;
foreach (var personne in personnes)
{
    int nbEnfant = i % 6;
    personne.Enfants = faker.Generate(nbEnfant);
    personne.IdAdresse = j;
    index[i] = i;
    i++;
    if (i % 4 == 0)
    {
        j++;
    }
}

// Where
/*var personnePlusVieilleQueTrenteAns
    = personnes.Where(p => p.Age > 30);

foreach (var item in personnePlusVieilleQueTrenteAns)
{
    Console.WriteLine($"{item.Nom} {item.Prenom} a {item.Age} ans");
}*/

// Take
/*var dixPremieresPersonnes
    = personnes.Take(10);

foreach (var item in dixPremieresPersonnes)
{
    Console.WriteLine($"{item.Nom} {item.Prenom}");
}

var tantQueMoinsDe70Ans =
    personnes.TakeWhile(p => p.Age <= 70);

foreach (var item in tantQueMoinsDe70Ans)
{
    Console.WriteLine($"{item.Nom} {item.Prenom} a {item.Age} ans");
}*/

// Skip

/*Console.WriteLine("Taille de page");
int taille = int.Parse(Console.ReadLine());
Console.WriteLine("Page n°");
int page = int.Parse(Console.ReadLine());

var personnesPaginees = personnes.Skip((page - 1) * taille)
    .Take(taille);

foreach (var item in personnesPaginees)
{
    Console.WriteLine($"{item.Nom} {item.Prenom} a {item.Age} ans");
}*/

// Distinct

/*var personnesDistinctesParAge
    = personnes.DistinctBy(p => p.Age);

foreach (var item in personnesDistinctesParAge)
{
    Console.WriteLine($"{item.Nom} {item.Prenom} a {item.Age} ans");
}*/

// select

/*var prenoms = personnes.Select(p => p.Prenom);

foreach (var item in prenoms)
{
    Console.WriteLine(item);
}*/

// select many

/*var enfants = personnes.SelectMany(p => p.Enfants);

foreach (var item in enfants)
{
    Console.WriteLine($"{item.Nom} {item.Prenom} a {item.Age} ans");
}

var prenomsEnfants = personnes.SelectMany(p => p.Enfants, (_, enfant) => enfant.Prenom);

foreach (var item in prenomsEnfants)
{
    Console.WriteLine(item);
}*/

// order by

/*var personneParAgePuisNomPuisPrenom
    = personnes.OrderBy(p => p.Age)
    .ThenBy(p => p.Nom)
    .ThenBy(p => p.Prenom);

foreach (var item in personneParAgePuisNomPuisPrenom)
{
    Console.WriteLine($"{item.Nom} {item.Prenom} a {item.Age} ans");
}*/

// group by

/*
var personnesParAge
    = personnes.GroupBy(p => p.Age, p => new { p.Nom, p.Prenom });

foreach (var item in personnesParAge.OrderBy(p => p.Key))
{
    Console.WriteLine($"Toutes les personnes qui ont {item.Key} ans");
    foreach (var personne in item)
    {
        Console.WriteLine($"{personne.Nom} {personne.Prenom}");
    }
}
*/

// join

/*var personnesAvecAdresse = personnes.Join(adresses, p => p.IdAdresse, a => a.Id, (personne, adresse) => new { personne, adresse });

foreach (var item in personnesAvecAdresse)
{
    Console.WriteLine($"{item.personne.Nom} {item.personne.Prenom} habite à {item.adresse.AdressePostale}");
}*/

// group join
/*
var adressesEtPersonnes = adresses.GroupJoin(personnes, a => a.Id, p => p.IdAdresse,
    (a, ps) => new { Adresse = a, Personnes = ps });

foreach (var item in adressesEtPersonnes)
{
    Console.WriteLine($"Personnes habitant à {item.Adresse.AdressePostale}");
    foreach (var personne in item.Personnes)
    {
        Console.WriteLine($"{personne.Nom} {personne.Prenom}");
    }
}
*/

// Zip
/*var personnesEtIndex = personnes.Zip(index, (p, i) => $"Personne à l'index {i} = {p.Nom} {p.Prenom}");
foreach (var item in personnesEtIndex)
{
    Console.WriteLine(item);
}*/

// concat

/*int v = 0;
var toutesLesPersonnes = personnes.Concat(personnes.SelectMany(p => p.Enfants));
foreach (var personne in toutesLesPersonnes)
{
    //Console.WriteLine($"{v}. {personne.Nom} {personne.Prenom}");
    v++;
}*/

// union
/*
var toutesLesPersonnes = personnes.UnionBy(personnes2, p => (p.Nom, p.Prenom));
foreach (var personne in toutesLesPersonnes.OrderBy(p => p.Nom))
{
    Console.WriteLine($"{personne.Nom} {personne.Prenom}");
}*/

// intersect

/*var personnesCommunes = personnes.IntersectBy(
    personnes2.Select(p => (p.Nom, p.Prenom)), p => (p.Nom, p.Prenom));

foreach (var item in personnesCommunes)
{
    Console.WriteLine($"{item.Nom} {item.Prenom}");
}*/

// except
/*var personnesNonCommunes = personnes.ExceptBy(
    personnes2.Select(p => (p.Nom, p.Prenom)), p => (p.Nom, p.Prenom));

foreach (var item in personnesNonCommunes)
{
    Console.WriteLine($"{item.Nom} {item.Prenom}");
}/*

// First, Last
/*var personnesTriees = personnes.OrderBy(p => p.Nom);

var premierePersonne = personnesTriees.First();
var dernierPersonne = personnesTriees.Last();

Console.WriteLine($"{premierePersonne.Nom} {premierePersonne.Prenom}");
Console.WriteLine($"{dernierPersonne.Nom} {dernierPersonne.Prenom}");*/

// MinBy, MaxBy

/*var personnePlusJeune = personnes.OrderByDescending(p => p.Nom).MinBy(p => p.Age);
var personnePlusVieille = personnes.MaxBy(p => p.Age);

Console.WriteLine($"{personnePlusJeune!.Nom} {personnePlusJeune.Prenom} a {personnePlusJeune.Age} ans");
Console.WriteLine($"{personnePlusVieille!.Nom} {personnePlusVieille.Prenom} a {personnePlusVieille.Age} ans");

foreach (var item in personnes.Where(p => p.Age == 20))
{
    Console.WriteLine($"{item!.Nom} {item.Prenom} a {item.Age} ans");
}
foreach (var item in personnes.Where(p => p.Age == 69))
{
    Console.WriteLine($"{item!.Nom} {item.Prenom} a {item.Age} ans");
}*/

// defaultifempty

/*var personneInconnue = personnes.Where(p => p.Age > 68).DefaultIfEmpty(new Personne
{
    Nom = "Inconnu",
    Prenom = "Inconnu",
    Age = 70
}).First();
Console.WriteLine($"{personneInconnue!.Nom} {personneInconnue.Prenom} a {personneInconnue.Age} ans");*/

// count

/*var total = personnes.Count() + personnes.SelectMany(p => p.Enfants).Count();

Console.WriteLine($"Il y a {total} personnes");

var personnesPlusDe50ans = personnes.Count(p => p.Age > 50);

Console.WriteLine($"Il y a {personnesPlusDe50ans} personnes qui ont plus de 50 ans");
*/

// min max

/*var ageMini = personnes.Min(p => p.Age);
var ageMax = personnes.Max(p => p.Age);

Console.WriteLine("Age minimum : " + ageMini);
Console.WriteLine("Age maximum : " + ageMax);*/

//sum

/*var compteDeTousLesEnfants = personnes.Sum(p => p.Enfants.Count);
Console.WriteLine("Tous les enfants : " + compteDeTousLesEnfants);*/

// average

//var ageMoyen = personnes.Average(p => p.Age);
//Console.WriteLine("Age moyen : " + ageMoyen);

// aggregate

var result = personnes.Aggregate(new HashSet<char>(),
    (lettres, p) =>
    {
        foreach (var item in p.Nom)
        {
            lettres.Add(item);
        }
        return lettres;
    });

foreach (var item in result.OrderBy(v => v))
{
    Console.WriteLine(item);
}