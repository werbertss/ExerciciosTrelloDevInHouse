//Minha tentativa

 class Conta {
    numero: number;
    saldo: number;
    estaAtiva: boolean;
    dono: string;

    constructor(numero: number, saldo: number, estaAtiva: boolean, dono: string){

        this.numero = numero;
        this.saldo = saldo;
        this.estaAtiva = estaAtiva;
        this.dono = dono;

    }
}

class ContaEmpresa extends Conta{
    limiteDeDeposito: number;
    valorDeposito: number;
    erroMensagem: string;

    constructor (numero: number, saldo: number, estaAtiva: boolean, dono: string, 
        limiteDeDeposito: number, valorDeposito: number, erroMensagem: string){
        super(numero, saldo, estaAtiva, dono)
        this.limiteDeDeposito = limiteDeDeposito;
        this.valorDeposito = valorDeposito;
        this.erroMensagem = erroMensagem;
    }

        deposito(valor = 300): number{

         if(valor <= this.limiteDeDeposito){
            return this.saldo + valor;
        
        }
    
        }

        
        imprimeValorConta(): any{
            console.log (this.deposito())
        }
     
}

let ReContaEmpresa = new ContaEmpresa (35720, 100, true, "Webert", 1000, 500, "O valor depositoado ultrapassou os 1000");
console.log(ReContaEmpresa ,"Saldo atualizado: ", ReContaEmpresa.imprimeValorConta());





//Feita pela professora

/* class Room{
    protected type: string;
    protected length: number;
    protected width: number;

    constructor(type: string, length: number, width: number){
        this.type = type;
        this.length = length;
        this.width = width;
    }

    calcArea(): number{
        return this.length * this.width;
    }
}

class Liveroom extends Room{
    public colorCouch: string;

    constructor(type: string, length: number, width: number, colorCouch: string){
        super(type, length, width);
        this.colorCouch = colorCouch;
    }
}

class Bedroom extends Room{
    private hasSafeBox: boolean;

    constructor(type: string, length: number, width: number, hasSafeBox: boolean){
        super(type, length, width);
        this.hasSafeBox = hasSafeBox;
    }
}

let souBedroom = new Bedroom("Escuro", 3, 3, false);
console.log(souBedroom.calcArea());

let souLiveroom = new Liveroom("Grande", 4, 4, "Marrom");
console.log (souLiveroom.calcArea()); */