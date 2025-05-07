namespace AlgebraLibrary;

public class Algebra
{
    public static double[] RootsOfQuadraticEquations(double[] equation)
    {
        //-b±akar(b^2-4ac)/2a
        //->
        //b^2-4ac <-determinant
        //dont forget to check length && discriminant
        if (equation.Length != 3)
        {
            throw new ArgumentNullException(nameof(equation), "array harus berisi 3 elemen");
        }

        var a = equation[0];
        var b = equation[1];
        var c = equation[2];
        var discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant < 0)
        {
            throw new ArgumentException("Diskriminan kurang dari 0, tidak bisa melanjutkan operasi", nameof(equation));
        }

        var akar1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        var akar2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        return new double[] { akar1, akar2 };
    }

    public static double[] QuadraticResults(double[] equation)
    {
        //-> a^2 + 2ab + b^2
        if (equation.Length != 2)
        {
            throw new ArgumentNullException(nameof(equation),"array harus berisi 2 elemen");
        }

        var a = equation[0];
        var b = equation[1];
        var coefficientX2 = Math.Pow(a, 2);
        var coefficientX = (2 * a * b);
        var constant = Math.Pow(b, 2);

        return new double[] { coefficientX2, coefficientX, constant };
    }
}