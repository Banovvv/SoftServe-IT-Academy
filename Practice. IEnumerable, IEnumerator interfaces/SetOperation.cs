using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe_IT_Academy.Practice._IEnumerable__IEnumerator_interfaces
{
    public class SetOperation
    {
        public static List<int> Union(List<int> firstSet, List<int> secontSet)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach(int item in firstSet)
            {
                hashSet.Add(item);
            }

            foreach (int item in secontSet)
            {
                hashSet.Add(item);
            }

            List<int> result = new List<int>();

            foreach (var item in hashSet)
            {
                result.Add(item);
            }

            return result;
        }
        public static List<int> Intersect(List<int> firstSet, List<int> secontSet)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (var firstItem in firstSet)
            {
                foreach (var secondItem in secontSet)
                {
                    if (firstItem == secondItem)
                    {
                        hashSet.Add(firstItem);
                    }
                }
            }

            List<int> result = new List<int>();
            
            foreach (var item in hashSet)
            {
                result.Add(item);
            }

            return result;
        }
        public static List<int> LeftDifference(List<int> firstSet, List<int> secondSet)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (var firstItem in firstSet)
            {
                bool isUnique = true;

                foreach (var secondItem in secondSet)
                {
                    if (firstItem == secondItem)
                    {
                        isUnique = false;
                    }
                }

                if (isUnique)
                {
                    hashSet.Add(firstItem);
                }
            }

            List<int> result = new List<int>();

            foreach (var item in hashSet)
            {
                result.Add(item);
            }

            return result;
        }
        public static List<int> RightDifference(List<int> firstSet, List<int> secondSet)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (var secondItem in secondSet)
            {
                bool isUnique = true;

                foreach (var firstItem in firstSet)
                {
                    if (firstItem == secondItem)
                    {
                        isUnique = false;
                    }
                }

                if (isUnique)
                {
                    hashSet.Add(secondItem);
                }
            }

            List<int> result = new List<int>();

            foreach (var item in hashSet)
            {
                result.Add(item);
            }

            return result;
        }
        public static List<int> Addition(List<int> set, List<int> universum)
        {

            List<int> result = new List<int>();

            foreach (var setItem in set)
            {
                foreach (var item in universum)
                {
                    result.Add(setItem + item);
                }
            }

            return result;
        }
    }
}
