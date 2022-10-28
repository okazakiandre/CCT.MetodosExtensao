namespace CCT.MetodosExtensao.App
{
    public static class ClienteExtensions
    {
        public static bool EhValido(this Cliente cli)
        {
            if (cli is null)
            {
                return false;
            }
            if (cli.NumeroCpf <= 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(cli.Nome))
            {
                return false;
            }
            return true;
        }

        public static void Atualizar(this Cliente cli)
        {
            var repo = new ClienteRepository();
            repo.Atualizar(cli);
        }
    }
}
