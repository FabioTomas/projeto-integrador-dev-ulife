﻿namespace Anima.ProjetoIntegrador.Domain.Shared.Responses
{
    public class TurmaMatriculaAlunoResponse
    {
        public string? IdTurma { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProfessor { get; set; }
        public bool Matriculado { get; set; }
    }
}
