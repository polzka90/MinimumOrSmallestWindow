using System.Xml.Schema;

namespace MinimumOrSmallestWindow;

public class WindowFinder : IWindowFinder
{
    private static int _noOfChars = 256;
    
    /// <summary>
    /// Time Complexity:  O(N), where N is the length of string. 
    /// Auxiliary Space: O(1)
    /// </summary>
    /// <param name="input"></param>
    /// <param name="pattern"></param>
    /// <returns></returns>
    public string CalculateWindowByHashing(string input, string pattern)
    {
        string output = string.Empty;

        int inputLength = input.Length;
        int patternLength = pattern.Length;

        
        // Check if string's length is
        // less than pattern's
        // length. If yes then no such
        // window can exist
        if (inputLength < patternLength)
        {
            Console.WriteLine("no such window can exist");
            return output;
        }

        int[] hashInput = new int[_noOfChars];
        int[] hashPattern = new int[_noOfChars];
        
        // Store occurrence ofs characters
        // of pattern
        for (int i = 0; i < patternLength; i++)
            hashPattern[pattern[i]]++;
        
        int start = 0, startIndex = -1,
            minLen = int.MaxValue;
        
        int count = 0;
        for (int j = 0; j < inputLength; j++) {
           
            // Count occurrence of characters
            // of string
            hashInput[input[j]]++;
 
            // If string's char matches
            // with pattern's char
            // then increment count
            if (hashInput[input[j]] <= hashPattern[input[j]])
                count++;
 
            // if all the characters are matched
            if (count == patternLength) {
               
                // Try to minimize the window
                while (hashInput[input[start]]
                       > hashPattern[input[start]]
                       || hashPattern[input[start]] == 0) {
 
                    if (hashInput[input[start]]
                        > hashPattern[input[start]])
                        hashInput[input[start]]--;
                    start++;
                }
 
                // update window size
                int lenWindow = j - start + 1;
                if (minLen > lenWindow) {
                    minLen = lenWindow;
                    startIndex = start;
                }
            }
        }
        
        // If no window found
        if (startIndex == -1) {
            Console.WriteLine("No such window exists");
            return String.Empty;
        }
        output = input.Substring(startIndex, minLen);
        return output;
    }

    /// <summary>
    /// Time complexity: O(N),where N is the length of string s.
    /// Space complexity: O(N),since we are using Hash Map for storing the characters.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="pattern"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string CalculateWindowByBruteForce(string input, string pattern)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Time Complexity:  O(N), where N is the length of string s. 
    /// Auxiliary Space: O(1)
    /// </summary>
    /// <param name="input"></param>
    /// <param name="pattern"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string CalculateWindowBySlidingWindow(string input, string pattern)
    {
        throw new NotImplementedException();
    }
}