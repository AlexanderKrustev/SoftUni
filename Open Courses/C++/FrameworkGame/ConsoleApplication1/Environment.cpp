#include "stdafx.h"
#include "Environment.h"


Environment::Environment()
{
}


Environment::~Environment()
{
}

Environment::Environment(unsigned id, std::string name, float gravity)
{
	this->setID(id);
	this->setName(name);
	this->setGravity(gravity);
}

float Environment::getGravity()
{
	return  this->_gravity;
}

unsigned Environment::getID()
{
	return  this->_id;
}

std::string Environment::getName()
{
	return this->_name;
}

void Environment::setGravity(float gr)
{
	this->_gravity = gr;
}

void Environment::setID(unsigned id)
{
	this->_id = id;
}

void Environment::setName(std::string name)
{
	this->_name = name;
}









