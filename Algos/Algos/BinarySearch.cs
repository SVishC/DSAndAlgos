using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
  public class BinarySearch
  {
    private int[] InputArray;


    public BinarySearch(int[] array)
    {
      InputArray = array;
    }

    public int BinarySearchValue(int Value)
    {
      int resultIndex = -1;
      int lowIndex = 0;
      int highIndex = InputArray.Length-1;

      

      while (lowIndex <= highIndex)
      {
        int middleIndex = (highIndex + lowIndex) / 2;
        if (InputArray[middleIndex] < Value)
        {
          lowIndex = middleIndex + 1;
        }
        else if (InputArray[middleIndex] > Value)
        {
          highIndex = middleIndex - 1;
        }
        else
        {
          resultIndex = middleIndex;
          break;
        }
      }

      return resultIndex;
    }

  }
}
