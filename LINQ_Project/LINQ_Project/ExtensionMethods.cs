namespace LINQ_Project
{
    public static class ExtensionMethods
    {
        //2.
        public static string BiggerNumber(this int a, int b)
        {
            if (a > b) return $"Number {a} is bigger";
            else if (a < b) return $"Number {b} is bigger";
            else return "Numbers are equal";
        }
        //3.
        public static string IsEvenNumber(this int a)
        {
            if (a % 2 == 0) return $"Number {a} is even";
            else return $"Number {a} is not even";
        }
        //4.
        public static string FirstLetterToUpper(this string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1);
        }
    }
}
//EXTENSION METHODS
//1. Napravete extension method sto ke se vika SedcAverage -> na List<int> (ili na IEnumerable<int>) da vraka average
//2. Napravi Extension method sto ke vrakja rezultat od sporedba na dva broja - dali X e pogolem od Y
//3. Napravi Extension method sto ke vrakja dali brojot e paren
//4. Napravi Extension method sto ke go vrakja stringot so prva golema bukva
//5. Nova klasa StringExtensions -> Metod sto ke se vika - FirstLetterToUpper
//Hint:
//Najdete ja prvata bukva
//Najdete go ostatokot
//Ispecatete go rezultatot (prva bukva->Golema) + (ostatok)