SmallestIntegerOverZeroNotAlreadyExisting testArray = new();
int[] test = { 1, 3, 6, 4, 1, 2, 8, 5 };
Console.WriteLine($"With Hashset: {testArray.ArraySolutionWithHashset(test)}");
Console.WriteLine($"Without Hashset: {testArray.ArraySolutionWithoutHashSet(test)}");

public class SmallestIntegerOverZeroNotAlreadyExisting
{
    //Uses more space
    public int ArraySolutionWithHashset(int[] aValue)
    {
        HashSet<int> SetNumbers = new HashSet<int>(aValue);

        int smallestInt = 1;
        while (SetNumbers.Contains(smallestInt))
        {
            smallestInt++;
        }

        return smallestInt;
    }
    //Uses less space
    public int ArraySolutionWithoutHashSet(int[] a)
    {
        int n = a.Length;
        bool[] present = new bool[n + 1];

        for (int i = 0; i < n; i++)
        {
            if (a[i] > 0 && a[i] <= n)
            {
                present[a[i]] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (!present[i])
            {
                return i;
            }
        }

        return n + 1;
    }
}

// Write a function in c#:
//
// class Solution { public int solution(int[] A); }
//
// that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
//
// For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
//
//     Given A = [1, 2, 3], the function should return 4.
//
//     Given A = [−1, −3], the function should return 1.
//
//     Write an efficient algorithm for the following assumptions:
//
// N is an integer within the range [1..100,000];
// each element of array A is an integer within the range [−1,000,000..1,000,000].
//