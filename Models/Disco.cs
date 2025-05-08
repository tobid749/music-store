namespace tp03.Models;

public class Disco
{
    public string ID { get; private set; }
    public string Artista { get; private set; }
    public List<string> Temas { get; private set; }
    public string productor { get; private set; }
public string generoMusical { get; private set; }
public string foto { get; private set; }
public string titulo { get; private set; }
    public Disco(string ID, string Artista, List<string> temas, string productor, string generoMusical, string foto, string titulo)
    {
        this.ID = ID;
        this.Artista = Artista;
        this.productor = productor;
        this.generoMusical = generoMusical;
        this.foto = foto;
        this.titulo = titulo;
      this.Temas = temas;
    }
    
}