import java.lang.IllegalStateException;
import java.util.NoSuchElementException;

public class QueueArr<T> {

    private int front;
    private int back;
    private int count;
    private T[] elements;
    private int maxqueue;

    public QueueArr() {
        front = 0;
        maxqueue = 100;
        elements = (T[]) new Object[maxqueue];
        back = maxqueue - 1;
        count = 0;
    }

    public boolean isEmpty() {
       return count == 0;
    }

    public void add(T item) {
        if (count == maxqueue)
            throw new IllegalStateException("item cannot be added; queue is full");
        back = (back+1) % maxqueue;
        elements[back] = item;
        ++count;
    }

    public T remove() {
        T frontitem;
        if (isEmpty())
            throw new NoSuchElementException("item cannot be removed; queue is empty");
        frontitem = elements[front];
        front = (front+1) % maxqueue;
        --count;
        return frontitem;
    }

    public T getFront() {
        if (isEmpty())
            throw new NoSuchElementException("item cannot be removed; queue is empty");
        return elements[front];
    }
}