using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marvel.Data.Models
{
    public class CharacterStory
    {
        [Key]
        public int CharacterId { get; set; }
        public int StoryId { get; set; }
        public Character Character { get; set; }
        public Story Story { get; set; }
    }
}