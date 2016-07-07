#pragma once
#include <string>

class Environment
{
private:
	unsigned int _id;
	float _gravity;
	std::string _name;


public:
	Environment();
	Environment(unsigned int id, std::string name, float gravity);
	~Environment();

	void setID(unsigned int id);
	void setGravity(float gr);
	void setName(std::string name);

	std::string getName();
	float getGravity();
	unsigned int getID();

};

