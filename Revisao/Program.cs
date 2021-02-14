using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = obeterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar alunos
                        Console.WriteLine("Informar o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if(decimal.TryParse(Console.ReadLine(),out decimal nota)){
                            aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("O valor da nota deve ser décimal!!");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        //TODO: Listar alunos
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"Nome : {a.Nome} -- Nota : {a.Nota}");
                            }    
                        }
                        break;
                    case "3":
                        //TODO: Calcular Média Geral

                            decimal notaTotal = 0;
                            var nrAlunos = 0;

                        for(int i=0; i<alunos.Length; i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }    
                        }


                        var media = notaTotal / nrAlunos;
                        Conceito conceitoGeral;
                        
                        if(media < 2){
                            conceitoGeral = Conceito.E;
                        }else if(media < 4){
                            conceitoGeral = Conceito.D;
                        }else if(media < 6){
                            conceitoGeral = Conceito.C;
                        }else if(media < 8){
                            conceitoGeral = Conceito.B;
                        }else {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"A média é : {media} -- Conceito : {conceitoGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
               opcaoUsuario = obeterOpcaoUsuario();
            }
        }
        private static string obeterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
