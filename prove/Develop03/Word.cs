class Word {
    private string _text{get;set;}
    private Boolean _isHidden = false;
    public Word(String text) {
        _text = text;
    }

    public void Hide() {
        _text = "___";
        _isHidden = true;

    }
    public Boolean isHidden() {
        return _isHidden;
    }
    public string GetDisplay() {
        return _text;
    }
}