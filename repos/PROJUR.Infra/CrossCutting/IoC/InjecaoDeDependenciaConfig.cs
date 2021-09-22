using Autofac;
using PROJUR.Aplicacao.Interface;
using PROJUR.Aplicacao.Servico;
using PROJUR.Dominio.Core.Interface;
using PROJUR.Dominio.Core.Servicos;
using PROJUR.Dominio.Servico;
using PROJUR.Infra.Data.Repositorio;


namespace PROJUR.Infra.CrossCutting.IoC
{
    public class InjecaoDeDependenciaConfig
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Injecao de dependencia
            builder.RegisterType<AplicacaoServicoUsuario>().As<IAplicacaoServicoUsuario>();
            builder.RegisterType<ServicoUsuario>().As<IServicoUsuario>();
            builder.RegisterType<RepositorioUsuario>().As<IRepositorioUsuario>();
            #endregion
        }
    }
}
