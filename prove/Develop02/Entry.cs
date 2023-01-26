using System;
class Entry {
    public DateTime _timestamp;
    public string _content;
    public string _prompt;

    public Entry(DateTime _timestamp,string _content, string _prompt) {}
    public void Display(DateTime _timestamp, string _content, string _prompt) {
        Console.WriteLine($"Entry - {_timestamp}\n{_prompt}\n{_content}");
    }
}