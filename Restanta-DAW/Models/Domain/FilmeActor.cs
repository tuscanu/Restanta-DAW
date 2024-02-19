namespace Restanta_DAW.Models.Domain
{
    public class FilmeActor
    {
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
