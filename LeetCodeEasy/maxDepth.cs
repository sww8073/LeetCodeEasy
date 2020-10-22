namespace LeetCodeEasy
{
    public class maxDepth
    {
        public int MaxDepth(Program.TreeNode root) {
            if( root == null ){
                return 0;
            } 
            else{
                /* compute the depth of each subtree */
                int leftDepth = MaxDepth(root.left); 
                int rightDepth = MaxDepth(root.right); 
  
                /* use the larger one */
                if (leftDepth > rightDepth) 
                    return (leftDepth + 1); 
                else
                    return (rightDepth + 1); 
            }
        
        }
    }
}