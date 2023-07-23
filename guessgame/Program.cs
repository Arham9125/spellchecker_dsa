using System;
using System.Collections.Generic;





public class Program
{
    public static void Main(string[] args)
    {

        Trie oTrie = new Trie();

        List<string> words = new List<string> { "cat", "car", "cart", "ball", "bat", "bats", "arham", "muddasir",
            "dog", "door", "duck", "bathtub", "apple", "apricot", "banana", "blueberry",
            "cherry", "grape", "kiwi", "mango", "orange", "peach", "pear", "strawberry",
            "watermelon", "pineapple", "lemon", "lime", "melon", "coconut", "papaya",
            "potato", "carrot", "broccoli", "cucumber", "onion", "garlic", "mushroom",
            "tomato", "lettuce", "cabbage", "spinach", "pepper", "radish", "avocado",
            "corn", "beetroot", "peas", "greenbean", "celery", "pumpkin", "zucchini",
            "eggplant", "sweetpotato", "chocolate", "cake", "cookie", "icecream",
            "pancake", "waffle", "pie", "doughnut", "macaron", "pizza", "burger",
            "sandwich", "fries", "noodle", "spaghetti", "sushi", "taco", "burrito",
            "soup", "salad", "friedchicken", "steak", "fish", "shrimp", "lobster",
            "crab", "rice", "bread", "pasta", "cheese", "milk", "yogurt", "coffee",
            "tea", "juice", "soda", "water" };
        foreach (string vords in words)
        {
            oTrie.InsertWord(vords);
        }

        string vord = "cat";

        oTrie.InsertWord("kl");

        oTrie.UpdateWord("cat", "cash");

        oTrie.DeleteWord("cash");


        if(oTrie.SearchWord(vord))
        {
            Console.WriteLine($"{vord} is correct");
        }
        else
        {
            Console.WriteLine($"{vord} is incorrect ");
        }


    }
}
