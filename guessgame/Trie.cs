



public class LL
{
    private Node root;
 

    public LL()
    {
        root = new Node();
       
    }

    public bool InsertWord(string word)
    {
        if (word.Length > 0 && word[word.Length - 1] == word[word.Length - 2] && word[word.Length - 2] == word[word.Length - 3])
        {
            Console.WriteLine($"Error: '{word}' is incorrect.");
            return false;
        }

        Node currNode = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (currNode.Children[index] == null)
            {
                currNode.Children[index] = new Node();
            }
            currNode = currNode.Children[index];
        }
        currNode.Terminating = true;

        return true;
    }

    public bool SearchWord(string word)
    {
        Node currNode = root;
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
        Node currNode = root;
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

    public void todisplay()
    {

        LL oTrie = new LL();
        List<string> words = new List<string> { "cat", "ball", "arham", "muddasir", "icecream", "dictionary" };
        foreach (string word in words)
        {
            oTrie.InsertWord(word);
        }

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add word");
            Console.WriteLine("2. Search word");
            Console.WriteLine("3. Delete word");
            Console.WriteLine("4. Show word list");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the word to add: ");
                    string addWord = Console.ReadLine();

                    if (addWord.Any(c => !char.IsLetter(c)))
                    {
                        Console.WriteLine("Please use only letters (a-z) in the word.");
                    }

                    else if(addWord.Length < 2)
                    {
                        Console.WriteLine("Plase enter correct word");

                    }
                    else if (words.Contains(addWord))
                    {
                        Console.WriteLine($"'{addWord}' already exists in the list.");
                    }
                    else if (oTrie.InsertWord(addWord))
                    {
                        Console.WriteLine($"'{addWord}' added.");
                        words.Add(addWord);
                    }
                    break;


                case 2:
                    Console.Write("Enter the word to search: ");
                    string searchWord = Console.ReadLine();
                    if (oTrie.SearchWord(searchWord))
                    {
                        Console.WriteLine($"'{searchWord}' is found.");
                    }
                    else
                    {
                        Console.WriteLine($"'{searchWord}' is not found.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the word to delete: ");
                    string deleteWord = Console.ReadLine();
                    if (oTrie.DeleteWord(deleteWord))
                    {
                        Console.WriteLine($"'{deleteWord}' deleted.");
                        words.Remove(deleteWord);
                    }
                    else
                    {
                        Console.WriteLine($"'{deleteWord}' not found.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Word List:");
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }
                    break;

                case 5:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }

    }
}
