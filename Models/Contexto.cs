﻿using Microsoft.EntityFrameworkCore;

namespace WMVCADS2023.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set;}
    }
}
