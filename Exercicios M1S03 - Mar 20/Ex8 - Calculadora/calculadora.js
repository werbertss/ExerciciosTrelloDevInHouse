var operacao = prompt ("Qual o tipo de operação, deseja? (+, -, *, /)");

if (operacao == "+"){

    var num1 = prompt("Primeiro numero: ");
    num1 = parseInt(num1);
    var num2 = prompt("Segundo  numero: ");
    num2 = parseInt(num2);

    var resultado = num1 + num2;
    window.alert ("O resultado do seu cálculo é: " + resultado);
    window.location.href = "index.html";


}if (operacao == "-"){

    const primeiroValor = prompt ("Qual primeiro valor deseja calcular?");
    const segundoValor = prompt ("Qual segundo valor deseja calcular?");
    const resultado = primeiroValor - segundoValor;
    window.alert ("O resultado do seu cálculo é: " + resultado);
    window.location.href = "index.html"

}if(operacao == "*"){

    const primeiroValor = prompt ("Qual primeiro valor deseja calcular?");
    const segundoValor = prompt ("Qual segundo valor deseja calcular?");
    const resultado = primeiroValor * segundoValor;
    window.alert ("O resultado do seu cálculo é: " + resultado);
    window.location.href = "index.html";

}if(operacao == "/"){

    const primeiroValor = prompt ("Qual primeiro valor deseja calcular?");
    const segundoValor = prompt ("Qual segundo valor deseja calcular?");
    const resultado = primeiroValor / segundoValor;
    window.alert ("O resultado do seu cálculo é: " + resultado);
    window.location.href = "index.html";

}else{
    window.location.href = "index.html";
}