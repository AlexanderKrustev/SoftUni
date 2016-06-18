// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <iostream>
using namespace std;
class Building
{
private:
	int numberOfFloors;
	int numberOfSeats;
	int numberOfEmployees;
	int numberOfOffices;
	string nameOfCompany;

public:
	Building(int floors, int seats, int employees, std::string name, int offices)
	{
		setFloors(floors);
		setSeats(seats);
		setEmployees(employees);
		setName(name);
		setOffices(offices);
	}
	~Building() {};
	int getFloors();
	int getEmployees();
	int getSeats();
	string getName();
	int getOffices();
	void setFloors(int floors);
	void setEmployees(int employees);
	void setSeats(int seats);
	void setName(string name);
	void setOffices(int offices);

};

int Building::getFloors()
{
	return numberOfFloors;
}
int Building::getEmployees()
{
	return numberOfEmployees;
}
int Building::getSeats()
{
	return numberOfSeats;
}
string Building::getName()
{
	return nameOfCompany;
}
int Building::getOffices()
{
	return  numberOfOffices;
}

void Building::setEmployees(int employees)
{
	numberOfEmployees = employees;
}
void Building::setFloors(int floors)
{
	numberOfFloors = floors;
}
void Building::setSeats(int seats)
{
	numberOfSeats = seats;
}
void Building::setName(string name)
{
	nameOfCompany = name;
}

void Building::setOffices(int offices)
{
	numberOfOffices = offices;
}

string getMostEmployees(Building arr[], int size)
{
	int mostEmp = 0;
	string name = "";
	for (int i = 0; i < size; i++)
	{
		if (mostEmp < arr[i].getEmployees())
		{
			mostEmp = arr[i].getEmployees();
			name = arr[i].getName();
		}
	}
		return name;
}

string getMostFreeSeats(Building arr[], int size)
{
	int mostFree= 0;
	string name = "";
	for (int i = 0; i < size; i++)
	{
		if (mostFree < arr[i].getSeats())
		{
			mostFree = arr[i].getSeats();
			name = arr[i].getName();
		}
	}
	return name;
}

string getHCoeficient(Building arr[], int size)
{
	double coef = 0;
	string name = "";
	for (int i = 0; i < size; i++)
	{
		double x = arr[i].getSeats() + arr[i].getEmployees();
		double tempCoef = arr[i].getEmployees() / x;
		if (coef < tempCoef)
		{
			coef = tempCoef;
			name = arr[i].getName();
		}
	}
	return name;
}

string getMostPeoplePerFloor(Building arr[], int size)
{
	double peoplePerFloor = 0;
	string name = "";
	for (int i = 0; i < size; i++)
	{
		
		double tempCoef = arr[i].getEmployees() /arr[i].getFloors();
		if (peoplePerFloor < tempCoef)
		{
			peoplePerFloor = tempCoef;
			name = arr[i].getName();
		}
	}
	return name;
}

string getLeastPeoplePerFloor(Building arr[], int size)
{
	double peoplePerFloor =10000000000000.0;
	string name = "";
	double tempCoef = 0;
	for (int i = 0; i<size; i++)
	{

		 tempCoef = arr[i].getEmployees() / arr[i].getFloors();
		if (peoplePerFloor > tempCoef)
		{
			peoplePerFloor = tempCoef;
			name = arr[i].getName();
		}
	}
	return name;
}

string getMostOfficesPerFl(Building arr[], int size)
{
	double offices = 0;
	string name = "";
	double tempCoef = 0;
	for (int i = 0; i < size; i++)
	{

		tempCoef = arr[i].getOffices() / arr[i].getFloors();
		if (offices < tempCoef)
		{
			offices = tempCoef;
			name = arr[i].getName();
		}
	}
	return name;
}

string getLeastOfficesPerFl(Building arr[], int size)
{
	double offices = 10000000000000.0;
	string name = "";
	double tempCoef = 0;
	for (int i = 0; i<size; i++)
	{

		tempCoef = arr[i].getOffices() / arr[i].getFloors();
		if (offices > tempCoef)
		{
			offices = tempCoef;
			name = arr[i].getName();
		}
	}
	return name;
}

string getMostPeoplePeroffice(Building arr[], int size)
{
	double offices = 0;
	string name = "";
	double tempCoef = 0;
	for (int i = 0; i < size; i++)
	{

		tempCoef = arr[i].getEmployees() / arr[i].getOffices();
		if (offices < tempCoef)
		{
			offices = tempCoef;
			name = arr[i].getName();
		}
	}
	return name;
}

string getLeastPeoplePeroffice(Building arr[], int size)
{
	double offices = 10000000000000.0;
	string name = "";
	double tempCoef = 0;
	for (int i = 0; i<size; i++)
	{

		tempCoef = arr[i].getEmployees() / arr[i].getOffices();
		if (offices > tempCoef)
		{
			offices = tempCoef;
			name = arr[i].getName();
		}
	}
	return name;
}

int main()
{
	
	Building b1 = Building(6, 196, 600, "XYZ Industries", 127);
	Building b2 = Building(8, 85, 822, "Rapid Development Crew", 210);
	Building b3 = Building(11, 60, 200, "SoftUni", 106);
	Building businessPark[] = { b1, b2, b3 };
	int sizeOfTheArr = sizeof(businessPark) / sizeof(businessPark[0]);
	cout << "The building with most employees is " << getMostEmployees(businessPark, sizeOfTheArr) << endl;
	cout << "The building with most free seats is " << getMostFreeSeats(businessPark, sizeOfTheArr) << endl;
	cout << "The building with Highest coefficient employees/(employees + free seats) is " << getHCoeficient(businessPark, sizeOfTheArr) << endl;
	cout << "Most people per floor " << getMostPeoplePerFloor(businessPark, sizeOfTheArr) << endl;
	cout << "Least people per floor " << getLeastPeoplePerFloor(businessPark, sizeOfTheArr) << endl;
	cout << "Most offices per floor " << getMostOfficesPerFl(businessPark, sizeOfTheArr) << endl;
	cout << "Least offices per floor " << getLeastOfficesPerFl(businessPark, sizeOfTheArr) << endl;
	cout << "Most people per office " << getMostPeoplePeroffice(businessPark, sizeOfTheArr) << endl;
	cout << "Least people per office " << getLeastPeoplePeroffice(businessPark, sizeOfTheArr) << endl;
	
	return 0;
}





