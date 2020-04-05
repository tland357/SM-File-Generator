#pragma once

#include <vector>
#include <unordered_map>
#include <array>
#include <unordered_set>
#include "Step.hpp"

using namespace std;

template <int i>
using Pat = array<Step, i>;

class StepPattern {
public:
	List<Step> Steps;
	static List<StepPattern> StartsOnRight;
	static List<StepPattern> StartsOnLeft;
	static List<StepPattern> StartsOnEither;
	static unordered_map<int, List<StepPattern>> StartsWithPos;
	int StartFoot, StartPosition, EndFoot, EndPosition, SuggestedNextFoot, SuggestedNextPositions;
private:
	
public:
	

	template <int i, int j>
	StepPattern(Pat<i> steps, int startFoot, int endFoot, int suggestedNextFoot, Pat<j> SuggestedNextPositions) {
		StartFoot = startFoot;
		EndFoot = endFoot;
		StartPosition = steps[0].GetPositioning();
		EndPosition = steps[steps.size()].GetPositioning();
		if (startFoot == RIGHT) {
			StartsOnRight.push_back(*this);
		}
		else if (startFoot == LEFT) {
			StartsOnLeft.push_back(*this);
		}
		else {
			StartsOnEither.push_back(*this);
		}
		if (StartsWithPos.find(startFoot) == StartsWithPos.end()) {
			List<StepPattern> v;
			v.push_back(*this);
			StartsWithPos.emplace(startFoot, v);
		}
		else {
			StartsWithPos[startFoot].push_back(*this);
		}
	}
	StepPattern GetNextViablePattern(int DIFFICULTY) {
		switch (DIFFICULTY) {
		case EXTREME:

		case EXPERT:

		case HARD:

		case MEDIUM:

		default: //EASY

		}
	}
};



inline void CreateStepPatterns() {
	StepPattern(Pat<4> {Step(RIGHT), Step(UP), Step(DOWN), Step(LEFT)}, RIGHT, LEFT, RIGHT, Pat<3> {RIGHTSIDE_LIST});
	StepPattern(Pat<4> {Step(RIGHT), Step(DOWN), Step(UP), Step(LEFT)}, RIGHT, LEFT, RIGHT, Pat<3> {RIGHTSIDE_LIST});
	StepPattern(Pat<4> {Step(RIGHT | UP), Step(DOWN | RIGHT), Step(DOWN | LEFT), Step(UP | LEFT)}, BOTH, BOTH, EITHER, Pat<4> {ALL_LIST});
	StepPattern(Pat<2> {Step(RIGHT | UP), Step(LEFT | DOWN)}, BOTH, BOTH, EITHER, Pat<4> {ALL_LIST});
	StepPattern(Pat<2> {Step(LEFT | UP), Step(RIGHT | DOWN)}, BOTH, BOTH, EITHER, Pat<4> {ALL_LIST});

}
#undef ARRAY

