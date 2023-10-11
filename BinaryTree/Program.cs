//Существует три вида обхода:
//1.Префиксный: 1)Элемент 2)Левый лист 3)Правый лист 
//Подходит для воссоздания такогоже дерева
//2.Постфиксный: 1)Левый 2)Правый 3)Элемент
//Позволяет корректно удалять элементы дерева
//3.Инфиксный: 1)Левое 2)Элемент 3)Правое
//Вместе с обходом производится сортировка ллементов, в порядке возрастания
using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Three<int>();
            tree.Add(5);
            tree.Add(2);
            tree.Add(9);
            tree.Add(7);
            tree.Add(4);
            tree.Add(5);
            tree.Add(3);
            tree.Add(1);
            tree.Add(10);
            //Console.WriteLine("Preorder:");
            //foreach (var item in tree.Preorder())
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Postorder:");
            //foreach (var item in tree.Postorder())
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Inorder:");
            //foreach (var item in tree.Inorder())
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine();
            Console.WriteLine("InWith:");
            foreach (var item in tree.InWidth())
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Number for search:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Res of Search:");
            if (tree.SearchInWidth(x)) Console.WriteLine("Sucsess");
            else Console.WriteLine("Faild");
        }
        
    }

}
