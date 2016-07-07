// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Environment.h"
#include "Character.h"
#include "PhysicsHandler.h"
#include <iostream>


int main()
{

	Environment  environment = Environment(1, "Earth", 9.81); //creating current instance of environment -> takes id, name and gravity
	Character player = Character("Mario", 1, 10 , 10, 1, 0); // creating current instance of playter -> takes name, id, jumpSpeed, mass, possitionx, possitiony
	PhysicsHandler physical_handler = PhysicsHandler(environment); // wrap an instanse of PhysicsHandler with specific environment

	std::cout << "Environment = " << environment.getName() << " gravity = " << environment.getGravity() << "m/s^2" << std::endl;
	std::cout << "Character = " << player.getName() << " with jump speed =" << player.getJumpSpeed() << " m/s" << std::endl;

	std::cout << "Max jump height is equals to " << physical_handler.CalculateMaxJumpHeight(player) << " m" << std::endl;
	std::cout << "Total time of jump is equals to " << physical_handler.CalculateTimeOfTheJump(player) << " s" << std::endl;

	std::cout << "If current player is capable to jump on 0.30 m height ";
    if(physical_handler.isCapableOfJumping(player, 0.3))
    {
		std::cout << " true" << std::endl;
    }
	else
	{
		std::cout << " false;" << std::endl;
	}

	std::cout << "If current player is capable to jump on 0.45 m height ";
	if (physical_handler.isCapableOfJumping(player, 0.45))
	{
		std::cout << " true" << std::endl;
	}
	else
	{
		std::cout << " false;" << std::endl;
	}


    return 0;
}

