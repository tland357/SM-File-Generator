#pragma once
#include <vector>
#include <iostream>
#include "Step.hpp"
using namespace std;

class Measure {
public:
	vector<class Step> Steps;
	Measure(vector<Step> steps);
};

ostream& operator<<(ostream& os, Measure& m);