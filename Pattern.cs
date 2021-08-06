using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeatsv1
{
    public class Pattern
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public string Description;
        public string Filename;

        public Pattern(int id, string text, string description, string filename)
        {
            Id = id;
            Text = text;
            Description = description;
            Filename = filename;
        }
    }
}
