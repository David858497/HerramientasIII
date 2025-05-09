﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feriados.Dominio.Entidades
{
    [Table("Festivo")]
    public class Festivo
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nombre"), StringLength(100)]
        public string Nombre { get; set; }
        [Column("Dia")]
        public int Dia { get; set; }
        [Column("Mes")]
        public int Mes { get; set; }
        [Column("DiaPascua")]
        public int DiaPascua { get; set;}
        [Column("IdTipo")]
        public int IdTipo { get; set; }
        public Tipo IdType { get; set; }
    }
}
