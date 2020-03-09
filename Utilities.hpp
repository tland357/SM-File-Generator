#pragma once

#define STEPMANIA5

constexpr inline char ToLower(const char x) {
	if (x >= 'A' && x <= 'Z') return x + 'a' - 'A';
	return x;
}

constexpr inline char ToUpper(const char x) {
	if (x >= 'a' && x <= 'z') return x - 'a' + 'A';
	return x;
}

constexpr inline char ToStep(const char x) {
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