using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";
            string test = "G";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';
            
            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            decimal entryPrice = 1m;
            decimal exitPrice = 9.5m;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL
            //bool chartoboolImplicit = place;                          //IMPLICIT
            //bool chartoboolExplicit = (bool)place;               //EXPLICIT
            //bool charTobool = Convert.ToBoolean(place);            //System.InvalidCastException Недопустимое приведение 


            //1.3 CHAR to DECIMAL
            decimal charTodecimalImplicit = place; //51
            //decimal chaTodecimalExplicit = (decimal)flatNumber;               //EXPLICIT: NOT COMPILING
            decimal charTodecimalConvert = Convert.ToDecimal(flatNumber);   //CONVERT: "34"
            
            //1.4 CHAR to INT
            int intTochar = sex; //1052
            int intTochar1 = hasFingerPrints;    // char '0' >>  int 48

            //2. STRING CONVERSION
            //2.1 STRING to CHAR
            //char stringTochar = Convert.ToChar(name);       //System.FormatException: 'Длина строки должна составлять один знак.'
            char stringTochar = Convert.ToChar(test);       //G
            // char stringTocharImlicit = hasPhoto;                     //IMPLICIT: NOT COMPILING
            //char stringTocharExplicit = (char)flatNumber;               //EXPLICIT: NOT COMPILING

            //2.2 STRING to BOOL
            //bool stringToboolImlicit = name;                     //IMPLICIT: NOT COMPILING
            //bool stringToboolExplicit = (Boolean)hasPhoto;               //EXPLICIT: NOT COMPILING
            bool stringToboolConvert = Convert.ToBoolean(hasPhoto);  //true

            //2.3 STRING to DECIMAL
            //decimal stringTodecimalImlicit = name;                     //IMPLICIT: NOT COMPILING
            //decimal stringTodecimalExplicit = (decimal)flatNumber;               //EXPLICIT: NOT COMPILING
            decimal stringTodecimalConvert = Convert.ToDecimal(flatNumber); //34

            //2.4 STRING to INT
            //int stringTointImlicit = flatNumber;                     //IMPLICIT: NOT COMPILING
            //int stringTointExplicit = (int)flatNumber;               //EXPLICIT: NOT COMPILING
            int stringTointConvert = Convert.ToInt32(flatNumber); //34

            //3. BOOL CONVERSION
            //3.1 BOOL to CHAR
            //char boolTocharImlicit = hasFree2Pages;                     //IMPLICIT: NOT COMPILING
            //char boolTochar1Explicit = (char)hasFree2Pages;               //EXPLICIT: NOT COMPILING
            //char boolTocharConvert = Convert.ToChar(hasFree2Pages); //System.InvalidCastException: 'Недопустимое приведение "Boolean" к "Char"

            //3.2 BOOL to STRING
            //string boolTostringImlicit = hasFree2Pages;                     //IMPLICIT: NOT COMPILING
            //string boolTostringExplicit = (string)hasFree2Pages;               //EXPLICIT: NOT COMPILING
            string boolTostringConvert = Convert.ToString(hasFree2Pages);   //bool false > string "False"
            Console.WriteLine(boolTostringConvert);

            //3.3 BOOL to DECIMAL
            //decimal boolTodecimalImlicit = hasFree2Pages;                     //IMPLICIT: NOT COMPILING
            //decimal boolTodecimalExplicit = (decimal)hasFree2Pages;               //EXPLICIT: NOT COMPILING
            decimal boolTodecimalConvert = Convert.ToDecimal(hasFree2Pages);  //bool false > decimal 0

            //3.4 BOOL to INT
            //int boolTointImlicit = hasFree2Pages;                     //IMPLICIT: NOT COMPILING
            //int boolTointExplicit = (int)hasFree2Pages;               //EXPLICIT: NOT COMPILING
            int boolTointConvert = Convert.ToInt32(hasFree2Pages);  //bool false > int 0

            //4. DECIMAL CONVERSION
            //4.1 DECIMAL to CHAR
            //char decimalTocharImlicit = entryPrice;                     //IMPLICIT: NOT COMPILING
            char decimalTocharExplicit = (char)entryPrice;   //  decimal 1 > char '\u0001'
            //char decimalTocharConvert = Convert.ToChar(exitPrice); //System.InvalidCastException: 'Недопустимое приведение "Decimal" к "Char".'


            //4.2 DECIMAL to BOOL
            //bool decimalToboolImlicit = exitPrice;                     //IMPLICIT: NOT COMPILING
            //bool decimalToboolExplicit = (bool)entryPrice;               //EXPLICIT: NOT COMPILING
            bool decimalToboolConvert = Convert.ToBoolean(entryPrice);  //decimal 1 > bool true

            //4.3 DECIMAL to STRING
            //string decimaltostringImlicit = exitPrice;                     //IMPLICIT: NOT COMPILING
            //string decimaltostringExplicit = (string)entryPrice;               //EXPLICIT: NOT COMPILING
            string decimaltostringConvert = Convert.ToString(exitPrice);  //"9.5"

            //4.4 DECIMAL to INT
            // int decimalTointImlicit = entryPrice;                     //IMPLICIT: NOT COMPILING
            int decimalTointExplicit = (int)entryPrice;   //1
            int decimalToint2 = Convert.ToInt32(exitPrice);   //decimal 9.5 > int 10

            //5. INT CONVERSION  
            //5.1 INT to CHAR

            //char intTocharImlicit = birthYear;                     //IMPLICIT: NOT COMPILING
            char intTocharExplicit = (char)birthYear;   // int 2000  > char '\0'
            char intTocharConvert = Convert.ToChar(birthYear);  // int 2000  > char '\0'

            //5.2 INT to BOOL
            //bool intToboolImlicit = birthYear;                     //IMPLICIT: NOT COMPILING
            //bool intToboolExplicit = (bool)birthYear;               //EXPLICIT: NOT COMPILING
            bool intToboolConvert = Convert.ToBoolean(birthYear);    //int 2000 > bool true

            //5.3 INT to DECIMAL
            decimal intTodecimalImlicit = birthYear;  //2000
            decimal intTodecimalExplicit = (decimal)birthYear;   //2000
            decimal intTodecimalConvert = Convert.ToDecimal(birthYear);  //2000

            //5.4 INT to STRING
            //string intTostringImlicit = birthYear;                     //IMPLICIT: NOT COMPILING
            //string intTostringExplicit = (string)birthYear;               //EXPLICIT: NOT COMPILING
            string intTostringConvert = Convert.ToString(birthYear);  //"2000"
            Console.ReadKey();
        }
    }
}
