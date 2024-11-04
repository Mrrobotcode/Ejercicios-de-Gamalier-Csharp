using System;

internal class Class1
{
    public string marca { get; set; };
    public string modelo { get; set; };
    public string color { get; set; };
    public int velociadad { get; set; };


    public void Acelera()
    {
        velocidad++;
    }

    public void Desaselerar()
    {
        velociadad--;
    }
}	