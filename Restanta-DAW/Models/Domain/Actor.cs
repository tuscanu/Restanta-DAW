
namespace Restanta_DAW.Models.Domain
{
    public class Actor
    {
        public string ActorId { get; set; }
        public string Nume { get; set; }

        public List <FilmeActor> FilmeActor{get;set;}

        

        //public string ICollection<FilmeActor> FilmeActor { get; set; }
    }

}
