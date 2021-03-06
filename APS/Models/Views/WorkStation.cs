﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS.Models.Views
{
    public class WorkStation
    {
        public int WId { get; set; }

        public String Title { get; set; }
        public String Image { get; set; }
        public String Description { get; set; }
        public double SetupTime { get; set; }
        public double ProcessingTime { get; set; }

        public int VeiwOrder { get; set; }
        public int GroupUID { get; set; }
        public int WorkStationGroupID { get; set; }
    }
}