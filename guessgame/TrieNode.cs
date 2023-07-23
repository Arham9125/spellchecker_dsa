public class TrieNode
{
    public bool Terminating { get; set; }
    public TrieNode[] Children { get; set; }

    public TrieNode()
    {
        Terminating = false;
        Children = new TrieNode[26];
    }
}