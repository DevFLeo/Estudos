using System;
using System.Collections.Generic;


var empresa = new Empresas();
empresa.Nome = "UniSapiens";

var funcionario = new Funcionario();
funcionario.Nome = "Lilo";
funcionario.Empresa = empresa; // Acesso a propriedade da classe empresa através do funcionario
empresa.Funcionarios.Add(funcionario); // Acesso a propriedade da classe funcionarios através da empresa


Console.WriteLine(funcionario.Empresa.Nome); // Acesso a propriedade da classe empresa através do funcionario
Console.WriteLine(empresa.Funcionarios.Count); // Acesso a propriedade da classe funcionarios através da empresa

// Relação 1xN
// 1 Empresa tem N funcionarios
public class Empresas {
    public string CNPJ { get; set; } // 1 da Relação 1xN 
    public string Nome { get; set; }
    public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>(); // N da Relação 1xN 
}

public class Funcionario { // N da relação 1xN
    public string CPF { get; set; } 
    public string Nome { get; set; }
    public Empresas Empresa { get; set; } // 

}

// Relação 1x1 
public class Marido {
    public string Nome { get; set; } // Relação 1x1 

}
public class Mulher {
    public string Nome { get; set; } 
    public Marido Marido { get; set; } // Relação 1x1

}

// Relação N x N
// 1 Disciplina tem N alunos
// 1 Aluno tem N disciplinas
public class Disciplina {
    public string Nome { get; set; }
    public int CargaHoraria { get; set; }
    public List<Disciplina_Aluno> Alunos { get; set; } = new List<Disciplina_Aluno>(); // N da Relação N x N
}

public class Disciplina_Aluno {
    public Disciplina Disciplina { get; set; }
    public Aluno Aluno { get; set; }

}
public class Aluno {
    public int Matricula { get; set; }
    public string Nome { get; set; }
}