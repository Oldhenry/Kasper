using System;
using System.Collections.Generic;

namespace QueueLibrary
{
    public class CollectionHelper
    {
        public int Number { get; set; } = 0;
        public List<string> BaseList;

        public List<Tuple<int,int>> GetData()
        {
            if (BaseList == null || Number==0)
                return null;

            var ignoreList = new HashSet<int>();
            var resultLst = new List<Tuple<int, int>>();

            for (int i = 0; i < BaseList.Count - 1; i++)
            {
                if (ignoreList.Contains(i))
                    continue;

                for (int j = i + 1; j < BaseList.Count; j++)
                    if (int.Parse(BaseList[i]) + int.Parse(BaseList[j]) == 13)
                    {
                        ignoreList.Add(j);
                        Console.WriteLine($"{BaseList[i]} + {BaseList[j]} (position {i + 1} and {j + 1})");
                        resultLst.Add(new Tuple<int, int>(i + 1, j + 1 ));
                        break;
                    }
            }
            return resultLst;
        }
    }
}
