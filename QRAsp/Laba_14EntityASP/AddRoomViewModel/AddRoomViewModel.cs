using Laba_14EntityASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laba_14EntityASP.AddRoomViewModel
{
    public class AddRoomViewModel
    {
        public HttpPostedFileBase File { get; set; }

        public QuestRoom Room { get; set; }
    }
}