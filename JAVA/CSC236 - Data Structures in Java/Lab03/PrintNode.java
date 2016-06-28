public class PrintNode {

	private TreeNode node;
	private int level;
	private int position;

	public PrintNode() {

		node = null;
		level = 0;
		position = 0;
	}

	public PrintNode(TreeNode n, int lev, int pos) {

		node = n;
		level = lev;
		position = pos;
	}
	public TreeNode getNode() {

		return node;
	}

	public int getLevel() {

		return level;
	}

	public int getPosition() {

		return position;
	}





}