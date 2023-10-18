namespace MinimumOrSmallestWindow;

public interface IWindowFinder
{
    string CalculateWindowByHashing(string input, string pattern);
    string CalculateWindowByBruteForce(string input, string pattern);
    string CalculateWindowBySlidingWindow(string input, string pattern);
}