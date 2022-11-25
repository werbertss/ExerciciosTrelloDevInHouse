//Minha tentativa
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Conta = /** @class */ (function () {
    function Conta(numero, saldo, estaAtiva, dono) {
        this.numero = numero;
        this.saldo = saldo;
        this.estaAtiva = estaAtiva;
        this.dono = dono;
    }
    return Conta;
}());
var ContaEmpresa = /** @class */ (function (_super) {
    __extends(ContaEmpresa, _super);
    function ContaEmpresa(numero, saldo, estaAtiva, dono, limiteDeDeposito, valorDeposito, erroMensagem) {
        var _this = _super.call(this, numero, saldo, estaAtiva, dono) || this;
        _this.limiteDeDeposito = limiteDeDeposito;
        _this.valorDeposito = valorDeposito;
        _this.erroMensagem = erroMensagem;
        return _this;
    }
    ContaEmpresa.prototype.deposito = function (valor) {
        if (valor === void 0) { valor = 300; }
        if (valor <= this.limiteDeDeposito) {
            return this.saldo + valor;
        }
    };
    ContaEmpresa.prototype.imprimeValorConta = function () {
        console.log(this.deposito());
    };
    return ContaEmpresa;
}(Conta));
var ReContaEmpresa = new ContaEmpresa(35720, 100, true, "Webert", 1000, 500, "O valor depositoado ultrapassou os 1000");
console.log(ReContaEmpresa, "Saldo atualizado: ", ReContaEmpresa.imprimeValorConta());
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
