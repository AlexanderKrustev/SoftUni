#include "stdafx.h"
#include "PhysicsHandler.h"


PhysicsHandler::PhysicsHandler(Environment anEnv)
{
	this->setEnvironment(anEnv);
}


PhysicsHandler::~PhysicsHandler()
{
}

Environment PhysicsHandler::getEnvironment()
{
	return this->_surroundingEnvironment;
}

void PhysicsHandler::setEnvironment(Environment e)
{
	this->_surroundingEnvironment = e;
}


bool PhysicsHandler::isCapableOfJumping(Character anObj, float height)
{
	if(CalculateMaxJumpHeight(anObj)>height)
	{
		return true;
	}

	return false;
}

float PhysicsHandler::CalculateMaxJumpHeight(Character anObj)
{
	float ymax = (anObj.getJumpSpeed()*anObj.getJumpSpeed() / this->getEnvironment().getGravity())/2;
	
	return ymax;
}

float PhysicsHandler::CalculateTimeOfTheJump(Character anObj)
{
	float ymax = anObj.getJumpSpeed()*anObj.getJumpSpeed() / (this->getEnvironment().getGravity() / 2);
	float  t = (anObj.getJumpSpeed() / this->getEnvironment().getGravity()) + sqrt((2 * ymax) / this->getEnvironment().getGravity());
	return  t;
}



