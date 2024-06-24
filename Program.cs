using BinaryTree;
using System.Runtime.CompilerServices;

namespace Assignment_7._3._1_Binary_Search_Tree__BST_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binarytree = new BinaryTree<int>();

            binarytree.Add(8);
            binarytree.Add(5);
            binarytree.Add(12);
            binarytree.Add(25);
            binarytree.Add(21);
            binarytree.Add(33);
            binarytree.Add(7);

            foreach (var item in binarytree) 
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            binarytree.PrintToConsole();
            binarytree.PrintAsTree();
            
        }
    }
}
