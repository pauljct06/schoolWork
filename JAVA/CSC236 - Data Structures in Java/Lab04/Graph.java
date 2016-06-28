public class Graph<T> {
   private Node<T> anchor;

   public Graph() {
      anchor = null;
   }

   //  add node with given element
   //  returns true if node was added, false if a node with the given element
   //  was already in the graph
   public boolean addNode(T elem) {
      boolean ok = false;
      Node<T> exists = findNode(elem);
      if (exists == null) {
         ok = true;
         Node newNode = new Node(elem);
         if (anchor !=null)
            newNode.nextnode = anchor;
         anchor = newNode;
      }
      return ok;
   }

   //  return node with the given element
   //  returns null if element not found in the graph
   private Node<T> findNode(T elem) {
      boolean found = false;
      Node<T> curr = anchor;
      while (curr != null && !found) {
         if (curr.element.equals(elem))
            found = true;
         else
            curr = curr.nextnode;
      }
      return curr;
   }

   //  add edge between the nodes with the given elements, if they exist
   //  graph is undirected so edge is added twice: (from,to) and (to,from)
   //  returns true if the edge was added, false if it couldn't be added
   //  because one or both of the nodes was not found
   public boolean addEdge(T from, T to) {
      boolean ok = true;
      Node<T> fromnode = findNode(from);
      Node<T> tonode = findNode(to);
      if (fromnode == null || tonode == null)
         ok = false;
      else {
         //  fromedge is in the edge listof fromnode and it points to tonode
         Edge<T> fromedge = new Edge<T>(tonode);
         fromedge.nextedge = fromnode.edgelist;
         fromnode.edgelist = fromedge;

         //  toedge is in the edgelist of tonode and it points to fromnode
         Edge<T> toedge = new Edge<T>(fromnode);
         toedge.nextedge = tonode.edgelist;
         tonode.edgelist = toedge;
      }
      return ok;
   }

   public void print() {
      Node<T> curr = anchor;
      Edge<T> curredge;

      //  print each node
      while (curr != null) {
         System.out.println("\nNode: " + curr.element);
         System.out.println("   Edges: ");
         curredge = curr.edgelist;

         //  print all edges for the current node
         while (curredge != null) {
            System.out.println("     (" + curr.element + ","
                                + curredge.tonode.element + ")");
            curredge = curredge.nextedge;
         }
         curr = curr.nextnode;
      }
      System.out.println();
   }

   //  private function to unmark all nodes, called by dfs and bfs
   private void unmarkNodes() {
      Node curr = anchor;
      while (curr != null) {
         curr.mark = 0;
         curr = curr.nextnode;
      }
   }

   //  private function to check if any nodes have mark of 0
   //  returns node with mark 0 if found; otherwise returns null
   private Node<T> someUnmarked() {
      boolean found = false;
      Node curr = anchor;
      while (curr != null && !found) {
         if (curr.mark == 0)
            found = true;
         else
            curr = curr.nextnode;
     }
     return curr;
   }

   //  public dfs: unmarks all nodes, then calls recursive dfs
   public void bfs() {
      unmarkNodes();
      bfs(anchor,1);
      System.out.println();
   }

   //  bfs (prints each node)
   private void bfs(Node<T> curr, int component) {

	   System.out.println("\nConnected Component " + component + ":");
	   Node<T> tempNode;
	   QueueArr<Node> qq = new QueueArr<Node>();
	   qq.add(curr);
	   curr.mark = component;

	   while(!qq.isEmpty()) {
		   tempNode = qq.remove();
		   System.out.println(tempNode.element);
		   Edge<T> Nextedge = tempNode.edgelist;

		   while(Nextedge != null) {

			   Node<T> adjNote = Nextedge.tonode;

			   if(adjNote.mark == 0) {

				   adjNote.mark = component;
				   qq.add(adjNote);
			   }
			   Nextedge = Nextedge.nextedge;
		   }//end while to check for more edges

	   }//end of while to check queue
	   if(someUnmarked() != null)

			bfs(someUnmarked(), component+1);
   }// end of private bfs method

}//end of class

