class Account {
    private List<int> _deposits = new List<int>();

    private string _firstname = "Dr.";
    private string _lastname = "Who";
    public void Deposit(int amount) {
        _deposits.Add(amount);
    }

    public int GetBalance() {
        int balance = 0;

        //foreach (var deposit in deposits)
        
        for (int i=0;i==_deposits.Count();i++) {
            balance += _deposits[i];
        }

        return balance;
    }

//Getter
    public string GetName() {
        return $"{_firstname} {_lastname}";
    }
//Setter
    public void SetName(string newName) {
        _firstname = newName;
    }
}