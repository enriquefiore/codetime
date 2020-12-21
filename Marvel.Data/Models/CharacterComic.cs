using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marvel.Data.Models
{
    public class CharacterComic
    {
        [Key]
        public int CharacterId { get; set; }
        public int ComicId { get; set; }
        public Character Character { get; set; }
        public Comic Comic { get; set; }
    }
}