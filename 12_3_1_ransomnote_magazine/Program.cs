Solution mysol = new Solution();
Console.WriteLine($"CanConstruct(r: a,  m:   b) should be false -> {mysol.CanConstruct("a", "b")}\n\n");
Console.WriteLine($"CanConstruct(r: aa, m:  ab) should be false -> {mysol.CanConstruct("aa", "ab")}\n\n");
Console.WriteLine($"CanConstruct(r: aa, m: aab) should be true  -> {mysol.CanConstruct("aa", "aab")}");

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> myDict = new();
        // count # of chars that are required for ransom note 
        foreach (char c in magazine)
        {
            if (myDict.ContainsKey(c))
                myDict[c]++;
            else
                myDict.Add(c, 1);
        }

        // print out myDict for awareness
        Console.WriteLine("Magazine contains: ");
        foreach (KeyValuePair<char, int> kvp in myDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        //bool ret = true;
        foreach (char r in ransomNote)
        {
            if (myDict.ContainsKey(r))
            {
                if (myDict[r] <= 0)
                {
                    return false; //ret = false; 
                    //break;
                }
                myDict[r]--;
            }
            else
            {
                return false; //ret = false;
                //break;
            }
        }
        //Console.WriteLine($"CanConstruct returns {ret}");
        return true; //return ret;
    }
}