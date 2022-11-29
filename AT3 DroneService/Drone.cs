using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT3_DroneService
{

    //Programming Requirement 6.1 : Drone object class
    internal class Drone
    {
        private String cName;
        private String dModel;
        private String sProblem;
        private double sCost;
        private int sTag;

        private readonly static TextInfo text = new CultureInfo("en-AU", false).TextInfo;
        public Drone(String name, String model, String problem, double cost, int tag)
        {
            this.cName = name;
            this.dModel = model;
            this.sProblem = problem;
            this.sCost = cost;
            this.sTag = tag;
        }

        public string CName { get => cName; set => cName = text.ToTitleCase(value); }
        public string DModel { get => dModel; set => dModel = value; }
        public string SProblem { get => sProblem; set => sProblem = text.ToTitleCase(value); }
        public double SCost { get => sCost; set => sCost = value; }
        public int STag { get => sTag; set => sTag = value; }
    }
}
