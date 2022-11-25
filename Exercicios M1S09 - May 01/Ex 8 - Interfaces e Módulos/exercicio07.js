"use strict";
exports.__esModule = true;
var Aluno = /** @class */ (function () {
    function Aluno(nome, idade, rua, matricula, cadeiras) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.matricula = matricula;
        this.cadeiras = cadeiras;
    }
    Aluno.prototype.cadastrar = function () {
        console.log(this);
    };
    return Aluno;
}());
var Funcionario = /** @class */ (function () {
    function Funcionario(nome, idade, rua, identificador, setor) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.identificador = identificador;
        this.setor = setor;
    }
    Funcionario.prototype.cadastrar = function () {
        console.log(this);
    };
    return Funcionario;
}());
/* let reFuncionario = new Funcionario ("Webert", 21, "Rua tal", 365, "T.I");
    reFuncionario.cadastrar(); */
var reAluno = new Aluno("Webert", 21, "Rua tal", 365, ["Teste"]);
reAluno.cadastrar();
