public abstract class Veiculo //usado quando não se que instacial a classe
{
    protected int velocidade;

    public abstract void Acelerar();

    public abstract void Freiar(); 
    
    public void ExibirVelocidade()
    {
        Console.WriteLine("Velocidade : " + velocidade);
    }
}