namespace Restanta_DAW.Models.Domain
{
    public class Filme
    {
        public int FilmId {  get; set; }
        public string Titlu { get; set; }

        public List<FilmeActor> FilmeActor { get; set; }
        //public ICollection<FilmeActor> FilmeActor { get; set; }
    }
}
