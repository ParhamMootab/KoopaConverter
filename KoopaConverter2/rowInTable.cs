#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace KoopaConverter2
{
    public class rowInTable
    {
        

        public double? HLD { get; set; }
        public double? HV136 { get; set; }
        public double? HB10 { get; set; }
        public double? HRA120 { get; set; }
        public double? HRB1o16 { get; set; }
        public double? HRC120 { get; set; }
        public double? HRD120 { get; set; }
        public double? HRF1o16 { get; set; }
        public double? HR15N { get; set; }
        public double? HR30N { get; set; }
        public double? HR45N { get; set; }
        public double? HR15T { get; set; }
        public double? HR30T { get; set; }
        public double? HR45T { get; set; }
        public double? HSc { get; set; }
        public double? Nomm2 { get; set; }

        public double?[] propertyArr => new double?[] { HLD,HV136,HB10,HRA120,HRB1o16,HRC120,HRD120,HRF1o16,HR15N,HR30N,HR45N,HR15T,HR30T,HR45T,HSc,Nomm2};


        public rowInTable(double? hLK, double? hV136, double? hB10, double? hRA120, double? hRB1o16, double? hRC120, double? hRD120, double? hRF1o16, double? hR15N, double? hR30N, double? hR45N, double? hR15T, double? hR30T, double? hR45T, double? hSc, double? nomm2)
        {
            HLD = hLK;
            HV136 = hV136;
            HB10 = hB10;
            HRA120 = hRA120;
            HRB1o16 = hRB1o16;
            HRC120 = hRC120;
            HRD120 = hRD120;
            HRF1o16 = hRF1o16;
            HR15N = hR15N;
            HR30N = hR30N;
            HR45N = hR45N;
            HR15T = hR15T;
            HR30T = hR30T;
            HR45T = hR45T;
            HSc = hSc;
            Nomm2 = nomm2;
        }
    }
}
