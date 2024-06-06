using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Formats.Tar;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write a C# Sharp program to compute the sum of the two numerical values.
            *   If the two values are the same, return triple their sum.
            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());

            // if(n1 == n2 ){
            //     Console.WriteLine((n1 + n2)*3);
            // }else{
            //     Console.WriteLine(n1 + n2);
            // }




            /* 2. Write a C# Sharp program to get the absolute difference between n and 51.
                If n is broader than 51 return triple the absolute difference.
            */

            // int n = Convert.ToInt32(Console.ReadLine());
            // if(n > 51){
            //     Console.WriteLine((n - 51)*3);
            // }else if(n <= 51){
            //     Console.WriteLine( 51 - n );
            // }



            /* 3. Write a C# Sharp program to check two given integers,
                and return true if one of them is 30 or if their sum is 30.

            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());

            // if( n1 + n2 == 30 || n1 == 30 || n2 == 30 ){
            //     Console.WriteLine(true);
            // }else {
            //     Console.WriteLine(false);
            // }





            /* 4. Write a C# Sharp program to check a given integer and return true 
            if it is within 10 of 100 or 200.
            */
            /* Soory i Dont Understand What do you mean with this Quastions */





            /* 5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. 
            If the string already begins with 'if', return it unchanged.
            */

            // string s = Console.ReadLine();

            // if(s[0] != 'i' ){
            //     Console.WriteLine("if " + s);
            // }else{
            //     Console.WriteLine( s);
            // }
            

            


            /* 6. Write a C# Sharp program to remove the character at a given position in the string. 
                The given position will be in the range 0..(string length -1) inclusive.
            */

            // string s = Console.ReadLine();
            // int n = Convert.ToInt32(Console.ReadLine());
            // string newS = "";

            // for(int i = 0 ; i< s.Length ; i++){
            //     if(n != i){
            //         newS += s[i];
            //     }
            // }
            // Console.WriteLine(newS);








            /* 7. Write a C# Sharp program to exchange the first and last 
                characters in a given string and return the new string.
            */
            // string s = Console.ReadLine();
            // if(s.Length == 1){
            //     Console.WriteLine(s);
            // }else{
            //     int charPos = s.IndexOf(s[s.Length - 1]);
            //     string s2 = s.Substring(charPos);
            //     string s3 = s.Substring(0 , charPos);
            //     Console.WriteLine(s2 + s3);
            // }



            /* 8. Write a C# Sharp program to create a string which is 4 copies 
            of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
            */
            // string s = Console.ReadLine();
            // if(s.Length ==1 ){
            //     Console.WriteLine(s);
            // }else{
            //     string newS = s[0].ToString() + s[1].ToString();
            //     Console.WriteLine(newS+newS+newS+newS);
            // }






            /* 9. Write a C# Sharp program to create a string with the last char added at 
                the front and back of a given string of length 1 or more.
            */
            // string s = Console.ReadLine();
            
            // int charPos = s.IndexOf(s[s.Length - 1]);
            // string chr = s.Substring(charPos);

            // Console.WriteLine(chr+s+chr);
            
            



            /* 10. Write a C# Sharp program to check if a given positive number 
                is a multiple of 3 or 7.
            */
            // int n = Convert.ToInt32(Console.ReadLine());
            
            // if(n%3 == 0 || n%7 == 0){
            //     Console.WriteLine(true);
            // }else{
            //     Console.WriteLine(false);
            // }







            /* 11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. 
                Return the string with the 3 characters added at both the front and back. 
                If the given string length is less than 3, use whatever characters are there.
            */

            // string s = Console.ReadLine();
            // if(s.Length <= 3){
            //     Console.WriteLine(s+s+s);
            // }else{
            //     int charPos = s.IndexOf(s[3]);
            //     string chr = s.Substring(0 , charPos);
            //     Console.WriteLine(chr+s+chr);
            // }





            /* 12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
            */
            // string s = Console.ReadLine();
            // string firstStr = s[0].ToString() + s[1].ToString();
            // if(firstStr ==  "C#"){
            //     Console.WriteLine(true);
            // }else{
            //     Console.WriteLine(false);
            // }




            /* 13. Write a C# Sharp program that checks whether one temperature 
                is less than 0 and another is greater than 100.
            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());    
            // if((n1 <= 0 || n1 >=100) &&  (n2 <= 0 || n2 >=100))  {
            //     Console.WriteLine(true);
            // }else{
            //     Console.WriteLine(false);
            // }




            /* 14. Write a C# Sharp program to check two given integers whether 
                either of them is in the range 100..200 inclusive.
            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());    
            // if(n1 >= 100 && n2 <=200)  {
            //     Console.WriteLine(true);
            // }else{
            //     Console.WriteLine(false);
            // }




            /* 15. Write a C# Sharp program to check whether three given integer values 
                are in the range 20..50 inclusive. Return true if 1 or more of 
                them are in the said range otherwise false.
            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());    
            // int n3 = Convert.ToInt32(Console.ReadLine());    
            // if((n1 >= 20 && n1 <=50) || (n2 >= 20 && n2 <=50) || (n3 >= 20 &&  n3 <=50))  {
            //     Console.WriteLine(true);
            // }else{
            //     Console.WriteLine(false);
            // }




            /* 16. Write a C# Sharp program to check whether two given integer values 
            are in the range 20..50 inclusive. Return true if 1 or other is in the range, 
            otherwise false.
            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());    
            // if((n1 >= 20 && n1 <=50 && n2 >= 20 && n2 <=50) || ((n1 < 20 || n1 >50) && (n2 < 20 || n2 >50)) )  {
            //     Console.WriteLine(false);
            // }else{
            //     Console.WriteLine(true);
            // }





            /* 17.  Write a C# Sharp program to check if a string 'yt' appears at index 1 in 
                a given string. If it appears return a string without 'yt' otherwise 
                return the original string.
            */
            // string s = Console.ReadLine();
            // string partToRemove = "yt";
            // if(s.Contains(partToRemove)){
            //     Console.WriteLine(s.Replace(partToRemove, string.Empty));
            // }else{
            //     Console.WriteLine(s);
            // }




            /* 18.  Write a C# Sharp program to check the largest number among three given integers.
            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // int n3 = Convert.ToInt32(Console.ReadLine());
            // if(n1 > n2 && n1 > n3){
            //     Console.WriteLine(n1);
            // }else if (n2 > n1 && n2 > n3){
            //     Console.WriteLine(n2);
            // }else if (n3 > n1 && n3 > n2){
            //     Console.WriteLine(n3);
            // }






            /* 19.  Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.
            */
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());

            // if((100 - n1) > (100 - n2) || (100 - n2) > (100 - n1)){
            //     Console.WriteLine(n1);
            // }else if(n1 == n2){
            //     Console.WriteLine(n1);
            // }
            

            
            


            /* 20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, 
                or they are both in the range 50..60 inclusive.
            */







            /* 21.  Write a C# Sharp program to find the largest value from two positive integer values in 
                the range 20..30 inclusive. Return 0 if neither is in that range.
            */
            // string n1 = Console.ReadLine();
            // string n2 = Console.ReadLine();
            // int nam1 = int.Parse(n1) % 2;
            // int nam2 = int.Parse(n2) % 2;
            // if( nam1 == 0 && nam2 != 0 || nam1 != 0 && nam2 ==0 ) {
            //     Console.WriteLine(0);
            // } else if(int.Parse(n1) > int.Parse(n2) ){
            //     Console.WriteLine(n1);
            // }else if(int.Parse(n1) < int.Parse(n2) ){
            //     Console.WriteLine(n2);
            // }







            /* 22.  Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
            */
            // string s = Console.ReadLine();
            // bool resulte = false;
            // for(int i = 0 ; i < s.Length ; i++){
            //     if(  (i == 1 || i == 2 || i == 3) && s[i] == 'z'){
            //         resulte = true;
            //     }else if(( (i == 0 || i > 4) && s[i] == 'z')  || s[i] != 'z'  ){
            //         resulte = false;
            //     }
            // }
            // Console.WriteLine(resulte);






            /* 23.  Write a C# Sharp program to check if two given non-negative 
                integers have the same last digit.
            */
            // string st1 = Console.ReadLine();
            // string st2 = Console.ReadLine();
            // bool resulte = false;
            // if(st1.Length == st2.Length){
            //     resulte= false;
            // }else{
            //     for(int i =0 ; i < st1.Length ; i++){
            //         for(int j=0; j < st2.Length ; j++){
            //             if(st2[i] == st1[++i]){
            //                 resulte = true;
            //             }else{
            //                 resulte = false;
            //             }
            //         }
            //     }
            // }
            // Console.WriteLine(resulte);









            /* 24.  Write a C# Sharp program to convert the last 3 characters of a given string to uppercase.
                If the length of the string is less than 3, then uppercase all the characters.
            */
            // string s = Console.ReadLine();
            // if(s.Length <= 3){
            //     Console.WriteLine(s.ToUpper());
            // }else{
            //     int charPos = s.IndexOf(s[s.Length - 3]);
            //     string secondS = s.Substring(charPos);
            //     string firstS = s.Substring(0 , charPos) ;
            //     Console.WriteLine(firstS + secondS.ToUpper());
            // }




            /* 25.  Write a C# Sharp program to create a string 
                which is n (non-negative integer) copies of a given string.
            */
            // string s = Console.ReadLine();
            // string n = Console.ReadLine();
            // for(int i =0 ; i < int.Parse(n) ; i++){
            //     Console.Write(s);
            // }
            








            /* 
            ---------          The Second Collection of Problems                 --------
                1.  Write a C# Sharp program to accept two integers and
                check whether they are equal or not.
            */
            // Console.Write("input 1st number:");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input 1st number:");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // if(n1 == n2){
            //     Console.WriteLine($"{n1} and {n2} are equal");
            // }else{
            //     Console.WriteLine($"{n1} and {n2} are Not equal");
            // }




            /* 
                2.  Write a C# Sharp program to check whether a given number is even or odd.
            */
            // Console.Write("input number:");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            
            // if(n1%2 == 0 ){
            //     Console.WriteLine($"{n1} is an even integer");
            // }else{
            //     Console.WriteLine($"{n1} is an odd integer");
            // }


            /* 
                3.  Write a C# Sharp program to check whether a given number is positive or negative.
            */
            // Console.Write("input number:");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            
            // if(n1 > 0 ){
            //     Console.WriteLine($"{n1} is a positive number");
            // }else if(n1 == 0){
            //     Console.WriteLine($"{n1}  is zero");
            // }else if(n1 < 0){
            //     Console.WriteLine($"{n1}  is a negative number");
            // }





            /* 
                4.  Write a C# Sharp program to find out whether a given year is a leap year or not.
            */
            // Console.Write("input year:");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // if(n1 %4 ==  0  ){
            //     Console.WriteLine($"{n1} is a leap year");
            // }
            // else {
            //     Console.WriteLine($"{n1} is not a leap year");
            // }






            /* 
                5.  Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
            */
            // Console.Write("input year:");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // if(n1 >= 18  ){
            //     Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            // }
            // else {
            //     Console.WriteLine("Sorry! You are Not eligible for casting your vote.");
            // }








            /* 
                6.  Write a C# Sharp program to read the value of an integer m and 
                display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
            */
            // Console.Write("input year:");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // if(n1 > 0  ){
            //     Console.WriteLine("1");
            // }
            // else if(n1 < 0) {
            //     Console.WriteLine("-1");
            // }else if(n1 == 0) {
            //     Console.WriteLine("0");
            // }




            /* 
                7.  Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
            */
            // Console.Write("input the size in centemetrize :");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // if(n1 < 140  ){
            //     Console.WriteLine("The person is Dwarf.");
            // }
            // else if(n1 <= 160 ) {
            //     Console.WriteLine("The person is short.");
            // }else if(n1 <= 180) {
            //     Console.WriteLine("The person is normal.");
            // }else if(n1 > 180) {
            //     Console.WriteLine("The person is tall.");
            // }



            /* 
                8. Write a C# Sharp program to find the largest of three numbers.
            */
            // Console.Write("input the first :");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input the second :");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input the third :");
            // int n3 = Convert.ToInt32(Console.ReadLine());
            // if(n1 > n2 && n1 > n3){
            //     Console.WriteLine("The 1st Number is the greatest among three");
            // }else if (n2 > n1 && n2 > n3){
            //     Console.WriteLine("The 2nd Number is the greatest among three");
            // }else if (n3 > n1 && n3 > n2){
            //     Console.WriteLine("The 3rd Number is the greatest among three");
            // }




            /* 
                9. Write a C# Sharp program to accept a coordinate point in an XY coordinate 
                system and determine in which quadrant the coordinate point lies.
            */
            // Console.Write("input the first :");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input the second :");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            
            // if(n1>0  && n2 > 0 ){
            //     Console.WriteLine($"The coordinate point ({n1},{n2}) lies in the First quadrant.");
            // }else if(n1>0  && n2 < 0 ){
            //     Console.WriteLine($"The coordinate point ({n1},{n2}) lies in the Second quadrant.");
            // }else if(n1 < 0  && n2 < 0 ){
            //     Console.WriteLine($"The coordinate point ({n1},{n2}) lies in the Third quadrant.");
            // }else if(n1 < 0  && n2 > 0 ){
            //     Console.WriteLine($"The coordinate point ({n1},{n2}) lies in the Forth quadrant.");
            // }

            


            /* 
                10. Write a C# Sharp program to determine the eligibility for admission to a professional 
                course based on the following criteria:
                    Marks in Maths >= 65
                    Marks in Phy >= 55
                    Marks in Chem >= 50
                    Total in all three subject >= 180
                    or
                    Total in Math and Subjects >= 140
            */
            // Console.Write("input the Math :");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input the Phy :");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input the Chem :");
            // int n3 = Convert.ToInt32(Console.ReadLine());
            
            // if(n1>=65  && n2 >= 55 && n3 >= 50 ){
            //     Console.WriteLine("The candidate is eligible for admission.");
            // }else {
            //     Console.WriteLine("The candidate is ineligible for admission.");
            // }





            /* 
                11. Write a C# Sharp program to accept a coordinate point in an XY coordinate 
                system and determine in which quadrant the coordinate point lies.
            */
           

            // Console.Write("input the a :");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input the b :");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.Write("input the c :");
            // int c = Convert.ToInt32(Console.ReadLine());

            // double d = (b * b) - (4 * a * c);  
            // double x1 , x2;

            // if (d == 0) {
            //     x1 = -b / (2.0 * a);  
            //     x2 = x1;  
            //     Console.Write( "(" + x1 +","+ x2 +")");  
            // }else if (d > 0){ 
            //     x1 = (-b + Math.Sqrt(d)) / (2 * a);  
            //     x2 = (-b - Math.Sqrt(d)) / (2 * a);  
            //     Console.Write( "(" + x1 +","+ x2 +")");
            // }else {
            //     Console.Write("Root are imaginary;\nNo Solution. "); 
            // }




            /* 
                12. Write a C# Sharp program to read roll no, name and marks of three 
                subjects and calculate the total, percentage and division.
            */

            // Console.Write("Input the Roll Number of the student :");
            // int roolNum = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Input the Name of the Student :");
            // string name = Console.ReadLine();
            // Console.Write("Input the marks of Physics, Chemistry and Computer Application :");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // int num3 = Convert.ToInt32(Console.ReadLine());

            // double prsentage = 0;
            // if((num1+num2+num3)/3 >= 90 ){
            //     prsentage = 90.00;
            // }else if((num1+num2+num3)/3 >= 80){
            //     prsentage = 80.00;
            // }else if((num1+num2+num3)/3 >= 70){
            //     prsentage = 70.00;
            // }else if((num1+num2+num3)/3 >= 60){
            //     prsentage = 60.00;
            // }else if((num1+num2+num3)/3 >= 50){
            //     prsentage = 50.00;
            // }

            // Console.WriteLine("Roll No : " + roolNum);
            // Console.WriteLine("Name of Student : " + name);
            // Console.WriteLine("Marks in Physics :" + num1);
            // Console.WriteLine("Marks in Chemistry :" + num2);
            // Console.WriteLine("Marks in Computer Application :" + num3);
            // Console.WriteLine("Percentage =" + prsentage );
            // Console.WriteLine("Total Marks = " + (num1+num2+num3));
            // Console.WriteLine("Division =" + (num1+num2+num3)/3 );


            /* 
                13.  Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
                    Temp < 0 then Freezing weather
                    Temp 0-10 then Very Cold weather
                    Temp 10-20 then Cold weather
                    Temp 20-30 then Normal in Temp
                    Temp 30-40 then Its Hot
                    Temp >=40 then Its Very Hot
            */



            




            /* 
            ---------          The Third Collection of Problems                 --------
            */
            // 10. Write a C# Sharp program to find the maximum number of characters in a string.

                // string s = Console.ReadLine();
                // List<char> charecter = new List<char>() ;
                // for(int i = 0 ; i < s.Length ; i++ ){
                //     charecter.Add(s[i]);
                // }
                // foreach( char singleChar in charecter.Order()){
                //     Console.WriteLine(singleChar);
                // }
                    


            // 12. Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.

                // int n = Convert.ToInt32(Console.ReadLine());
                // // string s1 = Console.ReadLine();
                // List<string> strings = new List<string>() ;

                // for(int i=0 ; i < n ; i++){
                //     strings.Add(Console.ReadLine());
                // }
                // foreach(var singleString in strings.Order()){
                //     Console.WriteLine(singleString);
                // }


                // 13. Write a program in C# Sharp to extract a substring from a given string without using the library function.


                // string s = Console.ReadLine();
                // int position = Convert.ToInt32(Console.ReadLine());
                // int length = Convert.ToInt32(Console.ReadLine());

                // for(int i = position ; i < position+length ; i++){
                //     Console.Write(s[i]);
                // }
                

                // 14. Write a C# Sharp program to check whether a given substring is present in the given string.

                // string s = Console.ReadLine();
                // string s2 = Console.ReadLine();
                // if(s.CompareTo(s2) == 1){
                //     Console.WriteLine("The substring exists in the string");
                // }else{
                //     Console.WriteLine("The substring is not exists in the string");
                // }




                //15. Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
                // string s = Console.ReadLine();
                // char[] charArray = s.ToCharArray();

                // for(int i = 0 ; i < s.Length ; i++){
                //     if (char.IsUpper(s[i]))
                //     {
                //         charArray[i] = char.ToLower(charArray[i]);
                //     }else if(char.IsLower(s[i])){
                //         charArray[i] = char.ToUpper(charArray[i]);
                //     }
                // }
                // Console.WriteLine(charArray);
        }
    }
}