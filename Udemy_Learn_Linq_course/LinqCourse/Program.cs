using LinqCourse;
using LinqCourse.CollectionToCollection;
using LinqCourse.CollectionToElement;
//using LinqCourse.CollectionToElement;

// Catégorie 1 = collection => collection

//where
Console.WriteLine("------ WHERE ------");
new Ope_Where().Methode();

//take
Console.WriteLine("------ TAKE ------");
new Ope_Take().Methode();

//skip
Console.WriteLine("------ SKIP ------");
new Ope_Skip().Methode();

//distinct
Console.WriteLine("------ DISTINCT ------");
new Ope_Distinct().Methode();

//select
Console.WriteLine("------ SELECT ------");
new Ope_Select().Methode();

//select many
Console.WriteLine("------ SELECT MANY ------");
new Ope_SelectMany().Methode();

// order by
Console.WriteLine("------ ORDER BY ------");
new Ope_OrderBy().Methode();

// reverse
Console.WriteLine("------ REVERSE ------");
new Ope_Reverse().Methode();

// group by
Console.WriteLine("------ GROUP BY ------");
new Ope_GroupBy().Methode();

// chunk
Console.WriteLine("------ CHUNK ------");
new Ope_Chunk().Methode();

// join
Console.WriteLine("------ JOIN ------");
new Ope_Join().Methode();

// group join
Console.WriteLine("------ GROUP JOIN ------");
new Ope_GroupJoin().Methode();

// zip
Console.WriteLine("------ ZIP ------");
new Ope_Zip().Methode();

// conversion
Console.WriteLine("------ CONVERSION ------");
new Ope_Conversion().Methode();

// concat
Console.WriteLine("------ CONCAT ------");
new Ope_Concat().Methode();

// union
Console.WriteLine("------ UNION ------");
new Ope_Union().Methode();

// intersect
Console.WriteLine("------ INTERSECT ------");
new Ope_Intersect().Methode();

// expect
Console.WriteLine("------ EXCEPT ------");
new Ope_Except().Methode();

// catégorie 2 = collection => élément/valeur scalaire

// first - last
Console.WriteLine("------ FIRST & LAST ------");
new Ope_FirstLast().Methode();

// single
Console.WriteLine("------ SINGLE ------");
new Ope_Single().Methode();

// element at
Console.WriteLine("------ ELEMENT AT ------");
new Ope_ElementAt().Methode();

// minby maxby
Console.WriteLine("------ MINBY & MAXBY ------");
new Ope_MinByMaxby().Methode();

// defaultifempty
Console.WriteLine("------ DEFAULTIFEMPTY ------");
new Ope_DefaultIfEmpty().Methode();

// count
Console.WriteLine("------ COUNT ------");
new Ope_Count().Methode();

// min-max
Console.WriteLine("------ MIN/MAX ------");
new Ope_MinMax().Methode();

// sum
Console.WriteLine("------ SUM ------");
new Ope_Sum().Methode();

// average
Console.WriteLine("------ AVERAGE ------");
new Ope_Average().Methode();

// any
Console.WriteLine("------ ANY ------");
new Ope_Any().Methode();

// all
Console.WriteLine("------ ALL ------");
new Ope_All().Methode();

// contains
Console.WriteLine("------ CONTAINS ------");
new Ope_Contains().Methode();

// sequence equal
Console.WriteLine("------ SEQUENCE EQUAL ------");
new Ope_SequenceEqual().Methode();

// aggregate
Console.WriteLine("------ AGGREGATE ------");
new Ope_Aggregate().Methode();

// catégorie 3 = rien => collection

// generation
Console.WriteLine("------ GENERATION ------");
new Ope_Generation().Methode();
