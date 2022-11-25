var fahrenheit = [0, 32, 45, 50, 75, 80, 99, 120];
var conversao = fahrenheit.map (function(celsius){
 return (celsius - 32) * 5 / 9;
});

console.log ("Valores em Fahrenheit: "+ fahrenheit);

console.log ("Valores em Celsius: "+ conversao);
