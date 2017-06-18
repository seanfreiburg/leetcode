public class ZigzagIterator {

    int v1Index = -1;
    int v2Index = -1;
    IList<int> v1;
    IList<int> v2;
    public ZigzagIterator(IList<int> v1, IList<int> v2) {
        this.v1 = v1;
        this.v2 = v2;
    }

    public bool HasNext() {
        if (v1Index <= v2Index){
            if (v1.Count -1 >= v1Index + 1){
                return true;
            }
            else if (v2.Count -1 >= v2Index + 1){
                return true;
            }
            return false;
        }
        else {
            if (v2.Count -1 >= v2Index + 1){
                return true;
            }
            else if (v1.Count -1 >= v1Index + 1){
                return true;
            }
            return false;
        }
    }

    public int Next() {
        if (v1Index <= v2Index){
            if (v1.Count -1 >= v1Index + 1){
                v1Index++;
                return v1[v1Index];
            }
            else{
                v2Index++;
                return v2[v2Index];
            }
        }
        else {
            if (v2.Count -1 >= v2Index + 1){
                v2Index++;
                return v2[v2Index];
            }
            else{
                v1Index++;
                return v1[v1Index];
            }
        }
    }
}

/**
 * Your ZigzagIterator will be called like this:
 * ZigzagIterator i = new ZigzagIterator(v1, v2);
 * while (i.HasNext()) v[f()] = i.Next();
 */
