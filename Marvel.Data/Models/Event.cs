using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marvel.Data.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResourceUri { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public ICollection<Url> Urls { get; set; }
    }
}