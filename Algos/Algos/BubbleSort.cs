using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
  public class BubbleSort
  {
    private int[] InputArray;
    private int[] OutputArray;
    

    public BubbleSort(int[] array)
    {
      InputArray = array;
      OutputArray=new int[array.Length];
    }

    public int[] BubbleSortElements()
    {
      InputArray.CopyTo(OutputArray,0);
      for (int i = OutputArray.Length-1; i >0; i--)
      {
        for (int j = 0; j < i; j++)
        {
          if (OutputArray[j] > OutputArray[j + 1])
          {
            SwapElementsInArray(j, j + 1);
          }
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
