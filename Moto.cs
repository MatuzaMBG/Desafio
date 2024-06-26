public class Moto : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("Moto Acelerando");
        velocidade += 15;
    }

    public override void Freiar()
    {
        Console.WriteLine("Moto Freiando");
        velocidade = velocidade - 15;
    }
}