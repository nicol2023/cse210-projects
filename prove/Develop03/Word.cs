using System;


public class Word
{
    private string _text;
    private bool _isHidden;



    public Word(string text) // Constructor que inicializa el texto de la palabra y la marca como no oculta
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()// Método para ocultar la palabra
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()// Método para verificar si la palabra está oculta
    {
        return _isHidden;
    }

    public string GetDisplayText()// Devuelve el texto de la palabra, ocultándola si es necesario
    {
        return _isHidden ? "--------" : _text;
    }
}