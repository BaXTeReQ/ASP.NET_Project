using finalApp.Data;
using finalApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuth.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider
                .GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();

            var roleManager = serviceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();
            var roleName = "Administrator";
            IdentityResult result;

            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                result = await roleManager
                    .CreateAsync(new IdentityRole(roleName));
                if (result.Succeeded)
                {
                    var userManager = serviceProvider
                        .GetRequiredService<UserManager<IdentityUser>>();
                    var config = serviceProvider
                        .GetRequiredService<IConfiguration>();
                    var admin = await userManager
                        .FindByEmailAsync(config["AdminCredentials:Email"]);

                    if (admin == null)
                    {
                        admin = new IdentityUser()
                        {
                            UserName = config["AdminCredentials:Email"],
                            Email = config["AdminCredentials:Email"],
                            EmailConfirmed = true
                        };

                        result = await userManager
                            .CreateAsync(admin, config["AdminCredentials:Password"]);
                        if (result.Succeeded)
                        {
                            result = await userManager
                                .AddToRoleAsync(admin, roleName);
                            if (!result.Succeeded)
                            {
                                // todo: process errors
                            }
                        }
                    }
                }
            }

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(new List<Car>(){
                        new Car()
                        {
                            CarName = "Ford",
                            CarModel = "Mondeo MK3 ST220",
                            CarOrigin = "USA",
                            CarYear = 2005,
                            CarPrice = 200,
                            CarDescription = "'Po co kupować inne samochody?' powiedział Jeremy Clarkson jeżdząc Mondeo ST220. Jest to auto o subtelnym wygladzie - brak nadmuchanych spoilerów, gigantycznych wydechów i innych 'ozdób'. Miny zaskoczonych kierowników BMW i MB są bezcenne. Nie spodziewają się iż Ford ich łyknie. Genialny, niezawodny silnik wolnossący wykonany z aluminium z kutym korbowodem i łańcuchem rozrządu. No i to prowadzenie.",
                            CarPicture = "/images/Img1.jpg"
                        },
                        new Car()
                        {
                            CarName = "Opel",
                            CarModel = "Astra J",
                            CarOrigin = "Niemcy",
                            CarYear = 2015,
                            CarPrice = 350,
                            CarDescription = "Opel Astra J to prawdziwy hit sprzedaży na polskim rynku: niejednokrotnie okupowała miejsce trzeciego najlepiej sprzedającego się samochodu w naszym kraju, zaraz po dwóch niekwestionowanych bestsellerach – Skodzie Octavii i Skodzie Fabii. Nietrudno oprzeć się wrażeniu, że wynika to w dużej mierze z przyzwyczajenia Polaków do kompaktowego Opla. Od lat uchodził on bowiem za trwały, porządnie wykonany i solidny mechanicznie samochód z szeroką paletą dostępnych wariantów nadwozia.",
                            CarPicture = "/images/Img2.jpg"
                        },
                        new Car()
                        {
                            CarName = "Tesla",
                            CarModel = "Model S",
                            CarOrigin = "USA",
                            CarYear = 2019,
                            CarPrice = 1000,
                            CarDescription = "Luksusowy model segmentu E, napędzany silnikiem elektrycznym, produkowany od 2012 roku. To pierwszy seryjnie produkowany elektryczny sedan klasy premium. Prace nad nim trwały co najmniej od połowy ubiegłej dekady – w 2009 roku zaprezentowano prototyp WhiteStar zaprojektowany przez Franza von Holzhausena, na którym opiera się wersja produkcyjna Modelu S. Samochód okazał się pierwszym globalnym sukcesem Tesli, dotychczas sprzedano go w liczbie bliskiej 50 tys. egzemplarzy. Model S był też wielokrotnie nagradzany, m.in. tytułem World Green Car of the Year 2013 i Motor Trend Car of the Year 2013.",
                            CarPicture = "/images/Img3.jpg"
                        },
                        new Car()
                        {
                            CarName = "Tesla",
                            CarModel = "Model 3",
                            CarOrigin = "USA",
                            CarYear = 2018,
                            CarPrice = 1000,
                            CarDescription = "Gdybym miał opisać Teslę Model 3 jednym słowem, wybrałbym 'szał'. Nie pamiętam drugiego auta, po które ustawiały się tak długie kolejki. Gdybym miał użyć tylko dwóch słów, padłoby na 'uzasadniony szał', co zrozumiałem po krótkiej przejażdżce.",
                            CarPicture = "/images/Img4.jpg"
                        },
                        new Car()
                        {
                            CarName = "Tesla",
                            CarModel = "Model X",
                            CarOrigin = "USA",
                            CarYear = 2018,
                            CarPrice = 1000,
                            CarDescription = "Wygląda jak jeżdżący statek kosmiczny, przyspiesza lepiej od topowych modeli Ferrari i wygodnie mieści 7 dorosłych osób. Poznajcie Teslę Model X – samochód będący wyznacznikiem motoryzacyjnej przyszłości. Innowacyjne, nieszablonowe, rewolucyjne – do samochodów marki Tesla można przytoczyć wiele określeń i doskonale pasują one również do największego modelu – Modelu X. Stylistycznie bardzo przypomina on starszy Model S i niedawno debiutujący Model 3, ale X jest przede wszystkim wielki: pięć metrów długości i dwa szerokości robią wrażenie nie tylko z zewnątrz, ale również po zajęciu miejsca w środku",
                            CarPicture = "/images/Img5.jpg"
                        }
                    });
                context.SaveChanges();
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange(new List<Users>(){
                        new Users()
                        {
                            Email = "admin@example.com"                        
                        }
                });
                context.SaveChanges();
            }
            if (!context.Orders.Any())
            {
                context.Orders.AddRange(new List<Order>(){
                        new Order()
                        {
                            OrderPrice = 350,
                            CarId = 1,
                            UserId = 1
                        },
                        new Order()
                        {
                            OrderPrice = 700,
                            CarId = 2,
                            UserId = 1
                        },

                    });
                context.SaveChanges();
            }

        }
    }
}