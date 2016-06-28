/* Paul Collado
   CSC-236 Data Structures
   Lab 02 listNode class
 */

public class listNode<T> {

    private T element;
    private listNode<T> successor;

    // default constructor initializes both fields to null
    public listNode() {
        element = null;
        successor = null;
    }

    // constructor to initialize element and successor
    public listNode(T elem, listNode<T> succ) {
        element = elem;
        successor = succ;
    }

    // return the element stored in this node
    public T getElement() {
        return element;
    }

    // change the element stored in this node
    public void setElement(T elem) {
        element = elem;
    }

    // return the successor of this node
    public listNode<T> getSuccessor() {
        return successor;
    }

    // change the successor of this node
    public void setSuccessor(listNode<T> succ) {
        successor = succ;
    }

}