#pragma once

#include <string>
#include <vector>
#include "Measure.hpp"

using namespace std;

enum class EDifficulty {
	Easy,
	Medium,
	Hard,
	Expert,
	Extreme
};

class Difficulty {
public:
	bool AllowHands, AllowRolls, AllowJackHammers, AllowMines;
	double JumpPercentage;
	vector<class Measure> Measures;
	Difficulty(EDifficulty difficulty, bool hands = false, bool rolls = false, bool jacks = false, bool mines = false, double percentjumps = 12.0) {
		AllowHands = hands;
		AllowJackHammers = jacks;
		AllowMines = mines;
		AllowRolls = rolls;
		JumpPercentage = percentjumps;
	}
};

class Song {
	double BeatsPerMinute;
	double msTilStart;
public:
	Song(string fileDirectory, float samples = 1024);
	std::vector<Difficulty> Difficulties;
	int BeatsPerMeasure;
};