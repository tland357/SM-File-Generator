#include "Step.hpp"
#include "Measure.hpp"
#include "Utilities.hpp"

Step::operator std::string() {
	return Buttons;
}

inline Step::Step(EStepType l, EStepType d, EStepType u, EStepType r) {
	Buttons = "";
	Buttons += (char)l;
	Buttons += (char)d;
	Buttons += (char)u;
	Buttons += (char)r;
}


inline std::ostream& operator<<(std::ostream& os, Step& step) {
	return os << (std::string)step;
}

