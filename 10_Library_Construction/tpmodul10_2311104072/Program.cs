using AlgebraLibrary;

double[] test1 = { 1, -3, -10 }; 
double[] test2 = { 2, -3 };
double[] result1 = default;
double[] result2 = default;
try
{
    result1 = Algebra.RootsOfQuadraticEquations(test1);
    result2 = Algebra.QuadraticResults(test2);
}
catch (Exception)
{
    Console.WriteLine("Unexpected Error");
}
Console.WriteLine(string.Join(", ", result1));
Console.WriteLine(string.Join(", ", result2));
