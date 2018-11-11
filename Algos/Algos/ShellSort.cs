using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
  public class ShellSort
  {

    private int[] InputArray;
    private int[] OutputArray;


    public ShellSort(int[] array)
    {
      InputArray = array;
      OutputArray = new int[array.Length];
    }

    public int[] ShellSortElements2()
    {
      InputArray.CopyTo(OutputArray, 0);

      for (int gap = OutputArray.Length / 2; gap > 0; gap /= 2)
      {


        for (int i = gap; i < OutputArray.Length; i++)
        {
          int elementToBeInserted = OutputArray[i];

          int j=i;

          while (j >= gap && OutputArray[j - gap] > elementToBeInserted)
          {
            OutputArray[j] = OutputArray[j - gap];
            j = j - gap;
          }

          OutputArray[j] = elementToBeInserted;
          
        }
      }
      return OutputArray;
    }

    public int[] ShellSortElements()
    {
      InputArray.CopyTo(OutputArray, 0);

      for (int gap = OutputArray.Length / 2; gap > 0; gap /= 2)
      {


        for (int i = gap; i < OutputArray.Length; i++)
        {
          int elementToBeInserted = OutputArray[i];

          int j ;

          //can be for (j = i; j-gap>= 0 && OutputArray[j - gap] > elementToBeInserted; j = j - gap)
          //and not for (j = i; j>= 0 && OutputArray[j - gap] > elementToBeInserted; j = j - gap)
          //bcoz lets say when j=1 j>=0 satisfies but j-gap will be a negative value we cannot query a negative index of an array.
          for (j = i; j>= gap && OutputArray[j - gap] > elementToBeInserted; j = j - gap)
          {
            OutputArray[j] = OutputArray[j - gap];
          }

          OutputArray[j] = elementToBeInserted;
        }
      }
      return OutputArray;
    }
  }
}
