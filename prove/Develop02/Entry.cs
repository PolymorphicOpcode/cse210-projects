using System;
class Entry {
    public string _uid;
    public string _timestamp;
    public string _content;
    public string _prompt;

    public void Display(string _uid, string _timestamp, string _content, string _prompt) {
        Console.WriteLine($"Entry {_uid} - {_timestamp}\n{_prompt}\n{_content}");
    }
}