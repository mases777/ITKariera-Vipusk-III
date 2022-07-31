using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Tree<T>
    {
        private T value;
        private IList<Tree<T>> children;

        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;
            this.children = children;
        }

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.value);
            foreach (var item in this.children)
            {
                item.Print(indent + 1);
            }
        }

        private void DFS(Tree<T> tree, List<T> order)
        {
            foreach (var item in tree.children)
            {
                this.DFS(item, order);
            }
            order.Add(tree.value);
        }
        public IEnumerable<T> OrderDFS()
        {
            List<T> order = new List<T>();
            this.DFS(this, order);
            return order;
        }

        public IEnumerable<T> BFS()
        {
            List<T> order = new List<T>();
            Queue<Tree<T>> visited = new Queue<Tree<T>>();
            visited.Enqueue(this);
            while (visited.Count > 0)
            {
                var next = visited.Dequeue();
                order.Add(next.value);
                foreach (var item in next.children)
                {
                    visited.Enqueue(item);
                }
            }
            return order;
        }
    }
}
