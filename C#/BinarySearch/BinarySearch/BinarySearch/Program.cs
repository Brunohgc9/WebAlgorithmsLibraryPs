using System.Diagnostics;
using System.Xml.Linq;
using BinarySearch.MethodsToBeBenchmarked;

Random rnd = new Random();
int listLength = rnd.Next(0, 999999999);
List<int> numberList = Enumerable.Range(0, listLength).ToList();

int targetNumber = rnd.Next(0, listLength);

BinarySearchAlgorithm binarySearch = new BinarySearchAlgorithm();
LinearSearchAlgorithm linearSearch = new LinearSearchAlgorithm();
Stopwatch benchmarkTimer = new Stopwatch();

void Benchmark(string methodName, Func<List<int>, int, int> defaulBehaviorOfSearchFunctions)
{
    benchmarkTimer.Restart();
    int attempts = defaulBehaviorOfSearchFunctions(numberList, targetNumber);
    benchmarkTimer.Stop();

    Console.WriteLine($"{methodName} Benchmark: {benchmarkTimer.ElapsedMilliseconds} ms | List Length: {listLength} | Target: {targetNumber} | Attempts: {attempts}");

}

Benchmark("Binary Search", binarySearch.BinarySearchMethod);
Benchmark("Linear Search", linearSearch.LinearSearchMethod);
