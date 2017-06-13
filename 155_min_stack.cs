public class MinStack {

    public List<int> _list = new List<int>();
    public int min = int.MaxValue;
    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void Push(int x) {
        _list.Add(x);
        if (x < min){
            min = x;
        }
    }
    
    public void Pop() {
        var removed = Top();
        _list.RemoveAt(_list.Count -1);
        if (removed == min){
            min = int.MaxValue;
            foreach(var item in _list){
                if (item < min){
                    min = item;
                }
            }
        }
        
    }
    
    public int Top() {
        return _list.Last();
    }
    
    public int GetMin() {
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
