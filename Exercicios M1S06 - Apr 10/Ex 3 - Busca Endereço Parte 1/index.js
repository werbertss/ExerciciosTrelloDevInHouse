fetch("https://viacep.com.br/ws/01001000/json/", 
{method: "POST",
headers:{
    "content-Type": "application/json"
},
body:JSON.stringify({cep: "35720-000"}),

} 
)

.then((resposta) => 

resposta.json()

)

.then(data => console.log(data))


/* function getUser(id){
    return fetch(`https://viacep.com.br/ws/01001000/json/`)
        .then(data => data.json())
        .catch(err => console.log (err))
}


async function showUserName(id){
    const user = await getUser(id)

    console.log (`O nome do Usuario é: ${cep}` )
} */


//Modelo a ser utilizado função assíncrona
/* async function endereco(){
    await TesteMesmo();
} */