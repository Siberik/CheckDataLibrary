using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckDataLibrary
{
    public class VinCheck
    {
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
            if (vin == string.Empty || vin.Length != 17 || String.IsNullOrWhiteSpace(vin) || 1980 > year || year>Convert.ToInt32(DateTime.Now.Year))
            {
                return false;
            }
            if (!vin.All(char.IsLetterOrDigit)|| vin.ToUpper().Contains('I') || vin.ToUpper().Contains('O') || vin.ToUpper().Contains('Q'))
            {
                return false;
            }
            var vinSplit = vin.Split(' ').ToArray();
            for (int i = 0; i > vinSplit.Length; i++)
            {
                

            }
            return true;
        }
    }
}
