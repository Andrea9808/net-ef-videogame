using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{

    [Table("videogame")]
    
    public class Videogame
    {
        [Key] public int VideogameID { get; set; }

        [Column("videogame_name")]
        public string name { get; set; }

        [Column("videogame_description")]
        public string description { get; set; }

        [Column("videogame_release")]
        public DateTime release {  get; set; }

        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; } = DateTime.Now;


        //vincolo N a 1
        public List<Software_House> houses { get; set; }

        /*public Videogame(int Id, string Name, string Description, DateTime Release, DateTime Created_at, DateTime Updated_at)
        {
            VideogameID = Id;
            name = Name;
            description = Description;
            release = Release;
        }*/
    }

    [Index(nameof(tax_id), IsUnique = true)]
    public class Software_House
    {
        [Key] public int HouseID { get; set; }

        [Column("software_house_name")]
        public string name { get; set; }

        [Column("software_house_tax_id")]
        public string tax_id { get; set; }

        [Column("software_house_city")]
        public string city { get; set; }

        [Column("software_house_country")]
        public string country { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; } = DateTime.Now;


        //Vincolo 1 a N
        public int VideogameID { get; set; }
        public Videogame videogame { get; set; }
    }
}
