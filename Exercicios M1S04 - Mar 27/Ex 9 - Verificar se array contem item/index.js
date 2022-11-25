const cidades = [
    { nome: 'Patos de Minas', populacao: 153585 },
    { nome: 'Lages', populacao: 157349 },
    { nome: 'Ibiúna', populacao: 79479 },
    { nome: 'Maringá', populacao: 403063 },
    { nome: 'Curitiba', populacao: 1963726 },
    { nome: 'Florianópolis', populacao: 508826 },
    { nome: 'Pato Branco', populacao: 84779 },
    ];

    var found;
    for(var i = 0; i < cidades.length; i++) {
    if (cidades[i].nome == 'Florianópolis') {
    found = true;
    break;
    }}

    if (found == true){
        console.log('Florianópolis'.toLowerCase());
    }else{ 
        console.log ("Não possui.");
    }