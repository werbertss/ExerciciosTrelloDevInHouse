let operacao = "+";
let num1 =50;
let num2 = 3;
let resultado;

switch (operacao) {

        case "+":
        resultado = num1 + num2;
        console.log("Resultado é: "+ resultado);
        break;

        case "-":
        resultado = num1 - num2;
        console.log("Resultado é: "+ resultado);
        break;

        case "/":
        resultado = num1 / num2;
        console.log("Resultado é: "+ resultado);
        break;

        case "*":
        resultado = num1 * num2;
        console.log("Resultado é: "+ resultado);
        break;

        default:
            console.log ("A operação digitada não corresponde, ou não está disponivel. Digite: (+, -, / ou *)");
}