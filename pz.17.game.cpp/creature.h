#pragma once


class Creature
{
private:
	int _health = 35;
	int _strength = 5;
public:
	Creature() { }
	Creature(int health = 35, int strength = 5) : _health{ health }, _strength{ strength } { }

	int getHealth() const { return _health; }
	int getStrength() const { return _strength; }

	void setHealth(int newHealth) { _health = newHealth; }
	void setStrength(int newStr) { _strength = newStr; }

	~Creature() { }
};