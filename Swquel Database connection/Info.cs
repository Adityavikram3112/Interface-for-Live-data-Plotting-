using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swquel_Database_connection
{
    public class Info
    {
        public DateTime LogTime { get; set; }

        public int Values1 { get; set; }
        public int Ind { get; set; } 

        public float Val_1 { get; set; }

        public float  EtrSgt { get; set; }
        public float  DrtSgt { get; set; }
        public float  MillSpeed { get; set; }
        public float DriveSideLoad { get; set; }
        public float OpSideLoad { get; set; }
        public float EtrTension { get; set; }
        public float DtrTension { get; set; }
        public float Dspt { get; set; }
        public float Ospt { get; set; }
        public int BreakCount { get; set; }
        public float CoilWeight { get; set; }
        public float CoilLength { get; set; }
        public int MILL_SPD_GRT_15 { get; set; }
        public int Avg { get; set; }

        public string  FullInfo
        {
            get 
            {
                return $"{Val_1}\t{LogTime} \t {EtrSgt} \t {DrtSgt} \t {MillSpeed} \t {DriveSideLoad}\t{OpSideLoad}\t{EtrTension}\t{DtrTension}\t{Dspt}\t{Ospt}\t {BreakCount}\t{CoilWeight}\t{CoilLength}\t{MILL_SPD_GRT_15}  "; 
            }
            //set { myVar = value; }
        } //{Ind}  {Values1}

    }
}
