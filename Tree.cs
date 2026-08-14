using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace BSTRecursiveTraversals
{
    internal class Tree<T> where T : IComparable 
    {
        int Count = 0;
        Node<T> Root = null;


        public void Insert(T value)
        { 
            if (Root == null)
            {
                Root.Value = value;
                return;
            }
            else
            {
                if(Root.Value.CompareTo(value) < 0)
                {
                    Root.Left.Value = value;
                }
                else
                {
                    Root.Right.Value = value;
                }
            }
            Count++;

        }
        
    }
}
