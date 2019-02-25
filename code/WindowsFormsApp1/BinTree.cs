using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }
        public BinTree()
        {
            root = null;
        }
        private void inorder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inorder(tree.Left, ref buffer);
                buffer += tree.Data.ToString();
                inorder(tree.Right, ref buffer);
            }
        }

        public void InOrder(ref string buffer)
        {
            inorder(root, ref buffer);
        }

        public void PreOrder(ref string buffer)
        {
            preorder(root, ref buffer);
        }
        private void preorder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString();
                preorder(tree.Left, ref buffer);
                preorder(tree.Right, ref buffer);
            }

        }


        private void postorder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                preorder(tree.Left, ref buffer);
                preorder(tree.Right, ref buffer);
                buffer += tree.Data.ToString();
            }

        }
        public void PostOrder(ref string buffer)
        {
            postorder(root, ref buffer);
        }
    }
}
