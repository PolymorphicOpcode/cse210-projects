using System;

class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal() {}
    
    public void Save(string filename) {}

    public void Load(string filename) {}

    public void AddEntry(Entry journalentry){
        _entries.Add(journalentry);
    }

}