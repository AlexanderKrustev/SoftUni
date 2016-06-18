// Problem02.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <iostream>
#include <math.h>

using namespace std;


void PrintGreetings(string name) {
	cout << "Hello " << name << " welcome" << endl;
}

bool CheckAge(int age) {
	if (age >= 18) {
		return true;
	}
	return false;
}

void AnalyzeAge(int age) {
	if (CheckAge(age)) {
		cout << "Your age " << age << " is enough for beer" << endl;
	}
	else {
		cout << "Your age " << age << " is NOT enough for beer" << endl;
		cout << "Come back after " << 18 - age << " year/s" << endl;
	}
}

int main()
{
	string answer;
	string name;
	int age;
	cout << "Please enter your name:" << endl;
	getline(cin, name);
    PrintGreetings(name);
	cout << "Please enter your age:" << endl;
	cin >> age;
	AnalyzeAge(age);
	cout << "Do you want to help you solving quadratic equation? Please type Yes or No" << endl;
	cin >> answer;
	if (answer == "Yes") {
		double a = 0;
		double b = 0;
		double c = 0;
		double D = 0;
		double x1 = 0;
	    double x2 = 0;
		cout << "You are gives quadratic equation a*x^2+b*x+c=0" << endl;
		cout << " a= ";
		cin >> a;
		cout << " b= ";
		cin >> b;
		cout << " c= ";
		cin >> c;
		D = (b*b) - (4 * a*c);
		if (D > 0) {
			x1 = (-b + sqrt(D)) / (2 * a);
			x2 = (-b - sqrt(D)) / (2 * a);
			cout << "D = " << D << " >0, =>there are two different x- x1 = " << x1 << " and x2=" << x2 << endl;
		}
		else if (D == 0) {
			x1 = -b / (2 * a);
			cout << "D = " << D << " =0, => x1=x2. Answer is  " << x1 << endl;
		}
		else {
			cout << "Sorry i cannt calculate x when you D is less than zero. My programmer was dummy and couldn`t code it.";
		}
	}
	else {
		cout << "See you later";
	}
    return 0;
}



