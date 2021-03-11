using System;

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nome_galinha){
        this.nomeGalinha = nome_galinha;
        numOvo = 0;
    }
    // Metodo que retorna um objeto
    public Ovo botaOvo(){
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo{
    private int numOvo;
    private string m_galinha;
    public Ovo(int n_ovo, string m_galinha){
        this.numOvo = n_ovo;
        this.m_galinha = m_galinha;
        Console.WriteLine("Ovo criado -> {0} - {1}", this.numOvo, this.m_galinha);
    }
}

class Principal{
    static void Main(){
        Galinha g1 = new Galinha("Benedita");
        Galinha g2 = new Galinha("Borisvalda");
        Galinha g3 = new Galinha("Florisbalto");

        g1.botaOvo();
        g3.botaOvo();
        g1.botaOvo();
        g2.botaOvo();
        g1.botaOvo();
        g2.botaOvo();
        g2.botaOvo();
        g3.botaOvo();

    }
}