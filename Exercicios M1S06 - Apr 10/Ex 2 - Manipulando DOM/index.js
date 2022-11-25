function calcular(){
    let valor1 = document.getElementById("input1").value;
    valor1 = parseInt(valor1);
    let valor2 = document.getElementById("input2").value;
    valor2 = parseInt(valor2);

    let operador = document.getElementById("operadores").value;
    
    if (operador === "adicao"){
        let resultado = valor1 + valor2;
        document.getElementById("result").textContent = resultado;
    }

    if (operador === "subtrair"){
        let resultado = valor1 - valor2;
        document.getElementById("result").textContent = resultado;
    }
    
    if (operador === "dividir"){
        let resultado = valor1 / valor2;
        document.getElementById("result").textContent = resultado;
    }
    
    if (operador === "multiplicar"){
        let resultado = valor1 * valor2;
        document.getElementById("result").textContent = resultado;
    }
}