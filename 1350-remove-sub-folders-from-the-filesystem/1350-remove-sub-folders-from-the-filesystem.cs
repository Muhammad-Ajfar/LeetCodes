public class Solution
{
    public IList<string> RemoveSubfolders(string[] folder)
    {
        Array.Sort(folder);  // Sort to bring parents before subfolders
        List<string> result = new List<string>();

        foreach (var path in folder)
        {
            if (result.Count == 0 || !path.StartsWith(result[^1] + "/"))
            {
                result.Add(path);
            }
        }

        return result;
    }
}