#pragma once
class PhysicalObject
{
private:
	int _possitionX;
	int _possitionY;
	float _weight;
public:
	PhysicalObject();
	PhysicalObject( int possitionX, int possitionY, float weight);
	~PhysicalObject();

	void setPossitionX(int x);
	void setPossitionY(int y);
	void setWeight(float mass);

	int getPossitionX();
	int getPossitionY();
	float getWeight();
};

