using System.Text.RegularExpressions;

namespace ITRW211Projek2017
{
    public static class Validation
    {
        public static bool ProductName(string productName)
        {
            if (string.IsNullOrEmpty(productName))
                return false;
            return true;
        }

        public static bool Cost(string productCost)
        {
            Regex decimalRegex = new Regex(@"^(\d*\.?\,?)?\d+$");
            if (decimalRegex.IsMatch(productCost))
                return true;
            return false;
        }

        public static bool Quantity(string productQuantity)
        {
            Regex integerRegex = new Regex(@"[0-9]");
            if (integerRegex.IsMatch(productQuantity))
                return true;
            return false;
        }

        public static bool CategoryName(string category)
        {
            if (string.IsNullOrEmpty(category))
                return false;
            return true;
        }

        public static bool EmployeeName(string employee)
        {
            if (string.IsNullOrEmpty(employee))
                return false;
            return true;
        }

        public static bool EmployeeSurname(string surname)
        {
            if (string.IsNullOrEmpty(surname))
                return false;
            return true;
        }
    }
}
