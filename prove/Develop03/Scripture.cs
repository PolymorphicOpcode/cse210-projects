using System;
class Scripture {
    private Reference _ref {get; set;}
    public List<Word> _words = new List<Word>();
    private int times = 0;
 
    public Scripture(Reference reference, String text) {
        _ref = reference;
        
        string[] words = text.Split(" ");
        foreach(string word in words) {
            _words.Add(new Word(word));
        }
    }
    public void HideWords() {
        for(int i=0; i<=2; i++) {
            Random random = new Random();
            int randomNumber = random.Next(0,_words.Count()-1);
            var word = _words[randomNumber];
            
            if(word.isHidden() == false) {
            word.Hide();
            }
            else {
                i--;
            }
            times++;
        }
    }
    public Boolean IsCompletelyHidden(){
        if(times >= (_words.Count()+1)) {
            return true;
        }
        else {
            return false;
        }
    }
    public void Display() {
        string sentence = null;
        foreach(Word word in _words){
            string text = word.GetDisplay();
            sentence = sentence + " " + text;
        }
        Console.WriteLine($"{_ref.GetDisplay()} -{sentence}");
    }
}