﻿using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Responses;

namespace Anima.ProjetoIntegrador.Application.Services
{
    public class ProvaService : IProvaService
    {
        private readonly IProvaRepository _provaRepository;

        public ProvaService(IProvaRepository provaRepository)
        {
            _provaRepository = provaRepository;
        }

        public IList<QuestaoResponse> ConsultarQuestoesPorProva(Guid id)
        {
            return _provaRepository.ConsultarQuestoesPorProva(id);
        }
    }
}
