using System;

class Journal {
    public List<Entry> _entries = new List<Entry>();
    DateTime _datetime = DateTime.Now;
    public void AddEntry(string prompt, string response) {
        Entry entry = new Entry(_datetime, response, prompt);
        _entries.Add(entry);
    }
        public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("Date: " + entry._timestamp);
            Console.WriteLine("Prompt: " + entry._prompt);
            Console.WriteLine("Response: " + entry._content);
            Console.WriteLine();
        }
    }
    
    public void Save(string filename)
    {
        StreamWriter writer = new StreamWriter(filename);
        foreach (Entry entry in _entries)
        {
            writer.WriteLine(entry._prompt);
            writer.WriteLine(entry._content);
            writer.WriteLine(entry._timestamp);
        }
        writer.Close();
    }

    public void Load(string filename)
    {
        _entries.Clear();
        StreamReader reader = new StreamReader(filename);
        while (!reader.EndOfStream)
        {
            string prompt = reader.ReadLine();
            string response = reader.ReadLine();
            string date = reader.ReadLine();
            var timestamp = DateTime.Parse(date);

            Entry entry = new Entry(timestamp, response, prompt);
            _entries.Add(entry);

    }}
}