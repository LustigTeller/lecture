﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 2;
int b1 = 4;
int c1 = 33;
int a2 = -2;
int b2 = -93;
int c2 = 20;
int a3 = 111;
int b3 = 74;
int c3 = -24;


int res = Max (Max(a1,b1,c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(res);
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
