# CodeWars-Last-Digit-of-a-Large-Number

https://www.codewars.com/kata/5511b2f550906349a70004e1/csharp

Define a function that takes in two non-negative integers a and b and returns the last decimal digit of a<sup>b</sup>. Note that a and b may be very large!

For example, the last decimal digit of 9<sup>7</sup> is 9, since 9<sup>7</sup>=4782969. 
The last decimal digit of (2<sup>200</sup>)<sup>2<sup>300</sup></sup>, which has over 10<sup>92</sup> decimal digits, is 6. Also, please take 0<sup>0</sup> to be 1.

You may assume that the input will always be valid.

Examples

GetLastDigit(4, 1)            // returns 4

GetLastDigit(4, 2)            // returns 6

GetLastDigit(9, 7)            // returns 9    

GetLastDigit(10, 10000000000) // returns 0
