using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Laba_14EntityASP.EF;
using Laba_14EntityASP.Models;

namespace Laba_14EntityASP.EF
{
    public class QRInitializer: DropCreateDatabaseAlways<QRContext>
    {
        protected override void Seed(QRContext context)
        {
            IList<Phone> phones = new List<Phone>
            {
                new Phone
                {
                    Id=1,
                    PhoneNumber="0979103206"
                },
                 new Phone
                {
                    Id=2,
                    PhoneNumber="0979103200"
                }

            };
            IList<QuestRoom> rooms = new List<QuestRoom> {
            new QuestRoom
            {
                Id = 1,
                Title = "Room Of Fear",
                Description = "Very very screaming room ever",
                DurationTime = "2:00",
                MinPlayersCount = 2,
                MaxPlayersCount = 6,
                FearLevel = 2,
                Difficulty = 5,
                LogoPath = "Photo1.jpg",
                PhoneId=1
            },

            new QuestRoom
            {
                Id = 2,
                Title = "Room Of goddess",
                Description = "No more sorrow, you saved me",
                DurationTime = "3:00",
                MinPlayersCount = 6,
                MaxPlayersCount = 12,
                FearLevel = 4,
                Difficulty = 7,
                LogoPath = "Photo2.jpg",
                PhoneId=2
            }
            };
            context.Phones.AddRange(phones);
            context.QuestRooms.AddRange(rooms);
            //context.SaveChanges();
            base.Seed(context);
        }

           


    }
           
  }
      

    
