import java.io.PrintWriter;

public class BST<T extends Comparable<T>> {

    private TreeNode<T> root;
    private int size;

    public BST() {
        root = null;
        size = 0;
    }

    public BST(T item) {
        root = new TreeNode<T>(item);
        size = 1;
    }

    public boolean isEmpty() {
        return (root == null);
    }

    public void insert(T item) {
        if (item == null)
            throw new TreeViolationException();
        root = insert(root, item);
    }

    public void delete(T item) {
        delete(root, item);
    }

    public T contains(T item) {
        if (item == null)
            throw new TreeViolationException();
        return contains(root, item);
    }

    private TreeNode<T> insert(TreeNode<T> node, T item) {
        if (node == null) {
            // position of insertion found; insert as child of leaf
            node = new TreeNode<T>(item);
            size++;
        }
        // else search for the insertion position
        else if (item.compareTo(node.element) < 0)
            // search the left subtree
            node.left = insert(node.left, item);
        else  if (item.compareTo(node.element) > 0)
        // search the right subtree
            node.right = insert(node.right, item);
        else
        // item is already in tree, throw exception
            throw new TreeViolationException();
        return node;
    }

    private void delete(TreeNode<T> node, T item) {
    // Calls: deleteItem.
        if (node == null)
            return;  // empty tree
        else if (item.compareTo(node.element) == 0) {
            // item is in the root of some subtree, delete it
            deleteItem(node);
        }
        // else search for the item
        else if (item.compareTo(node.element) < 0)
            // search the left subtree
            delete(node.left, item);
        else  // search the right subtree
            delete(node.right, item);
    }

    private void deleteItem(TreeNode<T> node) {
    // Algorithm note: There are four cases to consider:
    //   1. The root is a leaf.
    //   2. The root has no left child.
    //   3. The root has no right child.
    //   4. The root has two children.
    // Calls: processLeftmost.
        T repitem;
        // test for a leaf
        if ((node.left == null) && (node.right == null))
            node = null;
        // test for no left child
        else if (node.left == null)
            node = node.right;
        // test for no right child
        else if (node.right == null)
            node = node.left;
        // there are two children:
        // retrieve and delete the inorder successor
        else {
            repitem = processLeftmost(node.right);
            node.element = repitem;
            size--;
        }
    }

    private T processLeftmost(TreeNode<T> node) {
        T repitem;
        if (node.left == null) {
            repitem = node.element;
            node = node.right;
            return repitem;
        }
        else
            return processLeftmost(node.left);
    }

    private T contains(TreeNode<T> node, T item) {
        if (node == null)
            return null;
        else if (item.compareTo(node.element) == 0)
            return node.element;
        else if (item.compareTo(node.element) < 0)
        // search the left subtree
            return contains(node.left, item);
        else
        // search the right subtree
            return contains(node.right, item);
    }

    public void printTree(PrintWriter scr, int pagewidth) {

  		printTree(scr,pagewidth,root);
	}

 	private void printTree(PrintWriter scr, int pagewidth,TreeNode<T> node) {


		int offset = (int)(pagewidth / 2);
		int parentpos = offset;
		int prevlevel = 0;
		int index = 0;

		QueueArr<PrintNode> qq = new QueueArr<PrintNode>();

		PrintNode temp = new PrintNode (node,1,offset);

		qq.add(temp);

		while(!qq.isEmpty()) {


			PrintNode Pnode = qq.remove();
			int nlevel = Pnode.getLevel();
			int pos = Pnode.getPosition();

			if(nlevel == prevlevel)
				index = parentpos;

			if(nlevel > prevlevel) {

				scr.println();
				index = 0;
			}

			while(index <= pos) {

				scr.print(" ");
				index++;
			}

			scr.print(Pnode.getNode().element);

			prevlevel = Pnode.getLevel();
			parentpos = Pnode.getPosition();

			if(Pnode.getNode().left != null) {
				offset = (int)(pagewidth / Math.pow(2,nlevel+1));
				qq.add(new PrintNode(Pnode.getNode().left,nlevel+1,parentpos - offset));
			}

			if(Pnode.getNode().right != null) {
				offset = (int)(pagewidth / Math.pow(2,nlevel+1));
				qq.add(new PrintNode(Pnode.getNode().right,nlevel+1,parentpos + offset));
			}

		}//end of while
	}//end of printTree method
}//end of class
