class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.SetLhs(10);
        divider.SetRhs(1);
        divider.DisplayResult();

        divider.SetLhs(0);
        divider.SetRhs(100);
        divider.DisplayResult();

        divider.SetLhs(5);
        divider.SetRhs(0);
        divider.DisplayResult();

        divider.SetLhs(25);
        divider.SetRhs(5);
        divider.DisplayResult();
    }
}

class IntegerDivision {
    private int _lhs = 1;
    private int _rhs = 1;
    public int errorcode = 0;
    
    public void SetLhs(int num) {
        _lhs = num;
    }
    public int GetLhs() {
        return _lhs;
    }
    public void SetRhs(int num) {
        if(num != 0){_rhs = num;}
        else {errorcode++;}
    }
    public int GetRhs() {
        return _rhs;
    }
    public int Result() {
        return GetLhs() / GetRhs();
    }

    public void DisplayResult() {
        if (errorcode == 0) {
            var result = Result();
            Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
        }
        else {
            Console.WriteLine("Err");
            errorcode--;
        }
    }
}
