using Microsoft.Extensions.Configuration;

namespace CCT.MetodosExtensao.App
{
    public class PedidoService
    {
        private IConfiguration Config { get; }
        private IPedidoRepository Repo { get; }

        public PedidoService(IConfiguration cfg,
                             IPedidoRepository repo)
        {
            Config = cfg;
            Repo = repo;
        }

        public bool PedidoEhValidoParaPromocao(int idPedido)
        {
            var ped = Repo.Obter(idPedido);
            var dataPromo = Config.GetValue<DateTime>("fimPromocao");
            return ped.DataCriacao <= dataPromo;
        }
    }
}
