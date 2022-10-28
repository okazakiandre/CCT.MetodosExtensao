using CCT.MetodosExtensao.App;

var lista = new List<string>();
var data = new DateTime(2022, 1, 17, 12, 15, 23);
var valor = 1234.56;

Console.WriteLine(data.ToStringPtBr());
Console.WriteLine(valor.ToStringPtBr());

var cliente = new Cliente();
cliente.Atualizar();
