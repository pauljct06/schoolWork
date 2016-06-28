import java.util.Scanner;

public class Client {
	public static void main(String[] args) {

		Graph<String> mygraph = new Graph<String>();

		String name;
      	String from,to;
      	Scanner keybd = new Scanner(System.in);

      	System.out.println("Enter node names (enter q when finished):");
      	name = keybd.next();
      	while (!name.equals("q")) {
      	   mygraph.addNode(name);
      	   name = keybd.next();
      	}

      	System.out.println("Enter edges (enter q when finished):");
      	from = keybd.next();
      	while (!from.equals("q")) {
      	   to = keybd.next();
      	   mygraph.addEdge(from,to);
      	   from = keybd.next();
      	}

      	mygraph.print();
      	mygraph.bfs();
	}

}

