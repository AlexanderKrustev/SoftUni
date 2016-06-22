// CPP_HW3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <iostream>
#include <vector>
using namespace std;

class Member
{
	
	int _id;
	string _name;
	string _currentCourse;
public:
	Member(){}
	Member(int id, string name,string current )
	{
		setId(id);
		setName(name);
		setCurrentCourse(current);
		
	}
	~Member(){}
	void setId(int id)
	{
		if (id<0 && id>65535)
		{
			cout << "Incorect value for id";
			return;
		}
		this->_id = id;
	}
	int getId() { return  this->_id; }
	void setName(string name)
	{
		if (name.length() == 0)
		{
			cout << "Incorect value for  name";
			return;
		}
		this->_name = name;
	}

	string getName() { return this->_name; }
	void setCurrentCourse(string current)
	{
		this->_currentCourse = current;
	}	
	string getCurrentCourse() { return this->_currentCourse; }
};

class Student: public Member
{
	double _avarageGrade = 0;

public:
	Student(int id, string name, string currentCourse, double grade)
		:Member(id, name,currentCourse)
	{
	    setGrade(grade);
	}
	
	double getAvarage()
	{
		return this->_avarageGrade;
	}

	void setGrade(double grade)
	{
		if (_avarageGrade == 0)
		{
			this->_avarageGrade = grade;
		}
		else
		{
			this->_avarageGrade = (_avarageGrade + grade) / 2.0;
		}
	}
};

class Teacher : public Member
{
	double _monthSalary;
	int _passedDays;
public:
	Teacher(int id, string name, string current, double salary, int days)
		:Member(id, name, current)
	{		
		setSalary(salary);
		setDays(days);
	}

	void setSalary(double salary)
	{
		if (salary<0)
		{
			cout << "Month Salary cannot be negative!" << endl;
			return;
		}
		this->_monthSalary = salary;
	}	

	void setDays(int days)
	{
		if(days<0 || days>65535)
		{
			cout << "Incorrect days" << endl;
			return;
			
		}
		this->_passedDays = days;
	}

	int getDays() { return this->_passedDays; }
	double getSalary() { return this->_monthSalary; }
	
};

class GuestTeacher : public Member
{
	double _monthSalary;
	int _passedDays;
public:
	GuestTeacher(int id, string name, string current, double salary)
		: Member(id, name, current) 
	{
		setSalary(salary);
	}
	
	void setSalary(double salary)
	{
		if (salary<0)
		{
			cout << "Month Salary cannot be negative!" << std::endl;
			return;
		}
		this->_monthSalary = salary;
	}
	double getSalary() { return this->_monthSalary; }	
};

