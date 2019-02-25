using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;

        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public void Insertitem(T item)
        { insertItem(item, ref root); }

        public int Height()
        {
            return height(this.root);
        }

       

        protected int height(Node<T> tree)
        //Return the max level of the tree
        {

            if (tree == null) { return 0; }
            else
            {
                int L1 = height(tree.Left);
                int L2 = height(tree.Right);
                return 1 + Math.Max(L1, L2);
            }
        }//closes height method
        public int Count()
        {
            return count(this.root);
        }
        public int count(Node<T> tree)
        //Return the number of nodes in the tree
        {
            if (tree == null) { return 0; }
            else
            {
                int L1 = height(tree.Left);
                int L2 = height(tree.Right);
                return 1 + L1 + L2;
            }
        }

        public bool Contains(T item)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {
            if (root == null) { return false; }
            return containsItem(item, root);
        }
        public bool containsItem(T item, Node<T> tree)
        {
            if (tree == null)
            {
                return false;
            }
            else if (item.CompareTo(tree.Data) == 0)
            {
                return true;
            }
            if (item.CompareTo(tree.Data) < 0)
            {
                return containsItem(item, tree.Left);

            }

            if (item.CompareTo(tree.Data) > 0)
            {
                return containsItem(item, tree.Right);
            }
            else return false;

        }

        public void RemoveItem(T item) //covered in lecture 16
        {
            removeItem(item, ref root);
        }
        public void removeItem(T item, ref Node<T> tree)
        {

            if (tree == null)
            {

            }

            if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }

            if (tree.Left == null)
            {
                tree = tree.Right;
            }

            if (tree.Right == null)
            {
                tree = tree.Left;
            }


        }
    }


}

