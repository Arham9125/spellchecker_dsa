public class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    public void InsertWord(string word)
    {
        TrieNode currNode = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (currNode.Children[index] == null)
            {
                currNode.Children[index] = new TrieNode();
            }
            currNode = currNode.Children[index];
        }
        currNode.Terminating = true;
    }

    public bool SearchWord(string word)
    {
        TrieNode currNode = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (currNode.Children[index] == null)
            {
                return false;
            }
            currNode = currNode.Children[index];
        }
        return currNode.Terminating;
    }

    public bool DeleteWord(string word)
    {
        TrieNode currNode = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (currNode.Children[index] == null)
            {
                return false;
            }
            currNode = currNode.Children[index];
        }
        currNode.Terminating = false;
        return true;
    }

    public bool UpdateWord(string oldWord, string newWord)
    {
        bool ret = DeleteWord(oldWord);
        if (ret)
        {
            InsertWord(newWord);
        }
        return ret;
    }
}