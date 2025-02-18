﻿using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations
{
    public class QuestaoConfiguration : IEntityTypeConfiguration<Questao>
    {
        public void Configure(EntityTypeBuilder<Questao> builder)
        {
            builder.ToTable("questao");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.Enunciado)
                .IsRequired()
                .HasColumnName("enunciado");

            builder
                .Property(x => x.ProfessorId)
                .IsRequired()
                .HasColumnName("professor_id");


        }
    }
}
