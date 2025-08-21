Console.WriteLine("enter the length of the fibonacci series ");
int length = convert.ToInt32(console.Readline());
for (int i = 0; < length; i++)
{
    console.write("{0}", fibonacciSeries);
}
console.Readkay();

static int fibonacciSeries(int n)
{
if ( n == 0 ) return 0; // to the return the first fibonacci number 
if ( n ==1 ) return 1; // to the return the second fibonacci number
return  fibonacciSeries(n - 1 ) + fibonacciSeries(n - 2);
}10