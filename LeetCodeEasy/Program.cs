using System;

namespace LeetCodeEasy
{
    public class Program
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
             if( t1 == null) return  t2;
             if( t2 == null) return t1;
        
             t1.val = t1.val + t2.val;
             t1.left = MergeTrees(t1.left, t2.left);
             t1.right = MergeTrees(t1.right, t2.right);
             return t1;
         }
        
        
        static void Main(string[] args)
        {
            TreeNode test1 = new TreeNode(5, null, null);
            
        }
    }
}