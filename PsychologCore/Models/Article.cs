namespace PsychologCore.Models
{
    public class Article: Entity
    {
        public string Name { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public int Views { get; set; }

        public string[] Tags { get; set; }
    }
}
