public class BST
{
    public Node Root;

    public BST()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, int value)
    {
        if (root == null) return new Node(value);
        if (value < root.Value)
            root.Left = InsertRec(root.Left, value);
        else if (value > root.Value)
            root.Right = InsertRec(root.Right, value);
        return root;
    }

    public Node Search(Node root, int value)
    {
        if (root == null || root.Value == value) return root;
        if (value < root.Value) return Search(root.Left, value);
        return Search(root.Right, value);
    }

    public Node Delete(Node root, int value)
    {
        if (root == null) return root;
        if (value < root.Value) root.Left = Delete(root.Left, value);
        else if (value > root.Value) root.Right = Delete(root.Right, value);
        else
        {
            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;
            root.Value = MinValue(root.Right);
            root.Right = Delete(root.Right, root.Value);
        }
        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Value;
        while (root.Left != null)
        {
            minv = root.Left.Value;
            root = root.Left;
        }
        return minv;
    }

    public void InOrder(Node node)
    {
        if (node != null)
        {
            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }
    }

    public void PreOrder(Node node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
    }

    public void PostOrder(Node node)
    {
        if (node != null)
        {
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value + " ");
        }
    }

    public int FindMin(Node root)
    {
        while (root.Left != null) root = root.Left;
        return root.Value;
    }

    public int FindMax(Node root)
    {
        while (root.Right != null) root = root.Right;
        return root.Value;
    }

    public int Height(Node root)
    {
        if (root == null) return -1;
        return Math.Max(Height(root.Left), Height(root.Right)) + 1;
    }

    public void Clear()
    {
        Root = null;
    }
}
