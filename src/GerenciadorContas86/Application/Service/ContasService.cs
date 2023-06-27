using Application.ViewModel;
using Data.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ContasService
    {
        public ContaViewModel DetalharConta(ContaViewModel param)
        {
            //...chama salvamento no kafka
            //... faço alguma coisa com o parametro 

            //processo, mando pro banco

            param.Nome = param.Nome.ToUpper();

            //... 
            return param;
        }

        public List<ContaViewModel> ListarContas(ContaViewModel param)
        {
            ContasRepository repository = new ContasRepository();

            ContasDto dto = new ContasDto()
            {
                Nome = param.Nome,
                Email = param.Email
            };

            List<ContasDto> contasDto = repository.ListarContas(dto);

            List<ContaViewModel> result = new();

            foreach (ContasDto conta in contasDto)
            {
                ContaViewModel contaVM = new()
                {
                    Nome = conta.Nome,
                    Email = conta.Email
                };

                result.Add(contaVM);
            }
            return result;
        }
    }
}
