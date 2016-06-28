class TreeNode<T> {
    T element;
    TreeNode<T> left;
    TreeNode<T> right;

    TreeNode() {
        element = null;
        left = null;
        right = null;
    }

    TreeNode(T rootitem) {
        element = rootitem;
        left = null;
        right = null;
    }

}