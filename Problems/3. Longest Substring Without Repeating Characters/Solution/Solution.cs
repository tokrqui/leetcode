namespace Solution;

public class SolutionComponent {
    public int LengthOfLongestSubstring(string s)
    {
        var chars = s.ToCharArray();
        var positions = new Dictionary<char, int>();
        var longestWord = 0;
        for (int start = 0; start < chars.Length; start++)
        {
            var hs = new HashSet<char>();
            for (int i = start; i < chars.Length; i++)
            {
                var ch = chars[i];
                if (hs.Contains(ch))
                {
                    longestWord = Math.Max(longestWord, hs.Count);
                    hs.Clear();
                }
                hs.Add(ch);
            }
            longestWord = Math.Max(longestWord, hs.Count);

        }
        return longestWord;
    }

    public int LengthOfLongestSubstringOld(string s)
    {
        var chars = s.ToCharArray();
        var hs = new HashSet<char>();

        for (int w = chars.Length; w > 0; w--)
        {
            for (int start = 0; start <= chars.Length - w; start++)
            {
                bool hasCollision = false;
                hs.Clear();

                for (int i = start; i < start + w; i++)
                {
                    var currentChar = chars[i];
                    if (hs.Contains(currentChar))
                    {
                        hasCollision = true;
                        break;
                    }
                    hs.Add(currentChar);
                }
                if (!hasCollision)
                {
                    return hs.Count;
                }
            }
        }

        return 0;
    }
}