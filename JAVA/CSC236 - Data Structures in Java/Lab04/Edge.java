public class Edge<T> {
   Node<T> tonode;
   Edge nextedge;

   public Edge() {
      tonode = null;
      nextedge = null;
   }

   public Edge(Node<T> to) {
      tonode = to;
      nextedge = null;
   }
}
