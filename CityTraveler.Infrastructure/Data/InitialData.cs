using CityTraveler.Domain.Entities;
using CityTraveler.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CityTraveler.Infrastucture.Data
{
    public static class InitialData
    {
        public static void SetupEnums(ApplicationContext _context)
        {
            if (!_context.CommentStatuses.Any())
            {
                _context.AddRange(
                    CommentStatus.Liked,
                    CommentStatus.OMG,
                    CommentStatus.Suprised);

                _context.SaveChanges();
            }

            if (!_context.EntertainmentType.Any())
            {
                _context.AddRange(
                    EntertainmentType.Event,
                    EntertainmentType.Institution,
                    EntertainmentType.Landskape);

                _context.SaveChanges();
            }


            if (!_context.TripStatuses.Any())
            {
                _context.AddRange(
                    TripStatus.InProgress,
                    TripStatus.New,
                    TripStatus.Passed);

                _context.SaveChanges();
            }
        }

        public static void SetupData(ApplicationContext _context)
        {
            var rand = new Random();
            _context.Entertaiments.Add(new EntertaimentModel 
            { 
                Title = "hotel", 
                Description = "trteter",
                Type = _context.EntertainmentType.FirstOrDefault(x => x.Id == EntertainmentType.Institution.Id),
                Address = new AddressModel()
                {
                    ApartmentNumber = "3d",
                    Coordinates = new CoordinatesModel()
                    { 
                        Latitude = 1, 
                        Longitude = 2 
                    },
                    HouseNumber = "numberOne",
                    Street = new StreetModel()
                    {
                        Title = "Street",
                        Description = "Desc"
                    }
                }
            });
            _context.SaveChanges();
            //_context.Add(new StreetModel { Title = RandomString(20), Description = RandomString(20) });
            _context.SaveChanges();
            _context.Entertaiments.Load();
            _context.Streets.Load();
            Console.WriteLine(_context.Entertaiments.FirstOrDefault());
            Console.WriteLine(_context.Streets.FirstOrDefault());
            StreetModel street = _context.Streets.FirstOrDefault();
            EntertaimentModel e = _context.Entertaiments.FirstOrDefault();
            /*AddressModel address = new AddressModel { HouseNumber = RandomString(5), Street = street, Entertaiment = e };
      
            _context.Add(address);
            _context.SaveChanges();
            _context.Add(new CoordinatesModel { Latitude = rand.NextDouble(), Longitude = rand.NextDouble() });
            _context.SaveChanges();
            for (int i = 0; i < 50; i++)
            {
                _context.Add(new EntertaimentModel { Title = "hotel", Description = "trteter", Address = _context.Addresses.FirstOrDefault(x=>x.HouseNumber == "2") });
                //_context.Entertaiments.Add(new Entertaiment { Title = "hotel", Description = "trteter" });
                _context.SaveChanges();
                //_context.Entertaiments.Load();
                EntertaimentModel t = _context.Entertaiments.FirstOrDefault(X => X.Description.Contains("tr"));

            }
            for (int i = 0; i < 50; i++)
            {
                _context.Add(new StreetModel { Title = RandomString(20), Description = RandomString(20) });
                _context.SaveChanges();
                _context.Streets.Load();
            }
            for (int i = 0; i < 50; i++)
            {
                _context.Add(new CoordinatesModel { Latitude = rand.NextDouble(), Longitude = rand.NextDouble() });
                _context.SaveChanges();
                _context.Coordinates.Load();
            }
            for (int i = 0; i < 50; i++)
            {
                _context.Add(new AddressModel { HouseNumber = "22", Coordinates = new CoordinatesModel { Latitude = 22, Longitude = 434 } });
                _context.SaveChanges();
                _context.Coordinates.Load();
            }
            for (int i = 0; i < 50; i++)
            {
                _context.Add(new CoordinatesModel { Latitude = 22, Longitude = 434 });
                _context.SaveChanges();
                _context.Coordinates.Load();
            }
            for (int i = 0; i < 50; i++)
            {
                _context.Add(new ApplicationUserModel { Profile = new UserProfileModel { Name = "fff"} });
                _context.SaveChanges();
                _context.Coordinates.Load();
            }        */

        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static Guid ToGuid(int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }
    }
}
