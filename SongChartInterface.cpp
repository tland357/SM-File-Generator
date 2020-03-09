#include "SongChartInterface.hpp"
#include "Measure.hpp"
#include "MusicAnalyzer.hpp"
#include "Step.hpp"

void SongChartInterface::PopulateGrid() {
	if (grid->GetNumberRows() > 0) {
		grid->DeleteRows(0, grid->GetNumberRows());
	}
	int i = 0;
	for (Difficulty& diff : song->Difficulties) {
		for (Measure& measure : diff.Measures) {
			for (Step step : measure.Steps) {
				grid->AppendRows();
				grid->SetCellValue(wxGridCellCoords(i, 0), step.L());
				grid->SetCellValue(wxGridCellCoords(i, 1), step.D());
				grid->SetCellValue(wxGridCellCoords(i, 2), step.U());
				grid->SetCellValue(wxGridCellCoords(i++, 3), step.R());
			}
			grid->AppendRows();
			grid->SetCellValue(wxGridCellCoords(i, 0), "-");
			grid->SetCellValue(wxGridCellCoords(i, 1), "-");
			grid->SetCellValue(wxGridCellCoords(i, 2), "-");
			grid->SetCellValue(wxGridCellCoords(i++, 3), "-");
		}
	}
}