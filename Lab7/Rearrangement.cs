using System.Collections.Generic;

namespace Lab7
{
    class Rearrangement
    {
        public List<List<int>> Rearrange(List<List<int>> array)
        {
            int indexOf1stColumn = FindColumnWithSecondEven(array);
            int indexOf2ndColumn = FindColumnWirhNegative(array);
            for(int i = 0; i < array.Count; i++)
            {
                int temporary = array[i][indexOf1stColumn];
                array[i].RemoveAt(indexOf1stColumn);
                array[i].Insert(indexOf1stColumn, array[i][indexOf2ndColumn-1]);
                
                array[i].RemoveAt(indexOf2ndColumn);
                array[i].Insert(indexOf2ndColumn, temporary);

            }
            return array;
        }

        public int FindColumnWithSecondEven(List<List<int>> array)
        {
            int index = 0;
            for(int j = 0;j< array[1].Count ; j++)
            {
                if (array[1][j] % 2 == 0)
                {
                    index = j;
                    break;
                }
            }
            return index;
        }

        public int FindColumnWirhNegative(List<List<int>> array)
        {
            int index = 0;
            for (int j = array[0].Count-1; j >0; j--)
            {
                if (array[0][j]<0)
                {
                    index = j;
                    break;
                }
                else
                {
                    index = 0;
                }
            }
            return index;
        }
    }
}
