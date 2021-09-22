using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Infra.CrossCutting.IoC
{
    public class InjecaoDeDependenciaModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            InjecaoDeDependenciaConfig.Load(builder);
        }
    }
}
