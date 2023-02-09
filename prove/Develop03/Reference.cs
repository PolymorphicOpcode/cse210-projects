class Reference {
    private string _book{get;set;}
    private int _chapter{get;set;}
    private int _startVerse{get;set;}
    private int _endVerse = 0;

    public Reference(String book, int chapter, int startVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Reference (String _book, int _chapter, int _startVerse, int _endVerse) {}
    public string GetDisplay() {
        if(_endVerse != 0) {return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";}
        else {
            return $"{_book} {_chapter}:{_startVerse}";}
        }
}
