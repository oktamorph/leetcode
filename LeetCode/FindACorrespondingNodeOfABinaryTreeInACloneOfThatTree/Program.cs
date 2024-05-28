namespace FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(8) 
                { 
                    left = null, 
                    right = new TreeNode(6)
                    {
                        left = null,
                        right = new TreeNode(5)
                        {
                            left = null,
                            right = new TreeNode(4)
                            {
                                left = null,
                                right = new TreeNode(3)
                                {
                                    left = null,
                                    right = new TreeNode(2)
                                    {
                                        left = null,
                                        right = new TreeNode(1)
                                    }
                                }
                            }
                        }
                    }
                };

            TreeNode target = new TreeNode(4);

            var result = GetTargetCopy(tree, tree, target);
        }

        public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original is null) return original;
            if (original == target) return cloned;
            return GetTargetCopy(original.left, cloned.left, target) ?? GetTargetCopy(original.right, cloned.right, target);
        }
    }

     public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
    }

}