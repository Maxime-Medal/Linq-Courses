using Bogus;
using LinqExercise;
using System;
using System.Linq;
Randomizer.Seed = new Random(1);

var personFaker = new Faker<People>()
    .RuleFor(p => p.FirstName, f => f.Person.FirstName)
    .RuleFor(p => p.LastName, l => l.Person.LastName)
    .RuleFor(p => p.Age, a => (int)DateTime.Today.Subtract(a.Person.DateOfBirth).TotalDays / 365);

var adressFaker = new Faker<Address>()
    .RuleFor(a => a.Id, f => f.IndexFaker)
    .RuleFor(a => a.AdressPostal, f => f.Address.FullAddress());

var personnes = personFaker.Generate(100);
var addresses = adressFaker.Generate(25);
var personnes2 = new List<People>(100);

for (int p = 0; p < 100; p++)
{
    if (p % 5 == 0)
    {
        personnes2.Add(personnes[p].Clone());
    }else
    {
        personnes2.Add(personFaker.Generate());
    }
}

// ---------------------- Random ----------------------
// ---------------------------------------------------
foreach (var person in personnes)
{
    int childNumber = Random.Shared.Next(0, 6);
    person.Children = personFaker.Generate(childNumber);
}
int[] index = new int[100];
int i = 0;
int j = 0;
foreach (var person in personnes)
{
    int childNumber = i % 6; 
    person.Children = personFaker.Generate(childNumber);
    index[i] = i;
    i++;
    person.AddressId = j;
    if(i % 4 == 0)
    {
        j ++;
    }
}

// ---------------------- Where ----------------------
// ---------------------------------------------------

//var personsOver30Years = personnes.Where(p => p.Age > 30);

//foreach (var person in personsOver30Years)
//{
//    Console.WriteLine($"{person.FirstName} - {person.Age} ");
//}

// ---------------------- Take ----------------------
// ---------------------------------------------------

//var first10 = personnes.Take(10);

//foreach (var person in first10)
//{
//    Console.WriteLine($"{person.LastName} {person.FirstName} - {person.Age} ");
//}

//Console.WriteLine("inf à 70 ans");
//var personUntil50 = personnes.TakeWhile(p => p.Age <= 70);

//foreach (var person in personUntil50)
//{
//    Console.WriteLine($"{person.LastName} {person.FirstName} - {person.Age} ");
//}

// ---------------------- Skip ----------------------
// ---------------------------------------------------

// aller à la page x contrenant y element
//var personsOnPage = PersonOnChoosePage(personnes, 3, 15);

//foreach (var person in personsOnPage)
//{
//    Console.WriteLine($"{person.LastName} {person.FirstName} - {person.Age} ");
//}

//List<People> PersonOnChoosePage (List<People> personnes, int page, int rangePers = 15)
//{
//    var startCount = (page - 1) * rangePers;
//    var data = personnes.Take(startCount..(startCount + rangePers));
//    var sameData = personnes.Skip(startCount).Take(rangePers);

//    return sameData.ToList();
//}

// ---------------------- DistinctBy ----------------------
// ---------------------------------------------------

//var personsAgeDisctinct = personnes
//    .DistinctBy(personnes => personnes.Age)
//    .OrderByDescending(p => p.Age);

//foreach (var person in personsAgeDisctinct)
//{
//    Console.WriteLine($"{person.LastName} {person.FirstName} - {person.Age} ");
//}

// Select
//Liste de "Person" => list de "string"
//var allFirstName = personnes.Select(p => p.FirstName);

//foreach (var item in allFirstName)
//{
//    Console.WriteLine(item);
//    //Console.WriteLine($"{item.LastName} {item.FirstName} - {item.Age} ");

//}

// ---------------------- SelectMany ----------------------
// ---------------------------------------------------

// récupérer tout les enfants de toutes les personnes
//Tous les prénoms de tous les enfants

//Console.WriteLine("allChild");
//var chirldrens = personnes.SelectMany(pers => pers.Children);

//foreach (var item in chirldrens)
//{
//    Console.WriteLine($"{item.LastName} {item.FirstName} - {item.Age} ");
//}
//Console.WriteLine(chirldrens.Count());

