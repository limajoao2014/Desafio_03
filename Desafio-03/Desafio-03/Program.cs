Console.WriteLine("Quantos alunos são ?");
int qntAluno = Convert.ToInt32(Console.ReadLine());
List<String> lista1 = new List<String>();
List<double> lista2 = new List<double>();
var i = 0;
while (i < qntAluno)
{
    Console.WriteLine("Digite o nome do aluno");
    string nome = Console.ReadLine();
    lista1.Add(nome);

    Console.WriteLine("Digite a nota do aluno");
    double nota = Convert.ToDouble(Console.ReadLine());
    lista2.Add(nota);

    i++;    
}
var lista3 = new
{
    name = lista1,
    nota = lista2,

};
double maiorNota = 0;
var maiorAluno = "";
for(var x = 0; x < qntAluno; x++)
{
    if (maiorNota < lista3.nota[x]) {
        maiorNota = lista3.nota[x];
        maiorAluno = lista3.name[x];
    }
        Console.WriteLine("Nome do aluno: "+lista3.name[x] + " nota do aluno: " + lista3.nota[x]);
}
Console.WriteLine("Maior aluno e sua nota "+maiorAluno + " " + maiorNota);