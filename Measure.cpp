#include "Measure.hpp"

#include <string>
#include "Step.hpp"

ostream& operator<<(ostream& os, Measure& m) {
	string result = "";
	for (Step step : m.Steps) {
		result += ((string)step + '\n');
	}
	result += ',';
	return os << result;
}

Measure::Measure(vector<Step> steps) {
	Steps = steps;
}