#include "stdafx.h"
#include "Character.h"


Character::Character(): PhysicalObject() {
}


Character::~Character()
{
}

Character::Character(std::string name, unsigned id, float jumpSpeed, int mass, int possitionX, int possitionY): PhysicalObject(possitionX, possitionY, mass) {
	this->setName(name);
	this->setID(id);
	this->setJumpSpeed(jumpSpeed);
}

unsigned Character::getID()
{
	return  this->_id;
}

float Character::getJumpSpeed()
{
	return this->_jumpSpeed;
}


std::string Character::getName()
{
	return this->_name;
}

void Character::setID(unsigned ID)
{
	this->_id = ID;
}

void Character::setJumpSpeed(float jspeed)
{

	this->_jumpSpeed = jspeed*0.277; //converting km/h to m/s
}


void Character::setName(std::string name)
{
	this->_name = name;
}






