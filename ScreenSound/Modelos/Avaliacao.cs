namespace ScreenSound.Modelos;

internal class Avaliacao
{
    //Estabele os limites mínimos e máximos para a nota
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
