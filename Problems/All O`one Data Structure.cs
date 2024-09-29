using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class AllOne
    {
        Dictionary<string, int> data;
        Dictionary<int, List<string>> count;
        HashSet<int> indexs;

        public AllOne()
        {
            data = new Dictionary<string, int>();
            count = new Dictionary<int, List<string>>();
            indexs = new HashSet<int>();
        }

        public void Inc(string key)
        {
            if (data.ContainsKey(key))
            {
                RemoveFromCount(data[key], key);
                data[key]++;
                AddToCount(data[key], key);
            }
            else
            {
                data[key] = 1;
                AddToCount(1, key);
            }
        }

        public void Dec(string key)
        {
            if (data.ContainsKey(key))
            {
                RemoveFromCount(data[key], key);
                data[key]--;

                if (data[key] != 0)
                    AddToCount(data[key], key);
                else
                    data.Remove(key);
            }
        }

        public string GetMaxKey()
        {
            if (indexs.Count == 0) return "";
            int maxCount = int.MinValue;
            foreach (var count in indexs)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return count[maxCount].Count > 0 ? count[maxCount][0] : "";
        }

        public string GetMinKey()
        {
            if (indexs.Count == 0) return "";
            int minCount = int.MaxValue;
            foreach (var count in indexs)
            {
                if (count < minCount)
                {
                    minCount = count;
                }
            }
            return count[minCount].Count > 0 ? count[minCount][0] : "";
        }

        private void AddToCount(int key, string value)
        {
            if (!count.ContainsKey(key))
                count[key] = new List<string>();

            count[key].Add(value);
            indexs.Add(key);
        }

        private void RemoveFromCount(int key, string value)
        {
            count[key].Remove(value);

            if (count[key].Count == 0)
            {
                indexs.Remove(key);
                count.Remove(key);
            }
        }
    }

    /**
     * Your AllOne object will be instantiated and called as such:
     * AllOne obj = new AllOne();
     * obj.Inc(key);
     * obj.Dec(key);
     * string param_3 = obj.GetMaxKey();
     * string param_4 = obj.GetMinKey();
     */
}
