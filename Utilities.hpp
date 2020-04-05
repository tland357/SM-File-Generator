#pragma once

#include <random>
#include <vector>

#define STEPMANIA5
#define GenInPlace(FunctionName) inline void FunctionName(char* x) {*x = FunctionName(*x);}

#define EASY 1
#define MEDIUM 2
#define HARD 4
#define EXPERT 8
#define EXTREME 16

#define LEFT 1
#define DOWN 2
#define UP 4
#define RIGHT 8
#define BOTH (LEFT | RIGHT)
#define EITHER 0
#define ALL (LEFT | RIGHT | DOWN | UP)
#define RIGHTSIDE (RIGHT | UP | DOWN)
#define LEFTSIDE (LEFT | UP | DOWN)
#define ALL_LIST LEFT, RIGHT, DOWN, UP
#define RIGHTSIDE_LIST RIGHT, UP, DOWN
#define LEFTSIDE_LIST LEFT, UP, DOWN

constexpr inline char ToLower(char x) {
	if (x >= 'A' && x <= 'Z') return x + 'a' - 'A';
	return x;
}

constexpr inline char ToUpper(char x) {
	if (x >= 'a' && x <= 'z') return x - 'a' + 'A';
	return x;
}

constexpr inline char ToStep(char x) {
	switch (ToUpper(x)) {
		case '1':
		case '2':
		case '3':
		case '4':
		case 'M':
		case 'K':
		case 'L':
		case 'F':
			return x;
		default: 
			return '0';
	}
}

GenInPlace(ToLower);
GenInPlace(ToUpper);
GenInPlace(ToStep);

inline bool IsNotPress(char x) {
	ToUpper(&x);
	return x == '0' || x == 'M' || x == '3';
}

inline bool IsPress(char x) {
	return !IsNotPress(x);
}

template <typename Collection, typename ItemType>
inline bool Contains(ItemType item, Collection c) {
	for (ItemType t : c) {
		if (t == item) return true;
	}
	return false;
}

using namespace std;

template <typename ItemType>
class List : vector<ItemType> {
	List Where(bool(*Conditional)(ItemType)) {
		List result;
		for (ItemType t : *this) {
			if (Conditional(t)) { result.push_back(t); }
		}
		return result;
	}
};