int main()
{

	vector<Student> studentList;
	vector<Teacher> teachersList;
	vector<GuestTeacher> guest_teachersList;
	Student student1 = Student(1, "Ivan Ivanov", "c++", 50);
	Student student2 = Student(2, "Ivan ", "c#", 95);
	Student student3 = Student(3, "Petkan Ivanov", "php", 0);
	Teacher teacher1 = Teacher(1, "Royal", "c++", 3000, 750);
	Teacher teacher2 = Teacher(2, "Nasko", "Algorithms", 2500, 750);
	Teacher teacher3 = Teacher(3, "Alex", "Java", 2000, 100);
	GuestTeacher gTeacher = GuestTeacher(2, "Martin", "C++ Advances", 5000);
	GuestTeacher gTeacher1 = GuestTeacher(1, "Zapo", "Facebook", 5000);


	studentList.insert(studentList.begin(), student1);
	studentList.insert(studentList.begin() + 1, student2);
	studentList.insert(studentList.begin() + 2, student3);

	teachersList.insert(teachersList.begin(), teacher1);
	teachersList.insert(teachersList.begin() + 1, teacher2);
	teachersList.insert(teachersList.begin() + 2, teacher3);

	guest_teachersList.insert(guest_teachersList.begin(), gTeacher);
	guest_teachersList.insert(guest_teachersList.begin() + 1, gTeacher1);
	bool isRunning = true;
	while (isRunning)
	{
		cout << endl;
		cout << "Press 0 for exit" << endl;
		cout << "Press 1 to Get data for student	with ID" << endl;
		cout << "Press 2 to Get data	for	teacher	with ID" << endl;
		cout << "Press 3 to Get data for gest teacher with	ID" << endl;
		cout << "Press 4 to Add data for new student" << endl;
		cout << "Press 5 to Add	data	for	new	teacher" << endl;
		cout << "Press 6 to Add	data	for	new	guest	teacher" << endl;
		cout << endl;
		char command;
		cin >> command;

		switch (command)
		{
		case '0': {
			cout << "Program terminated" << endl;
			isRunning = false;
		}break;
		case '1': {
			cout << "Provide student id" << endl;
			int idStudent;
			cin >> idStudent;
			for (vector<Student>::iterator x = studentList.begin(); x != studentList.end(); ++x)
			{
				if (idStudent == x->getId())
				{
					cout << "Name: " << x->getName() << endl;
					cout << "Id: " << x->getId() << endl;
					cout << "Current Course: " << x->getCurrentCourse() << endl;
					cout << "Average grade: " << x->getAvarage() << endl;
				}
			}

		}break;
		case '2': {
			cout << "Provide Teacher id" << endl;
			int idTeacher;
			cin >> idTeacher;
			for (vector<Teacher>::iterator x = teachersList.begin(); x != teachersList.end(); ++x)
			{
				if (idTeacher == x->getId())
				{
					cout << "Name: " << x->getName() << endl;
					cout << "Id: " << x->getId() << endl;
				}
			}

		}break;
		case '3': {
			cout << "Provide Geust Teacher id" << endl;
			int idGest;
			cin >> idGest;
			for (vector<GuestTeacher>::iterator x = guest_teachersList.begin(); x != guest_teachersList.end(); ++x)
			{
				if (idGest == x->getId())
				{
					cout << "Name: " << x->getName() << endl;
					cout << "Id: " << x->getId() << endl;
				}
			}

		}break;
		case '4': {
			bool IDexist = false;
			string name;
			int id;
			string course;
			double grade;
			cout << "Please provide information for new student by answering fields below." << endl;
			do {
				cout << "Id = ";
				cin >> id;
				for (vector<Student>::iterator x = studentList.begin(); x != studentList.end(); ++x)
				{
					if (id != x->getId())
					{
						IDexist = false;
					}
					else
					{
						IDexist = true;
						cout << "Please provide new ID, this one is already exist" << endl;
						break;
					}
				}
			} while (IDexist);
			cout << "Name = ";
			cin >> name;
			cout << "Course = ";
			cin >> course;
			cout << "Grade = ";
			cin >> grade;
			Student temp = Student(id, name, course, grade);
			cout << "A new student has been successfylly created" << endl;
			cout << "Name : " << temp.getName() << endl;
			cout << "Id : " << temp.getId() << endl;
			cout << "Course : " << temp.getCurrentCourse() << endl;
			cout << "Average grade : " << temp.getAvarage() << endl;
			studentList.insert(studentList.begin(), temp);
		}
		case '5': {
			cout << "Please provide information for new teacher by answering fields below." << endl;
			string name;
			int id;
			string course;
			double salary;
			int days;
			cout << "Id = ";
			cin >> id;
			cout << "Name = ";
			cin >> name;
			cout << "Course = ";
			cin >> course;
			cout << "Salary = ";
			cin >> salary;
			cout << "Days passed at Softuni = ";
			cin >> days;
			Teacher temp = Teacher(id, name, course, salary, days);
			cout << "A new student has been successfylly created" << endl;
			cout << "Name : " << temp.getName() << endl;
			cout << "Id : " << temp.getId() << endl;
			cout << "Course : " << temp.getCurrentCourse() << endl;
			cout << "Salary : " << temp.getSalary() << endl;
			cout << "Days : " << temp.getDays() << endl;
			teachersList.insert(teachersList.begin(), temp);
		}
		case '6':
		{cout << "Please provide information for new geust Teacher by answering fields below." << endl;
		string nameTeacher;
		int idT;
		string course;
		double salary;
		cout << "Id = ";
		cin >> idT;
		cout << "Name = ";
		cin >> nameTeacher;
		cout << "Course = ";
		cin >> course;
		cout << "Salary for this course = ";
		cin >> salary;
		GuestTeacher temp = GuestTeacher(idT, nameTeacher, course, salary);
		cout << "A new student has been successfylly created" << endl;
		cout << "Name : " << temp.getName() << endl;
		cout << "Id : " << temp.getId() << endl;
		cout << "Salary for this course : " << temp.getSalary() << endl;
		guest_teachersList.insert(guest_teachersList.begin(), temp);
		}
		default: break;
		}
	}
	return 0;
}

