using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
  class SelectionSort
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

    private void SwapElementsInArray(int indexOne, int indexTwo)
    {
      int temp = OutputArray[indexOne];
      OutputArray[indexOne] = OutputArray[indexTwo];
      OutputArray[indexTwo] = temp;
    }
  }
}
