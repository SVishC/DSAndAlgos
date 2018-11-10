using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
  public class InsertionSort
  {

    private int[] InputArray;
    private int[] OutputArray;


    public InsertionSort(int[] array)
    {
      InputArray = array;
      OutputArray = new int[array.Length];
    }

    public int[] InsertionSortElements()
    {
      InputArray.CopyTo(OutputArray, 0);

      for (int unsortedArrayStartIndex = 1; unsortedArrayStartIndex < OutputArray.Length; unsortedArrayStartIndex++)
      {
        int elementToBeInserted = OutputArray[unsortedArrayStartIndex];

        int i;

        for (i = unsortedArrayStartIndex; i > 0 && OutputArray[i - 1] > elementToBeInserted; i--)
        {
         // if (OutputArray[i - 1] > elementToBeInserted)
            OutputArray[i] = OutputArray[i - 1];
         // else break;
        }

        OutputArray[i] = elementToBeInserted;
      }

      return OutputArray;
    }
  }
}
