#pragma once

#include <iostream>
#include <string>
#include "Utilities.hpp"

enum class EStepType : char {
	None = '0',
	Note = '1',
	Hold = '2',
	Tail = '3',
	Roll = '4',
	Mine = 'M',
#ifdef STEPMANIA5
	KeySound = 'K', //SM5 only
	LiftNote = 'L', //SM5 only
	FakeNote = 'F', //SM5 only
#endif
};

class Step {
	std::string Buttons;
public:
	Step(EStepType l, EStepType d, EStepType u, EStepType r);
	Step(std::string btns) {
		Buttons = "";
		Buttons += ToStep(btns[0]);
		Buttons += ToStep(btns[1]); 
		Buttons += ToStep(btns[2]);
		Buttons += ToStep(btns[3]);
	}
	explicit operator std::string();
	char L() { return Buttons[0]; }
	char R() { return Buttons[1]; }
	char U() { return Buttons[2]; }
	char D() { return Buttons[3]; }
};

std::ostream& operator<<(std::ostream& os, Step& step);
