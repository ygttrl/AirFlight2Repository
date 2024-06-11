using AirFlight2.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace AirFlight2.Repository.Configurations
{
    public class AirPortConfiguration : IEntityTypeConfiguration<AirPort>
    {
        public void Configure(EntityTypeBuilder<AirPort> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.AirPortName).IsRequired();

             
            builder.HasData
                (
                   new AirPort {Id=1,CountryId=1,AirPortName= "Şakirpaşa Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=2,CountryId=1,AirPortName= "Ankara Esenboğa Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=3,CountryId=1,AirPortName= "Antalya Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=4,CountryId=1,AirPortName= "Gazipaşa Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=5,CountryId=1,AirPortName= "Balıkesir Koca Seyit Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=6,CountryId=1,AirPortName= "Bursa Yenişehir Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=7,CountryId=1,AirPortName= "Çanakkale Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=8,CountryId=1,AirPortName= "Denizli Çardak Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=9,CountryId=1,AirPortName= "Diyarbakır Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=10,CountryId=1,AirPortName= "Elazığ Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=11,CountryId=1,AirPortName= "Erzurum Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=12,CountryId=1,AirPortName= "Hasan Polatkan Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=13,CountryId=1,AirPortName= "Gaziantep Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=14,CountryId=1,AirPortName= "Hatay Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=15,CountryId=1,AirPortName= "Isparta Süleyman Demirel Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=16,CountryId=1,AirPortName= "İstanbul Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=17,CountryId=1,AirPortName= "Sabiha Gökçen Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=18,CountryId=1,AirPortName= "Adnan Menderes Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=19,CountryId=1,AirPortName= "Kars Harakani Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=20,CountryId=1,AirPortName= "Erkilet Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=21,CountryId=1,AirPortName= "Cengiz Topel Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=22,CountryId=1,AirPortName= "Konya Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=23,CountryId=1,AirPortName= "Zafer Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=24,CountryId=1,AirPortName= "Malatya Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=25,CountryId=1,AirPortName= "Dalaman Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=26,CountryId=1,AirPortName= "Milas-Bodrum Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=27,CountryId=1,AirPortName= "Nevşehir Kapadokya Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=28,CountryId=1,AirPortName= "Ordu-Giresun Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=29,CountryId=1,AirPortName= "Rize-Artvin Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=30,CountryId=1,AirPortName= "Samsun Çarşamba Havalimanı\t", CreatedDate=DateTime.Now },
                   new AirPort {Id=31,CountryId=1,AirPortName= "Sinop Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=32,CountryId=1,AirPortName= "Sivas Nuri Demirağ Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=33,CountryId=1,AirPortName= "Şanlıurfa GAP Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=34,CountryId=1,AirPortName= "Tekirdağ Çorlu Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=35,CountryId=1,AirPortName= "Trabzon Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=36,CountryId=1,AirPortName= "Uşak Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=37,CountryId=1,AirPortName= "Van Ferit Melen Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=38,CountryId=1,AirPortName= "Zonguldak Havalimanı", CreatedDate=DateTime.Now }, 
                   new AirPort {Id=39 ,CountryId=2,AirPortName= "Merzbrück Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=40 ,CountryId=2,AirPortName= "Leipzig-Altenburg Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=41, CountryId=2,AirPortName= "Augsburg Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=42 ,CountryId=2,AirPortName= "Baden Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=43, CountryId=2,AirPortName= "Berlin Schönefeld Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=44, CountryId=2,AirPortName= "Berlin Tegel Havalimanı ", CreatedDate=DateTime.Now },
                   new AirPort {Id=45, CountryId=2,AirPortName= "Bindlacher Berg Havalimanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=46 ,CountryId=2,AirPortName= "Borkum Havaalanı", CreatedDate=DateTime.Now },
                   new AirPort {Id=47, CountryId = 2,AirPortName= "Braunschweig Havalimanı", CreatedDate=DateTime.Now },                 
                   new AirPort {Id=48, CountryId = 2, AirPortName = "Bremerhaven Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=49 ,CountryId = 2, AirPortName = "Dortmund Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=50 ,CountryId = 2, AirPortName = "Dresden Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=51 ,CountryId = 2, AirPortName = "Düsseldorf Uluslararası Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=52 ,CountryId = 2, AirPortName = "Düsseldorf-Mönchengladbach Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=53 ,CountryId = 2, AirPortName = "Frankfurt Egelsbach Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=54 ,CountryId = 2, AirPortName = "Emden Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=55, CountryId = 2, AirPortName = "Erfurt Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=56, CountryId = 2, AirPortName = "Frankfurt Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=57, CountryId = 2, AirPortName = "Friedrichshafen Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=58, CountryId = 2, AirPortName = "Giebelstadt Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=59, CountryId = 2, AirPortName = "Frankfurt-Hahn Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=60, CountryId = 2, AirPortName = "Hamburg Finkenwerder Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=61, CountryId = 2, AirPortName = "Hamburg Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=62, CountryId = 2, AirPortName = "Hannover-Langenhagen Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=63, CountryId = 2, AirPortName = "Heide-Büsum Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=64, CountryId = 2, AirPortName = "Uetersen Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=65, CountryId = 2, AirPortName = "Helgoland Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=66, CountryId = 2, AirPortName = "Heringsdorf Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=67, CountryId = 2, AirPortName = "Hof-Plauen Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=68, CountryId = 2, AirPortName = "Hoppstädten-Weiersbach Havaalanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=69, CountryId = 2, AirPortName = "Ingolstadt Manching Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=70, CountryId = 2, AirPortName = "Kassel Calden Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=71, CountryId = 2, AirPortName = "Kiel Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=72, CountryId = 2, AirPortName = "Köln Bonn Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=73, CountryId = 2, AirPortName = "Black Forest Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=74, CountryId = 2, AirPortName = "Leipzig/Halle Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=75, CountryId = 2, AirPortName = "Lübeck Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=76, CountryId = 2, AirPortName = "Magdeburg-Cochstedt Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=77, CountryId = 2, AirPortName = "Mainz-Finthen Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=78, CountryId = 2, AirPortName = "Mannheim City Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id = 79, CountryId = 2, AirPortName = "Memmingen Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=80, CountryId = 2, AirPortName = "Münih Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=81, CountryId = 2, AirPortName = "Münster Osnabrück Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=82, CountryId = 2, AirPortName = "Nannhousen Havaalanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=83, CountryId = 2, AirPortName = "Neubrandenburg Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=84, CountryId = 2, AirPortName = "Nürnberg Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=85, CountryId = 2, AirPortName = "Paderborn Lippstadt Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=86, CountryId = 2, AirPortName = "Rechlin-Lärz Havaalanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=87,CountryId = 2, AirPortName = "Rostock-Laage Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=88, CountryId = 2, AirPortName = "Saarbrücken Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=89, CountryId = 2, AirPortName = "Siegerland Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=90, CountryId = 2, AirPortName = "Stadtlohn-Vreden Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=91, CountryId = 2, AirPortName = "Stuttgart Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=92, CountryId = 2, AirPortName = "Trier-Föhren Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=93, CountryId = 2, AirPortName = "Weeze Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=94, CountryId = 2, AirPortName = "Sylt Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort {Id=95, CountryId = 2, AirPortName = "Zweibrücken Havalimanı", CreatedDate = DateTime.Now },
                   new AirPort { Id = 96, CountryId = 2, AirPortName = "Bremen Havalimanı", CreatedDate = DateTime.Now },  
                   new AirPort { Id =97, CountryId =3, AirPortName = "Atlanta", CreatedDate = DateTime.Now },
                   new AirPort { Id =98, CountryId =3, AirPortName = "Chicago O’Hare", CreatedDate = DateTime.Now },
                   new AirPort { Id =99, CountryId =3, AirPortName = "Los Angeles", CreatedDate = DateTime.Now },
                   new AirPort { Id =100, CountryId =3, AirPortName = "Denver", CreatedDate = DateTime.Now },
                   new AirPort { Id =101, CountryId =3, AirPortName = "Dallas/Fort Worth\t", CreatedDate = DateTime.Now },
                   new AirPort { Id =102, CountryId =3, AirPortName = "New York JFK", CreatedDate = DateTime.Now },
                   new AirPort { Id =103, CountryId =3, AirPortName = "San Francisco", CreatedDate = DateTime.Now },
                   new AirPort { Id =104, CountryId =3, AirPortName = "Las Vegas", CreatedDate = DateTime.Now },
                   new AirPort { Id =105, CountryId =3, AirPortName = "Charlotte", CreatedDate = DateTime.Now },
                   new AirPort { Id =106, CountryId =3, AirPortName = "Houston Bush", CreatedDate = DateTime.Now },
                   new AirPort { Id =107, CountryId =3, AirPortName = "Miami", CreatedDate = DateTime.Now },
                   new AirPort { Id =108, CountryId =3, AirPortName = "Phoenix", CreatedDate = DateTime.Now },
                   new AirPort { Id =109, CountryId =3, AirPortName = "Orlando", CreatedDate = DateTime.Now },
                   new AirPort { Id =110, CountryId =3, AirPortName = "Seattle", CreatedDate = DateTime.Now },
                   new AirPort { Id =111, CountryId =3, AirPortName = "Minneapolis/St", CreatedDate = DateTime.Now },
                   new AirPort { Id =112, CountryId =3, AirPortName = "Newark", CreatedDate = DateTime.Now },
                   new AirPort { Id =113, CountryId =3, AirPortName = "Philadelphia", CreatedDate = DateTime.Now },
                   new AirPort { Id =114, CountryId =3, AirPortName = "Boston", CreatedDate = DateTime.Now },
                   new AirPort { Id =115, CountryId =3, AirPortName = "florida", CreatedDate = DateTime.Now },
                   new AirPort { Id =116, CountryId =3, AirPortName = "New York LaGuardia", CreatedDate = DateTime.Now }

                );

        }
    }
}
