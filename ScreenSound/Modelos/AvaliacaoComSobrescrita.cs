namespace ScreenSound.Modelos;

internal class AvalicaoComSobrescrita
{
    public AvalicaoComSobrescrita(int nota)
    {
        nota = nota;
    }

    public int Nota { get; }

    public static AvalicaoComSobrescrita Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new AvalicaoComSobrescrita(nota);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is not AvalicaoComSobrescrita other) return false;
        return Nota.Equals(other.Nota);        
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}