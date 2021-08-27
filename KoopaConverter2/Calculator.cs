using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace KoopaConverter2
{
    public class Calculator
    {
        public static string rowProp = "";
        public static string staticInputUnit = "";
        public static List<rowInTable> rowsList = table.populateList();
        public static rowInTable FindRow(double? hardness, string inputUnit)
        {
            rowInTable temp = null;
            
            switch (inputUnit)
            {
                case "HLD":
                
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HLD == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HV 136° 10":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HV136 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HB 10 3000":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HB10 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HRA 120° 60":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HRA120 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HRB 1/16 100":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HRB1o16 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HRC 120° 150":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HRC120 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HRD 120° 100":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HRD120 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HRF 1/16 60":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HRF1o16 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HR15N 120° 15":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HR15N == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HR30N 120° 45":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HR30N == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HR45N 120° 45":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HR45N == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HR15T 1/16 15":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HR15T == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HR30T 1/16 30":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HR30T == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HR45T 1/16 45":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HR45T == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "HSc":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].HSc == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
                case "Mpa":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        if (rowsList[i].Nomm2 == hardness)
                        {
                            temp = rowsList[i];
                        }
                    }
                    break;
            }

            return temp;

        }

        public static rowInTable GetUnassignedValue(double hardness, string inputUnit)  
        {
            List<double?> hardnessList = new List<double?>();
            

            switch (inputUnit)
            {
                case "HLD":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HLD);
                    }
                    rowProp = "HLD";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HV 136° 10":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HV136);
                    }
                    rowProp = "HV136";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HB 10 3000":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HB10);
                    }
                    rowProp = "HB10";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HRA 120° 60":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HRA120);
                    }
                    rowProp = "HRA120";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HRB 1/16 100":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HRB1o16);
                    }
                    rowProp = "HRB1o16";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HRC 120° 150":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HRC120);
                    }
                    rowProp = "HRC120";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HRD 120° 100":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HRD120);
                    }
                    rowProp = "HRD120";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HRF 1/16 60":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HRF1o16);
                    }
                    rowProp = "HRF1o16";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HR15N 120° 15":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HR15N);
                    }
                    rowProp = "HR15N";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HR30N 120° 45":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HR30N);
                    }
                    rowProp = "HR30N";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HR45N 120° 45":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HR45N);
                    }
                    rowProp = "HR45N";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HR15T 1/16 15":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HR15T);
                    }
                    rowProp = "HR15T";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HR30T 1/16 30":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HR30T);
                    }
                    rowProp = "HR30T";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HR45T 1/16 45":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HR45T);
                    }
                    rowProp = "HR45T";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "HSc":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].HSc);
                    }
                    rowProp = "HSc";
                    Calculator.staticInputUnit = inputUnit;
                    break;
                case "Mpa":
                    for (int i = 0; i < rowsList.Count; i++)
                    {
                        hardnessList.Add(rowsList[i].Nomm2);
                    }
                    rowProp = "Nomm2";
                    Calculator.staticInputUnit = inputUnit;
                    break;
            }

            rowInTable midRow = FindHardness(hardnessList, hardness);
            return midRow;
        }

        private static rowInTable FindHardness(List<double?> hardnessList, double hardness)
        {
            double? higher = 0;
            double? lower = 0;
            List<double?> hardnessValues = new List<double?>();
                for (int i = 0; i < hardnessList.Count; i++)
                {
                    if (hardnessList[i] != null)
                    {
                        hardnessValues.Add(hardnessList[i]);
                    }
                }
                hardnessValues.Sort();
                if (hardnessValues.Count != 0 && hardness >= hardnessValues[0] && hardness <= hardnessValues[^1])
                {
                    for (int i = 0; i < hardnessValues.Count; i++)
                    {
                        double? difference = hardnessValues[i] - hardness;
                        if (difference > 0)
                        {
                            higher = hardnessValues[i];
                            lower = hardnessValues[i - 1];
                            break;
                        }
                    }
                    rowInTable higherRow = FindRow(higher, staticInputUnit);
                    rowInTable lowerRow = FindRow(lower, staticInputUnit);

                    rowInTable midRow = GetMidRow(higherRow, lowerRow, hardness, rowProp);
                    return midRow;
                }
                else
                {
                    rowInTable empty = null;
                    return empty;
                }
                
            
            
           

        }
        public static rowInTable GetMidRow(rowInTable higher, rowInTable lower, double hardness, string inputUnit)
        {
            try
            {
                if (higher != null)
                {
                    double?[] newPropArr = new double?[higher.propertyArr.Length];

                    double? higherValue = (double?)higher.GetType().GetProperty(inputUnit).GetValue(higher);
                    double? lowerValue = (double?)lower.GetType().GetProperty(inputUnit).GetValue(lower);

                    for (int i = 0; i < higher.propertyArr.Length; i++)
                    {
                        double?[] xValues = { higherValue, higher.propertyArr[i] };
                        double?[] yValues = { lowerValue, lower.propertyArr[i] };
                        newPropArr[i] = LinearApprox(xValues, yValues, hardness);
                    }

                    return new rowInTable(newPropArr[0], newPropArr[1], newPropArr[2], newPropArr[3], newPropArr[4], newPropArr[5], newPropArr[6], newPropArr[7], newPropArr[8], newPropArr[9], newPropArr[10], newPropArr[11], newPropArr[12], newPropArr[13], newPropArr[14], newPropArr[15]);
                }
                else
                {
                    rowInTable empty = null;
                    return empty;
                }

            }
            catch (NullReferenceException)
            {
                rowInTable empty = null;
                return empty;
            }


        }
        public static double? LinearApprox(double?[] a, double?[] b, double number)
        {
            
            double? x = null;
            if (a[1] == a[0] && b[1] == b[0])
            {
                return number;
            }
            else
            {
                if(a[1] != null && a[0] != null && b[1] != null && b[0] != null)
                {
                    double? slope = (a[1] - b[1]) / (a[0] - b[0]);
                    x = Math.Abs((double)((slope * (number - b[0])) + b[1]));
                }

            }
            return x;

        }


    }
}
