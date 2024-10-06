using System;


class Scripture{

    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){
        _reference = reference;

        List<string> words = new List<string>(text.Split(" ")) ;

        foreach (string word in words){
            
            Word w = new Word(word);
            _words.Add(w);
        }
 

    }

    public void HideRandomWords(int numberToHide){

        Random rnd = new Random();

        int n = numberToHide;

        int length = _words.Count;
        
        do{
            
            int x = rnd.Next(0, length);
            if (_words[x].IsHidden() != true){
                _words[x].Hide();
            
                n = n -1;
            }


        }while (n != 0);

    }

    public string GetDisplayText(){
        string display = "";
        string refer = _reference.GetDisplayText();
        display += refer;
        
        foreach (Word word in _words){
            string write = word.GetDisplayText();
            display += $" {write}";
        }
        return display;

    }
    public bool IsCompletelyHidden(){
        
        bool hidden = true;

        foreach (Word word in _words){

            if (word.IsHidden() != true){
                hidden = false;
            }
        }

        
        return hidden;

    }
}