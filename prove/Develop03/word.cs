using System;


class Word{

    private string _shownText;

    private string _hiddenText;

    private bool _isHidden;

    public Word(string text){
        _shownText = text;
        string hidden = "";

        
        foreach (char c in text){
            if (c.Equals(";")){
                hidden = hidden +";";
            }
            if (c.Equals(".")){
                hidden = hidden + ".";
            }
            else{
                hidden = hidden + "_";
            }
        }

        _hiddenText = hidden;
    }
 
    public void Hide(){

        _isHidden = true;

    }

    public void Show(){

    }

    public bool IsHidden(){
        if (_isHidden == true){
            return true;
        }
        else{
            return false;
        }

    }

    public string GetDisplayText(){
        if (_isHidden == true){
            return _hiddenText;
        }
        else{
            return _shownText;
        }

    }

}