using CCT.MetodosExtensao.App;
using Microsoft.Extensions.Configuration;
using Moq;

namespace CCT.MetodosExtensao.UnitTest
{
    [TestClass]
    public class PedidoServiceTest
    {
        [TestMethod]
        public void DeveriaIndicarQuePedidoEhValidoParaPromocao()
        {
            var pedido = new Pedido
            {
                DataCriacao = new DateTime(2022, 5, 3)
            };
            var mockRepo = new Mock<IPedidoRepository>();
            mockRepo.Setup(m => m.Obter(It.IsAny<int>())).Returns(pedido);

            //configura o GetValue para retornar uma data posterior à do pedido
            var dataConfig = new DateTime(2022, 12, 1);
            var mockCfg = new Mock<IConfiguration>();
            mockCfg.Setup(m => m.GetValue<DateTime>(It.IsAny<string>())).Returns(dataConfig);

            var srv = new PedidoService(mockCfg.Object, mockRepo.Object);

            var res = srv.PedidoEhValidoParaPromocao(1);

            Assert.IsTrue(res);
        }








        [TestMethod]
        public void DeveriaIndicarQuePedidoEhValidoParaPromocaoCerto()
        {
            var pedido = new Pedido
            {
                DataCriacao = new DateTime(2022, 5, 3)
            };
            var mockRepo = new Mock<IPedidoRepository>();
            mockRepo.Setup(m => m.Obter(It.IsAny<int>())).Returns(pedido);

            //builda um stub de IConfiguration em memória
            var memConfig = new Dictionary<string, string>
            {
                {"fimPromocao", "2022-12-01"}
            };
            var stubCfg = new ConfigurationBuilder()
                            .AddInMemoryCollection(memConfig)
                            .Build();

            var srv = new PedidoService(stubCfg, mockRepo.Object);

            var res = srv.PedidoEhValidoParaPromocao(1);

            Assert.IsTrue(res);
        }
    }
}