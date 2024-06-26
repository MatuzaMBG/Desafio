public class Carro : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("Carro Acelerando");
        velocidade += 10;
    }

    public override void Freiar()
    {
        Console.WriteLine("Carro Freiando");
        velocidade = velocidade - 5;
    }
}