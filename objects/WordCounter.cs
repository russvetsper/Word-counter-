using System;
using System.Collections.Generic;



namespace WordCountering
{
  public class WordCounter
  {
    private string _word;
    private string _sentence;

    public WordCounter(string word, string sentence)
    {
      _word = word.ToLower();
      _sentence = sentence.ToLower();
    }
    public string GetWord()
    {
      return _word;
    }


    public void SetWord(string word)
    {
      _word = word;
    }

    public string GetSentence()
    {
      return _sentence;
    }


    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }




    public int CountRepeat()
   {

     var count=0;
      string myWord=this._word;
      string[] myArry=myWord.Split(' ');
      for (int i=0; i<myArry.Length; i++) {

      if(myArry[i]==this._sentence)
      {
        count=count+1;
      }
         }
         return count;
      }




  }
}