//Console.WriteLine("allChirlFirstName");
//var childrensFirstnames = personnes.SelectMany(p => p.Children, (p, c) => c.FirstName);
//foreach (var item in childrensFirstnames)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(childrensFirstnames.Count());

// ---------------------- OrderBy ----------------------
// ---------------------------------------------------

//var personsByAgeThenNameAndFirstName = personnes
//    .OrderBy(a => a.Age)
//    .ThenBy(p => p.LastName)
//    .ThenBy(p => p.FirstName);

//foreach (var person in personsByAgeThenNameAndFirstName)
//{
//    Console.WriteLine($"{person.LastName} {person.FirstName} - {person.Age} ");
//}

// ---------------------- GroupBy ----------------------
// ---------------------------------------------------

// grouper les personnes par age et par ordre croissant.
//var personsGoupedByAge = personnes
//    .GroupBy(p => p.Age, e => new { e.FirstName, e.LastName})
//    .OrderBy(p => p.Key); // attention prendre en compte la Key

//foreach (var item in personsGoupedByAge)
//{
//    Console.WriteLine($"personnes qui ont {item.Key} ans");
//    foreach (var p in item)
//    {
//        Console.WriteLine($"    {p.FirstName} {p.LastName}");
//    }
//}

// ---------------------- Chunk ----------------------
// ---------------------------------------------------

//var chunkedPersons = personnes.Chunk(40);

//foreach (var item in chunkedPersons)
//{
//    Console.WriteLine($"Paquets de {item.Length} persones");
//}

// ---------------------- Join ----------------------
// ---------------------------------------------------

//var personnesWithAddress = personnes.Join(addresses, p => p.AddressId, a => a.Id, (person, adress) => 
//new { person, adress});
//foreach (var item in personnesWithAddress.OrderBy(p => p.person.LastName))
//{
//    Console.WriteLine($"{item.person.LastName} {item.person.FirstName} habite à : {item.adress.AddressPostal}");
//}

// --------------------- GroupJoin ---------------------
// ------------------------------------------

//// on groupe sur la propriété en commun puis on crée son objet anonyme
//var personsAtSameAddres = addresses.GroupJoin(personnes, a => a.Id, p => p.AddressId, (a, ps) => new { Adress = a, Persons = ps});

//foreach (var item in personsAtSameAddres)
//{
//    Console.WriteLine($"personne à l'addresse : {item.Adress.AdressPostal}");
//    foreach (var p in item.Persons)
//    {
//        Console.WriteLine($"{p.FirstName} {p.LastName}");
//    }
//}

// --------------------- Zip ---------------------
// ------------------------------------------

// lier les index avec  les personne | la personne à l'index x s'apelle xxx xxx

//var PersonNameAtIndex = index.Zip(personnes, (i, p) => new {i, p});
//var PersonNameAtIndex = index.Zip(personnes, (i, p) => $"a personne à l'index {i} est : {p.FirstName}"); // création d'un string ou d'un objet anonyme

//foreach (var item in PersonNameAtIndex)
//{
//    Console.WriteLine(item);
//}

// --------------------- Concat ---------------------
// ------------------------------------------

//var allPersons = personnes.Concat(personnes.SelectMany(p => p.Children)); // le selectMany vient mettre à plate la liste des enfants pour l'ajouter à la liste

//int v = 0;
//foreach (var person in allPersons)
//{
//    v++;
//    Console.WriteLine($"{v} - {person.FirstName} {person.LastName}");

//}
//Console.WriteLine(allPersons.Count());

// --------------------- Union & UnionBy --------------------- 
// ------------------------------------------

// créer la liste de toute les personnes différentes 

//var unionedPersons = personnes.UnionBy(personnes2, p => (p.FirstName, p.LastName));
//foreach (var item in unionedPersons.OrderBy(p => p.LastName))
//{
//    Console.WriteLine($"{item.FirstName} {item.LastName}");
//}
//Console.WriteLine(unionedPersons.Count());


// --------------------- Intersect & intersecptby --------------------- 
// ------------------------------------------

// récupérer les personnes dans les deux collections

var commonPersons = personnes.IntersectBy(personnes2.Select(p => (p.LastName, p.FirstName)), n => (n.LastName, n.FirstName));

    Console.WriteLine("Personnes en communs");
Console.WriteLine(commonPersons.Count());
foreach (var item in commonPersons)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}