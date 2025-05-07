using System.Collections.Generic;
using System.Linq;

namespace tp03.Models
{
    static public class Empresa
    {
       static public Dictionary<string, Disco> catalogo;

        static public void PrecargarDiscos()
        {
            catalogo["Disco1"] = new Disco("1", "The Beatles", new List<string> {"Come Together", "Something"}, "George Martin", "Rock", "TheBeatles.jpg", "Disco Beatles");
            catalogo["Disco2"] = new Disco("2", "Pink Floyd", new List<string> {"Time", "Money"}, "David Gilmour", "Rock Progresivo", "pinkfloyd.png", "Disco Pink Floyd");
            catalogo["Disco3"] = new Disco("3", "Daft Punk", new List<string> {"Get Lucky", "Instant Crush"}, "Thomas Bangalter", "Electrónica", "daftpunk.jpeg", "Disco Daft Punk");
            catalogo["Disco4"] = new Disco("4", "Queen", new List<string> {"Bohemian Rhapsody", "Don't Stop Me Now"}, "Roy Thomas Baker", "Rock", "queen.jpeg", "Disco Queen");
            catalogo["Disco5"] = new Disco("5", "Michael Jackson", new List<string> {"Fofy Jean", "Thriller"}, "Quincy Jones", "Pop", "mj.jfif", "Disco Michael Jackson");
            catalogo["Disco6"] = new Disco("6", "Adele", new List<string> {"Hello", "Rolling in the Deep"}, "Paul Epworth", "Soul", "adele.jfif", "Disco Adele");
            catalogo["Disco7"] = new Disco("7", "Nirvana", new List<string> {"Smells Like Teen Spirit", "Come As You Are"}, "Butch Vig", "Grunge", "nirvana.jpg", "Disco Nirvana");
            catalogo["Disco8"] = new Disco("8", "Coldplay", new List<string> {"Yellow", "Fix You"}, "Brian Eno", "Alternative", "coldplay.jfif", "Disco Coldplay");
            catalogo["Disco9"] = new Disco("9", "Beyoncé", new List<string> {"Halo", "Crazy in Love"}, "Scott Storch", "R&B", "beyonce.jpg", "Disco Beyonce");
            catalogo["Disco10"] = new Disco("10", "Taylor Swift", new List<string> {"Blank Space", "Love Story"}, "Jack Antonoff", "Pop", "taylorswift.jpg", "Disco Taylor swift");
        }
    }
}