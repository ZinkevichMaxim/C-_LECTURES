int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

maxi = a1;

if (b1 > maxi) maxi = b1;
if (c1 > maxi) maxi = c1;
if (a2 > maxi) maxi = a2;
if (b2 > maxi) maxi = b2;
if (c2 > maxi) maxi = c2;
if (a3 > maxi) maxi = a3;
if (b3 > maxi) maxi = b3;
if (c3 > maxi) maxi = c3;

Console.WriteLine(maxi);
