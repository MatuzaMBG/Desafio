Carro c1 = new Carro();


Moto m1 = new Moto();


//Criação de array
int [] notas = new int [5];

notas[0] = 90;
notas[1] = 85;
notas[2] = 88;
notas[3] = 98;
notas[4] = 95;

//Acessando e imprimindo as notas dos alunos
for(int i = 0; i <notas.Length; i++)
{
    Console.WriteLine($"Nota do aluno: {i + 1} : {notas[i]}");
}

//Criando uma Lista
List<Veiculo> veiculos = new List<Veiculo>();

veiculos.Add(c1);
veiculos.Add(m1);

//veiculos.Remove(c1);

foreach(var veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Freiar();
    veiculo.ExibirVelocidade();
}