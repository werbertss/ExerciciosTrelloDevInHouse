import { Pessoa } from "./interface";


class Aluno implements Pessoa{
    nome: string;
    idade: number;
    rua: string;

    matricula: number;
    cadeiras: string [];

    cadastrar() {
        console.log (this)
    }

    constructor (nome: string, idade: number, rua: string, matricula: number, cadeiras : string[]){
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;

        this.matricula = matricula;
        this.cadeiras = cadeiras;
    }
}

class Funcionario implements Pessoa{
    nome: string;
    idade: number;
    rua: string;

    identificador: number;
    setor: string;

    cadastrar() {
        console.log(this)
    }

    constructor (nome: string, idade: number, rua: string, identificador: number, setor: string){
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;

        this.identificador = identificador;
        this.setor = setor;
    }
    
}


    /* let reFuncionario = new Funcionario ("Webert", 21, "Rua tal", 365, "T.I");
        reFuncionario.cadastrar(); */

    let reAluno = new Aluno ("Webert", 21, "Rua tal", 365, ["Teste"]);
    reAluno.cadastrar();
