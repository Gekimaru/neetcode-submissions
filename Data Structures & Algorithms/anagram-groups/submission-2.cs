public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> myDict = new Dictionary<string,List<string>>();
        foreach (string str in strs)
        {
            
            char[] charX = str.ToCharArray();

            Array.Sort(charX);
            string x = new string(charX);
            if(!myDict.ContainsKey(x))
            {
                myDict[x] =  new List<string>();
            }
            myDict[x].Add(str);
        }
        return myDict.Values.ToList();
    }
}
