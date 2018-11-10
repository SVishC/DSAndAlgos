using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
  public class SelectionSort
  {
    private int[] InputArray;
    private int[] OutputArray;


    public SelectionSort(int[] array)
    {
      InputArray = array;
      OutputArray = new int[array.Length];
    }

    public int[] SelectionSortElements()
    {
      InputArray.CopyTo(OutputArray, 0);

      for (int x = 0; x < OutputArray.Length; x++)
      {
        int minimum = x;
        for (int y = x; y < OutputArray.Length; y++)
        {
          if (OutputArray[minimum] > OutputArray[y])
          {
            minimum = y;
          }
        }
        SwapElementsInArray(x,minimum);
      }

      return OutputArray;
    }

    public int[] SelectionSortElements2()
    {
      InputArray.CopyTo(OutputArray, 0);

      for (int lastUnsortedArrayIndex = OutputArray.Length-1; lastUnsortedArrayIndex > 0; lastUnsortedArrayIndex--)
      {
        int largestElementIndex = 0;
        for (int i = 1; i <= lastUnsortedArrayIndex; i++)
        {
          if (OutputArray[i] > OutputArray[largestElementIndex])
          {
            largestElementIndex = i;
          }

          SwapElementsInArray(largestElementIndex, lastUnsortedArrayIndex);
        }
      }

      return OutputArray;
    }

    private void SwapElementsInArray(int indexOne, int indexTwo)
    {
      int temp = OutputArray[indexOne];
      OutputArray[indexOne] = OutputArray[indexTwo];
      OutputArray[indexTwo] = temp;
    }
  }
}
