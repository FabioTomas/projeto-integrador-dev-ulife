﻿using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Anima.ProjetoIntegrador.Domain.Shared.Interfaces;
using Anima.ProjetoIntegrador.Domain.Shared.Responses;
using Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Contexts;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Repositories
{
    public class AvaliacaoRepository : BaseRepository<Avaliacao>, IAvaliacaoRepository
    {
        public AvaliacaoRepository(IntegradorContext context) : base(context)
        {
        }

        public ProvaTurmaResponse? ObterProvaTurmaPorAvaliacao(Guid id)
        {
            var query = from avaliacao in _context.Set<Avaliacao>()
                        join turma in _context.Set<Turma>()
                            on avaliacao.TurmaId equals turma.Id
                        join prova in _context.Set<Prova>()
                            on avaliacao.ProvaId equals prova.Id
                        where avaliacao.Id == id
                        select new ProvaTurmaResponse
                        {
                            IdentificadorProva = prova.Id.ToString(),
                            NomeTurma = turma.Nome
                        };

            return query.FirstOrDefault();
        }
    }
}
