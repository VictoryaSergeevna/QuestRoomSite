using Laba_14EntityASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laba_14EntityASP.Utils
{
    public class IndexViewModel
    {
        public IEnumerable<QuestRoom> QuestRooms { get; set; }
        public PageInfo PageInfo { get; set; }
        public string SelectedPhone { get; set; }
    }
}