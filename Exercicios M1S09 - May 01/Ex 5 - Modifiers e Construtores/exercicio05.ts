class Animal{
    nome: string;
    raca: string;
    corPelagem: string;
    peso: number;

    constructor (nomeAnimal: string, racaAnimal: string, 
        corAnimal: string, pesoAninal: number){
            this.nome = nomeAnimal;
            this.raca = racaAnimal;
            this.corPelagem = corAnimal;
            this.peso = pesoAninal;
    }
}