using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)// Constructor que inicializa la referencia y convierte el texto en una lista de palabras
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var Word in text.Split(' '))
        {
            _words.Add(new Word(Word));
        }
    }


    public void  HideRandomWords(int numberToHide)// Método para ocultar un número especificado de palabras no ocultas
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    

    public string GetDisplayText()// Devuelve el texto de la escritura con las palabras ocultas
    {
        List<string> displayWords = new List<string>();
        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()// Verifica si todas las palabras están ocultas
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}