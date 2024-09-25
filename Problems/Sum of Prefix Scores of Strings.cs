using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution {
        private class TrieNode<T>
        {
            public Dictionary<T, TrieNode<T>> Children { get; } = new Dictionary<T, TrieNode<T>>();
            public int Count { get; set; } = 0;
        }
        public int[] SumPrefixScores(string[] words)
        {
            TrieNode<char> root = new TrieNode<char>();

            // Insert all words into the trie
            foreach (var word in words)
            {
                InsertWord(root, word);
            }

            int[] scores = new int[words.Length];

            // Get the prefix score for each word
            for (int i = 0; i < words.Length; i++)
            {
                scores[i] = GetPrefixScore(root, words[i]);
            }

            return scores;

            void InsertWord(TrieNode<char> root, string word)
            {
                TrieNode<char> current = root;
                // Increment the prefix count for each node in the trie
                foreach (char c in word)
                {
                    // If the current node doesn't have a child with the current character,
                    // create one
                    if (!current.Children.ContainsKey(c))
                    {
                        current.Children[c] = new TrieNode<char>();
                    }
                    // Move to the child node
                    current = current.Children[c];

                    // Increment the prefix count for the current node
                    current.Count++;
                }
            }

            int GetPrefixScore(TrieNode<char> root, string word)
            {
                TrieNode<char> current = root;
                int score = 0;
                // Traverse the trie for the word
                foreach (char c in word)
                {
                    // If the current node has a child with the current character,
                    // move to that child and add its prefix count to the score
                    if (current.Children.ContainsKey(c))
                    {
                        current = current.Children[c];
                        score += current.Count;
                    }
                    else
                    {
                        break;
                    }
                }
                return score;
            }
        }
    }
}
