using System;

class Program {
    static void Main(string[] args) {

        Console.Write("Input Range : ");
        int range = int.Parse(Console.ReadLine());
        Console.Write("Input Scope : ");
        int scopefake = int.Parse(Console.ReadLine());
        int scope = scopefake + 3;

        int[] people = new int[range];
        for (int i = 0; i < range; i++) {
            Console.Write("Input People : ");
            people[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = SumFromRange(people, scope);

        Console.WriteLine("Answer is " + maxSum);

    }

    static int SumFromRange(int[] people, int scope) {

        int maxSum = int.MinValue;

        for (int i = 0; i <= people.Length - scope; i++) {
            int sum = 0;

            for (int j = i; j < i + scope; j++) {
                sum += people[j];
            }

            if (sum > maxSum) {
                maxSum = sum;
            }
        }

        return maxSum;
    }
}