using System;
using System.Collections.Generic;
using System.Text;

class Scripture {
    private Reference _ref {get; set;}
    public List<Word> _words = new List<Word>();
    private int times = 0;
    private static Random _random = new Random(DateTime.Now.Millisecond);

 
    public Scripture(Reference reference, String text) {
        _ref = reference;
        
        string[] words = text.Split(" ");
        foreach(string word in words) {
            _words.Add(new Word(word));
        }
    }
    public void HideWords() {
        for(int i=0; i<=2; i++) {
            int randomNumber = _random.Next(0,_words.Count());
            var word = _words[randomNumber];
            
            if(word.isHidden() == false) {
                word.Hide();
                times++;
            }
            else {
                i--;
            }
        }
    }
    public Boolean IsCompletelyHidden(){
        // Checks if the amount of times 3 words hidden 
        // is within 2 words of the goal.
        // Avoids repeats.
        if(times >= (_words.Count())-2) {
            return true;
        }
        else {
            return false;
        }
    }
    public void Display() {
        StringBuilder sentence = new StringBuilder();
        foreach(Word word in _words) {
            string text = word.GetDisplay();
            sentence.Append(" ").Append(text);
        }
        Console.WriteLine($"{_ref.GetDisplay()} -{sentence}");
    }
}