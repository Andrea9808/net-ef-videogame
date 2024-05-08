using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class VideogameManager
    {

        //crea il videogioco
         public static bool CreaVideogioco(string name, string description, DateTime release, int softwareHouseId)
         {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {

                    Videogame nuovoVideogame = new Videogame()
                    {
                        _name = name,
                        _description = description,
                        _release = release,
                        SoftwareHouseID = softwareHouseId
                    };

                    db.videogames.Add(nuovoVideogame);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Si è verificato un errore durante la creazione del videogioco: {e.Message}");
                }

                return false;
            }
         }


        //crea la software house
        public static bool CreaSoftwareHouse(string name, string taxID, string city, string country)
        {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {

                    Software_House nuovaSoftwareHouse = new Software_House(name, taxID, city, country);
                  

                    db.software_houses.Add(nuovaSoftwareHouse);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Si è verificato un errore durante la creazione della Software House: {e.Message}");
                }

                return false;
            }
        }


        //verifica l'ID della software house
        public static bool VerificaEsistenzaSoftwareHouse(int softwareHouseId)
        {
            using (VideogameContext db = new VideogameContext())
            {
               
                return db.software_houses.Any(x => x.HouseID == softwareHouseId);
            }
        }


        //Stampa i videogiochi tramite l'id
        public static Videogame GetVideogameById(int id)
        {
            using (VideogameContext db = new VideogameContext())
            {
                return db.videogames.FirstOrDefault(x => x.VideogameID == id);
            }
        }

        //Stampa i videogiochi tramite il nome
        public static Videogame GetVideogameByName(string name)
        {
            using (VideogameContext db = new VideogameContext())
            {
                return db.videogames.FirstOrDefault(x => x._name.Contains(name));
            }
        }

        
        //Elimina i dati
        public static bool Delete(int id)
        {
            using (VideogameContext db = new VideogameContext())
            {
                Videogame videogameDelete = db.videogames.FirstOrDefault(x => x.VideogameID == id);

                if (videogameDelete != null)
                {
                    db.Remove(videogameDelete);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine($"Nessun videogioco trovato con ID {id}. Eliminazione non riuscita.");
                    return false;
                }

            }
        }
    }
}
