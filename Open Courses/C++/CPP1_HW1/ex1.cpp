// ex1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <stdio.h>


using namespace std;

int main()
{
	long long number = 1000000000000000000;
	
	float fNumber = 3.141592141892;
	double dNumber = 3.141592141892;
	printf("%0.15f\n", fNumber);
	printf("%0.15f\n", dNumber);
    return 0;
}

