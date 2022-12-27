using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckDataLibrary

{

    public class VinCheck
    {
        public Dictionary<int,string> yearsCode = new Dictionary<int, string>()
        {
        
        };
        int key = 0;
        int[] digitVIN = new int[17]; 
        /// <summary>
        /// Проверка на правильность введённого VIN и даты
        /// </summary>
        /// <param name="vin">
        /// сам VIN автомобиля
        /// </param>
        /// <param name="year">
        /// Год производства
        /// </param>
        /// <returns>
        /// Возвращает истину или ложь
        /// </returns>
        public bool CheckVin(string vin, int year)
        {


            string code = "ABCDEFGHJKLMPRSTVWXY123456789";
            int yearKey = year - 1980;
            while(yearKey>=30)
            {
                yearKey = yearKey - 30;
            }
            
            if (vin == string.Empty || vin.Length != 17 || String.IsNullOrWhiteSpace(vin) || 1980 > year || year>Convert.ToInt32(DateTime.Now.Year))
            {
                return false;
            }
            if (!vin.All(char.IsLetterOrDigit)|| vin.ToUpper().Contains('I') || vin.ToUpper().Contains('O') || vin.ToUpper().Contains('Q'))
            {
                return false;
            }
            if (vin[10] != code[yearKey])
            {
                return false;
            }
            var vinSplit = vin.Split(' ').ToArray();
            int count = 0;
            int[] vesVIN =  { 8,7,6,5,4,3,2,10,0,9,8,7,6,5,4,3,2 };
            for (int i = 0; i > vinSplit.Length; i++)
            {

                switch (vinSplit[i])
                {
                    
                    case "A":
                        vinSplit[i] = "1";
                        break;
                    case "B":
                        vinSplit[i] = "2";
                        break;
                    case "C":
                        vinSplit[i] = "3";
                        break;
                    case "D":
                        vinSplit[i] = "4";
                        break;
                    case "E":
                        vinSplit[i] = "5";
                        break;
                    case "F":
                        vinSplit[i] = "6";
                        break;

                    case "G":
                        vinSplit[i] = "7";
                        break;
                    case "H":
                        vinSplit[i] = "8";
                        break;
                    case "J":
                        vinSplit[i] = "1";
                        break;
                    case "K":
                        vinSplit[i] = "2";
                        break;
                    case "L":
                        vinSplit[i] = "3";
                        break;
                    case "M":
                        vinSplit[i] = "4";
                        break;
                    case "N":
                        vinSplit[i] = "5";
                        break;
                    case "P":
                        vinSplit[i] = "7";
                        break;
                    case "R":
                        vinSplit[i] = "9";
                        break;
                    case "S":
                        vinSplit[i] = "2";
                        break;
                    case "T":
                        vinSplit[i] = "3";
                        break;
                    case "U":
                        vinSplit[i] = "4";
                        break;
                    case "V":
                        vinSplit[i] = "5";
                        break;
                    case "W":
                        vinSplit[i] = "6";
                        break;
                    case "X":
                        vinSplit[i] = "7";
                        break;
                    case "Y":
                        vinSplit[i] = "8";
                        break;
                    case "Z":
                        vinSplit[i] = "9";
                        break;
                    default:
                        break;
                }

                digitVIN[i] = Convert.ToInt32(vinSplit[i]);
              
                count += digitVIN[i] * vesVIN[i];
                
            }
            Console.WriteLine(count);
          count=  count-((count / 11)*11);
            Console.WriteLine(count);
            if ((count != digitVIN[8]))
            {
                return false;
            }
             else if ((count == 10))
            {
                if (vin[8] != 'X')
                {
                    return false;
                }
                
            }
             
            return true;
        }
    }
}
