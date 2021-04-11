namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
        public int Find(int[] numbers)
        {
            var length = numbers.Length;
            var leftSum = new int[length];
            var rightSum = new int[length];
            leftSum[0] = numbers[0];
            for (int i = 1; i < length; i++)
            {
                leftSum[i] = leftSum[i - 1] + numbers[i];
            }
            rightSum = new int[length];
            rightSum[length - 1] = numbers[length - 1];
            for (int i = length - 2; i >= 0; i--)
            {
                rightSum[i] = rightSum[i + 1] + numbers[i];
            }
            for (int i = 1; i < length - 1; i++)
            {
                if (leftSum[i] == rightSum[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
