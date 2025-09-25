using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arvoresbinarias
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root {get; set;} = null!;
        public int Count {get; set;}

        private void TraversePreOrder (
            BinaryTreeNode<T> node,
            list<BinaryTreeNode<T>> result
        )
        {
            if(node != null){
                result.add(node);
                TraversePreOrder(node.left, result);
                TraversePreOrder(node.rigth, result);
            }
        }

        private void TraversePreOrder(
            BinaryTreeNode<T> node,
            list<BinaryTreeNode<T>> result
            
        )
        {
            if(node != null){
                TraversePreOrder(node.left,result);
                result.add(node);
                TraversePreOrder(node.rigth,result);

            }

            
        }
        private void  TraversePreOrder(
            BinaryTreeNode<T> node,
            list<BinaryTreeNode<T>> result
        )
        {
            if(node != null){
                TraversePreOrder (node,left,result);
                TraversePreOrder (node,rigth,result);
                result.add(node);
            }
        }
        public list<BinaryTreeNode<T>> Traverse (
            TraversalEnum mode 
            ){
                list<BinaryTree<T>> nodes =
                new list<BinaryTreeNode<T>> ();

                switch (mode) {
                    case TraversalEnum.PREORDER:
                    TraversePreOrder (Root, nodes);
                    break;
                    case TraversalEnum.INORDER:
                    TraversePreOrder(Root, nodes);
                    break
                }
            } 
        


    }

}