using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marvel.Data.Models
{
    public class CharacterSerie
    {
        [Key]
        public int CharacterId { get; set; }
        public int SerieId { get; set; }
        public Character Character { get; set; }
        public Serie Serie { get; set; }
    }
}