/* Paul Collado
   CSC-236 Data Structures
   Lab 02 OrderedList class
 */
// ordered singly linked list
// no duplicates allowed
// fields:
//     head and tail (uses dummy nodes)
//     length
//     cursor (used by first and next to iterate through list)
// interface:
//     add item (maintains ordering)
//     remove item by content
//     return size
//     check for empty list
//     set cursor to first item and return item
//     move cursor to next item and return item
//
public class OrderedList<T extends Comparable<T>> {

    private listNode<T> head;
    private listNode<T> tail;
    private int length;
    private listNode<T> cursor;

    // empty list has dummy head and tail nodes; head points to tail
    public OrderedList() {
        tail = new listNode<T>();
        head = new listNode<T>(null,tail);
        length = 0;
        cursor = head;
    }

    // add new item in correct position
    public void add(T item) {

		boolean added = false;
		listNode<T> prev = head;
		listNode<T> current = prev.getSuccessor();

		// adds item if the list is empty list
		if(current ==  tail) {

			tail.setElement(item);
			tail.setSuccessor(new listNode<T>());
			tail = tail.getSuccessor();
			length++;
		}

		// checks in what position should the item be added if the list is not empty
		else {

			//loop to check in what position to put the item
			while(current != tail && added == false) {

				// if current exponent is less than item's, move up current and prev
				if(current.getElement().compareTo(item) < 0) {
					prev = current;
					current = current.getSuccessor();
				}

				// if current exponent is equals than item's, throw DuplicateElementException
				else if(current.getElement().compareTo(item) == 0) {

					System.out.println();
					throw new DuplicateElementException("A term with the same exponent as " + item + " is already in the list! Try Again\n");
				}

				// if current exponent is greater than item's, add item between prev
				//set added flag to true to exit the loop
				else if(current.getElement().compareTo(item) > 0) {

					listNode<T> newnode = new listNode<T>(item,current);
					prev.setSuccessor(newnode);
					length++;

					added = true;
				}
			}// end of while

			// now check flag to see if item hasnt beed added, and if it hasnt, then add it at the end
			if(added == false) {

				listNode<T> newnode = new listNode<T>(item,current);
				prev.setSuccessor(newnode);
				length++;
			}
		}// end of else
	}//end of method

    // return the number of elements in the list
    public int size() {
        return length;
    }

    // check whether list contains no items
    public boolean isEmpty() {
        return (length == 0);
    }

    // remove item from list
    public void remove(T item) {

		listNode<T> prev = head;
		listNode<T> current = prev.getSuccessor();

		while(current != tail && current.getElement() != item) {

			prev = current;
			current = current.getSuccessor();
		}

		if(current != tail) {

			prev.setSuccessor(current.getSuccessor());
			length--;
		}
    }

    // set cursor to first element in list (successor of head)
    // and return that element
    // if the list is empty it returns null
    public T first() {
        cursor = head.getSuccessor();
        return cursor.getElement();
    }

    // move cursor to next element in list and return it
    // return null if there is no next element
    public T next() {
        cursor = cursor.getSuccessor();
        if (cursor == tail)
            return null;
        else
            return cursor.getElement();
    }

}