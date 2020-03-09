#pragma once
#include "MusicAnalyzer.hpp"
#include <wx/grid.h>
class SongChartInterface
{
	Song* song;
	wxGrid* grid;
public:
	SongChartInterface() {
		song = nullptr;
		grid = nullptr;
	}
	SongChartInterface(Song* s, wxGrid* g) {
		song = s;
		grid = g;
		assert(s);
		assert(g);
	}
	void PopulateGrid();
};

