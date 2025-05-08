using System.Collections.Generic;
using System.Linq;

namespace tp03.Models
{
    static public class Empresa
    {
       static public Dictionary<string, Disco> catalogo = new Dictionary<string, Disco>();

        static public void PrecargarDiscos()
        {
            catalogo.Add ("1", new Disco("1", "The Beatles", new List<string> {"Come Together", "Something"}, "George Martin", "Rock", "TheBeatles.jpg", "Disco Beatles"));
            catalogo.Add ("2", new Disco("2", "Pink Floyd", new List<string> {"Time", "Money"}, "David Gilmour", "Rock Progresivo", "pinkfloyd.png", "Disco Pink Floyd"));
            catalogo.Add ("3", new Disco("3", "Daft Punk", new List<string> {"Get Lucky", "Instant Crush"}, "Thomas Bangalter", "Electrónica", "daftpunk.jpeg", "Disco Daft Punk"));
            catalogo.Add ("4", new Disco("4", "Queen", new List<string> {"Bohemian Rhapsody", "Don't Stop Me Now"}, "Roy Thomas Baker", "Rock", "queen.jpeg", "Disco Queen"));
            catalogo.Add ("5", new Disco("5", "Michael Jackson", new List<string> {"Fofy Jean", "Thriller"}, "Quincy Jones", "Pop", "mj.jfif", "Disco Michael Jackson"));
            catalogo.Add ("6", new Disco("6", "Adele", new List<string> {"Hello", "Rolling in the Deep"}, "Paul Epworth", "Soul", "adele.jfif", "Disco Adele"));
           catalogo.Add ("7", new Disco("7", "Nirvana", new List<string> {"Smells Like Teen Spirit", "Come As You Are"}, "Butch Vig", "Grunge", "nirvana.jpg", "Disco Nirvana"));
           catalogo.Add ("8", new Disco("8", "Coldplay", new List<string> {"Yellow", "Fix You"}, "Brian Eno", "Alternative", "coldplay.jfif", "Disco Coldplay"));
            catalogo.Add ("9", new Disco("9", "Beyoncé", new List<string> {"Halo", "Crazy in Love"}, "Scott Storch", "R&B", "beyonce.jpg", "Disco Beyonce"));
           catalogo.Add ("10", new Disco("10", "Taylor Swift", new List<string> {"Blank Space", "Love Story"}, "Jack Antonoff", "Pop", "taylorswift.jpg", "Disco Taylor swift"));
        }
    }
}