
public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return RunningTotal.runTotal(FizzBuzz.FizzBuzzSimple(xs));
    }
}
