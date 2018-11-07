using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
  class Program
  {
    static void Main(string[] args)
    {
      //TBD:input array from user
      int[] inputArrayWithDuplicates = {11, 23, 44, 32, 11, 23, 66, 33, 98, -5, -6, 0, 12, 46};

      int[] inputArrayWithoutDuplicates = {11, 23, 44, 32, 66, 33, 98, -5, -6, 0, 12, 46};

      #region  SearchAlgos

      Console.WriteLine("Enter the element to be searched");
      int valueToSearch=Convert.ToInt32(Console.ReadLine());

      #region BinarySearch

      //To perform a binary search the input array must be sorted.So Sorting 
      BubbleSort bubbleSort = new BubbleSort(inputArrayWithoutDuplicates);
      int[] sortedArray = bubbleSort.BubbleSortElements();
      
      BinarySearch binarySearch=new BinarySearch(sortedArray);
      int resultIndex = binarySearch.BinarySearchValue(valueToSearch);
      PrintArrayElements(sortedArray);

      if(resultIndex!=-1)
      Console.WriteLine($"\n The value is found in the array at the index : {resultIndex}");
      else
        Console.WriteLine("\n Entered Element is not found in the array");

      #endregion

      #endregion

      #region SortAlgos

      #region BubbleSort

      //BubbleSort bubbleSort = new BubbleSort(inputArrayWithDuplicates);
      //int[] sortedArray = bubbleSort.BubbleSortElements();
      //PrintArrayElements(inputArrayWithDuplicates, sortedArray);

      #endregion


      #endregion

    }

    private static void PrintArrayElements(int[] inputArray,int[] sortedArray=null)
    {
      Console.WriteLine("Input array is :");
      foreach (var ele in inputArray)
      {
        Console.Write(ele + " ");
      }

      if (sortedArray != null)
      {
        Console.WriteLine("Sorted array is");
        foreach (var elem in sortedArray)
        {
          Console.Write(elem + " ");
        }
      }
    }

  }
}
