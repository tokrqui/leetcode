namespace Solution;

public class SolutionComponent {
    public int LengthOfLongestSubstring(string s)
    {
        var chars = s.ToCharArray();
        var currentWord = new HashSet<char>();
        var charSet = new HashSet<char>();

        foreach (var ch in chars) {
            charSet.Add(ch);
        }

        for (int w = charSet.Count; w > 0; w--)
        {
            bool hasWord = false;
            for (int start = 0; start <= chars.Length - w; start++)
            {
                currentWord.Clear();

                for (int i = start; i < start + w; i++)
                {
                    var ch = chars[i];
                    if (currentWord.Contains(ch))
                    {
                        currentWord.Clear();
                    }
                    currentWord.Add(ch);
                }
                if (currentWord.Count == w)
                {
                    hasWord = true;
                }
            }
            if (hasWord)
            {
                return w;
            }
        }

        return 0;
    }
}