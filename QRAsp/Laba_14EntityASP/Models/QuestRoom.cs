using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laba_14EntityASP.Models
{
    public class QuestRoom : IEntity
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string DurationTime { set; get; }
        public int MinPlayersCount { set; get; }
        public int MaxPlayersCount { set; get; }      
        public int FearLevel { set; get; }
        public int Difficulty { set; get; }
        public string LogoPath { set; get; }
        public int PhoneId {get; set;}
        public virtual Phone Phone { set; get; }
    }
}