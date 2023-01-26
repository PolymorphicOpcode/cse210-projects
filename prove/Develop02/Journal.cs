using System;

class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal() {}
    
    public void Save(string filename) {}

    public void Load(string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            string[parts] = line.split(",");

        }
    }

    public void AddEntry(Entry journalentry){
        _entries.Add(journalentry);
    }

}