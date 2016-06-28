public class Node<T> {
   int mark;
   T element;
   Edge edgelist;
   Node nextnode;

   public Node() {
      mark = 0;
      edgelist = null;
      nextnode = null;
   }

   public Node(T elem) {
      element = elem;
      mark = 0;
      edgelist = null;
      nextnode = null;
   }
}
