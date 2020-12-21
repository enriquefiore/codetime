using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marvel.Data.Models
{
    public class CharacterEvent
    {
        [Key]
        public int CharacterId { get; set; }
        public int EventId { get; set; }
        public Character Character { get; set; }
        public Event Event { get; set; }
    }
}