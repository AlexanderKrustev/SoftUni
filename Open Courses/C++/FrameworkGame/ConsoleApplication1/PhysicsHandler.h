#pragma once
#include "Character.h"
#include "Environment.h"

class PhysicsHandler
{
private:
	Environment _surroundingEnvironment;
public:
	PhysicsHandler(Environment anEnv);
	~PhysicsHandler();


	void setEnvironment(Environment e);

	float CalculateMaxJumpHeight(Character anObj);
	float CalculateTimeOfTheJump(Character anObj);
	bool isCapableOfJumping(Character anObj, float height);

	Environment getEnvironment();
};

