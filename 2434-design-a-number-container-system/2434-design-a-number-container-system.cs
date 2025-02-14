public class NumberContainers
{
    // Maps index to number
    private Dictionary<int, int> IndexToNumber = new Dictionary<int, int>();

    // Maps number to a sorted set of indices
    private Dictionary<int, SortedSet<int>> NumberToIndices = new Dictionary<int, SortedSet<int>>();

    public NumberContainers()
    {
    }

    public void Change(int index, int number)
    {
        // If the index already has a number, remove it from the old number's indices
        if (IndexToNumber.ContainsKey(index))
        {
            int oldNumber = IndexToNumber[index];
            NumberToIndices[oldNumber].Remove(index);

            // If the old number has no more indices, remove it from the dictionary
            if (NumberToIndices[oldNumber].Count == 0)
            {
                NumberToIndices.Remove(oldNumber);
            }
        }

        // Update the index with the new number
        IndexToNumber[index] = number;

        // Add the index to the new number's indices
        if (!NumberToIndices.ContainsKey(number))
        {
            NumberToIndices[number] = new SortedSet<int>();
        }
        NumberToIndices[number].Add(index);
    }

    public int Find(int number)
    {
        if (NumberToIndices.ContainsKey(number))
        {
            // Return the smallest index for the number
            return NumberToIndices[number].Min;
        }
        else
        {
            return -1;
        }
    }
}