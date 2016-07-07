#pragma once
#include <string>
#include "PhysicalObject.h"

class Character : public PhysicalObject
{
	std::string _name;
	float _jumpSpeed;
	float _velocity_x;
	float _velocity_y;
	unsigned int _id;

public:
	Character();
	Character(std::string name, unsigned int id, float jumpSpeed, int mass, int possitionX, int possitionY);
	~Character();

	float getJumpSpeed();
	float getVelocityX();
	float getVelocityY();
	std::string getName();
	unsigned int getID();

	
	void setJumpSpeed(float jspeed);
	void setName(std::string name);
	void setID(unsigned int ID);
	void setVelocityX(float v_x);
	void setVelocityY(float v_y);

	

	
};

