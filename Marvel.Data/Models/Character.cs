using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marvel.Data.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Modified { get; set; }
        public string ResourceUri { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public ICollection<Url> Urls { get; set; }
        public ICollection<CharacterComic> Comics { get; set; }
        public ICollection<CharacterEvent> Events { get; set; }
        public ICollection<CharacterSerie> Series { get; set; }
        public ICollection<CharacterStory> Stories { get; set; }
    }
}