public class Node
{
    public bool Terminating { get; set; }
    public Node[] Children { get; set; }

    public Node()
    {
        Terminating = false;
        Children = new Node[26];
    }
}