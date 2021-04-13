const url = '/api/LegalPersonService/$cnpj';

function findCNPJ() {
    debugger;
    var cnpj = document.getElementById("cnpj").value; 
    var urlWithDocument = url.replaceAll("$cnpj", cnpj).replaceAll("-","");
    loadDoc(urlWithDocument);
}

function loadDoc(urlWithCNPJ) {
    this.getJSON(urlWithCNPJ, function(err, data) {

        //RETORNO DO SERVIÇO:
        console.log("nome: " + data.nome);
        document.getElementById("name").value = data.nome;
    });
}

var getJSON = function(url, callback) {
    var xhr = new XMLHttpRequest(); //XMLHttpRequest é um objeto que 
                                    //fornece funcionalidade ao cliente para 
                                    //transferir dados entre um cliente e um servidor.
    xhr.open('GET', url, true);
    xhr.responseType = 'json';
    xhr.onload = function() {
      var status = xhr.status;
      if (status === 200) {
        callback(null, xhr.response);
      } else {
        callback(status, xhr.response);
      }
    };
    xhr.send();
};



