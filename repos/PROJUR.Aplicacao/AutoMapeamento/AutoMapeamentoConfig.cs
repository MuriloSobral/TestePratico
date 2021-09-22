using AutoMapper;
using PROJUR.Aplicacao.DTOs;
using PROJUR.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJUR.Aplicacao.AutoMapeamento
{
    public class AutoMapeamentoConfig : Profile
    {
        public AutoMapeamentoConfig()
        {
            #region DTO para Entidade
            CreateMap<UsuarioDTO, Usuario>();
            #endregion

            #region Entidade para DTO
            CreateMap<Usuario, UsuarioDTO>();
            #endregion
        }
    }
}
