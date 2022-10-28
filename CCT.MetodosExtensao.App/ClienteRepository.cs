namespace CCT.MetodosExtensao.App
{
    public class ClienteRepository
    {
        public Cliente Atualizar(Cliente cliente)
        {
            if (!cliente.EhValido())
            {
                throw new ArgumentException("Cliente não é válido");
            }
            return cliente;
        }
    }
}
