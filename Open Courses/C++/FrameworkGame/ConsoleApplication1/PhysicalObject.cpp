#include "stdafx.h"
#include "PhysicalObject.h"


PhysicalObject::PhysicalObject(int possitionX, int possitionY, float weight)
{
	setPossitionX(possitionX);
	setPossitionY(possitionY);
	setWeight(weight);
}

PhysicalObject::PhysicalObject()
{
	
}


PhysicalObject::~PhysicalObject()
{
}

int PhysicalObject::getPossitionX()
{
	return this->_possitionX;
}

int PhysicalObject::getPossitionY()
{
	return  this->_possitionY;
}

float PhysicalObject::getWeight()
{
	return this->_weight;
}
void PhysicalObject::setPossitionY(int y)
{
	this->_possitionY = y;
}
void PhysicalObject::setPossitionX(int x)
{
	this->_possitionX = x;
}
void PhysicalObject::setWeight(float mass)
{
	this->_weight = mass;
}




