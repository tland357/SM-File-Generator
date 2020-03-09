///////////////////////////////////////////////////////////////////////////
// C++ code generated with wxFormBuilder (version Oct 26 2018)
// http://www.wxformbuilder.org/
//
// PLEASE DO *NOT* EDIT THIS FILE!
///////////////////////////////////////////////////////////////////////////

#pragma once

#include <wx/artprov.h>
#include <wx/xrc/xmlres.h>
#include <wx/string.h>
#include <wx/stattext.h>
#include <wx/gdicmn.h>
#include <wx/font.h>
#include <wx/colour.h>
#include <wx/settings.h>
#include <wx/filepicker.h>
#include <wx/bitmap.h>
#include <wx/image.h>
#include <wx/icon.h>
#include <wx/button.h>
#include <wx/aui/aui.h>
#include <wx/aui/auibar.h>
#include <wx/checkbox.h>
#include <wx/panel.h>
#include <wx/textctrl.h>
#include <wx/choice.h>
#include <wx/slider.h>
#include <wx/sizer.h>
#include <wx/grid.h>
#include <wx/scrolwin.h>
#include <wx/frame.h>

#include "SongChartInterface.hpp"

///////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////
/// Class WINMapper
///////////////////////////////////////////////////////////////////////////////
class WINMapper : public wxFrame
{
private:

protected:
	wxAuiToolBar* m_auiToolBar2;
	wxStaticText* LBLLoad;
	wxFilePickerCtrl* FPCAudioFile;
	wxButton* BTNExport;
	wxStaticText* m_staticText3;
	wxFilePickerCtrl* FPCBackgroundImage;
	wxPanel* m_panel11;
	wxPanel* m_panel12;
	wxStaticText* m_staticText4;
	wxFilePickerCtrl* FPCCoverImage;
	wxStaticText* LBLSelectDifficulties;
	wxButton* BTNSelectAllDifficulties;
	wxCheckBox* CHKEasy;
	wxCheckBox* CHKMedium;
	wxCheckBox* CHKHard;
	wxCheckBox* CHKExpert;
	wxCheckBox* CHKExtreme;
	wxPanel* m_panel7;
	wxStaticText* LBLSettings;
	wxPanel* m_panel9;
	wxStaticText* LBLBeatsPerMeasure;
	wxTextCtrl* m_textCtrl2;
	wxStaticText* LBLDifficultyPicker;
	wxChoice* CHODifficultyPicker;
	wxCheckBox* CHKHands;
	wxCheckBox* CHKRolls;
	wxCheckBox* CHKJackhammers;
	wxCheckBox* CHKMines;
	wxStaticText* LBLJumpPercent;
	wxSlider* SLDJumpPercentage;
	wxButton* BTNGenerateFile;
	wxScrolledWindow* m_scrolledWindow1;
	wxGrid* GRDSteps;
	SongChartInterface songChartInterface;
	// Virtual event handlers, overide them in your derived class
	virtual void SetupFile(wxFileDirPickerEvent& event) { event.Skip(); }
	virtual void UploadedBackgroundImage(wxFileDirPickerEvent& event) { event.Skip(); }
	virtual void UploadedCoverImage(wxFileDirPickerEvent& event) { event.Skip(); }
	virtual void DirtyData(wxCommandEvent& event) {
		bool AllowFileGeneration = false;
		std::vector<wxString> items;
		if (CHKEasy->IsChecked()) {
			AllowFileGeneration = true;
			items.push_back("Easy");
		}
		if (CHKMedium->IsChecked()) {
			AllowFileGeneration = true;
			items.push_back("Medium");
		}
		if (CHKHard->IsChecked()) {
			AllowFileGeneration = true;
			items.push_back("Hard");
		}
		if (CHKExpert->IsChecked()) {
			items.push_back("Expert");
			AllowFileGeneration = true;
		}
		if (CHKExtreme->IsChecked()) {
			items.push_back("Extreme");
			AllowFileGeneration = true;
		}
		if (items.size() > 1) items.insert(items.begin(),"All");
		items.insert(items.begin(), "None");
		BTNGenerateFile->Enable(AllowFileGeneration);
		int prev = CHODifficultyPicker->GetSelection();
		CHODifficultyPicker->Set(items);
		auto a1 = event.GetEventObject();
		if (!(a1 == CHKHands || a1 == CHKJackhammers || a1 == CHKMines || a1 == CHKRolls)) {
			if (prev >= items.size()) prev = 0;
			CHODifficultyPicker->Select(prev);
			ChangeDifficulty(event);
		}
		else {
			CHODifficultyPicker->Select(prev);
		}
		if (a1 != BTNSelectAllDifficulties) {

		}
	}
	virtual void ChangeDifficulty(wxCommandEvent& event) { 
		bool AllowSettings = (CHODifficultyPicker->GetSelection() != 0);
		CHKHands->Enable(AllowSettings);
		CHKJackhammers->Enable(AllowSettings);
		CHKMines->Enable(AllowSettings);
		CHKRolls->Enable(AllowSettings);
		SLDJumpPercentage->Enable(AllowSettings);
	}
	virtual void SelectAllDiffs(wxCommandEvent& event) {
		CHKEasy->SetValue(true);
		CHKMedium->SetValue(true);
		CHKHard->SetValue(true);
		CHKExpert->SetValue(true);
		CHKExtreme->SetValue(true);
		DirtyData(event);
	}
	virtual void GenerateSimData(wxCommandEvent& event) { 
		songChartInterface.PopulateGrid();
	}


public:

	WINMapper(wxWindow* parent, wxWindowID id = wxID_ANY, const wxString& title = wxT("Sim File Mapper"), const wxPoint& pos = wxDefaultPosition, const wxSize& size = wxSize(977, 567), long style = wxDEFAULT_FRAME_STYLE | wxTAB_TRAVERSAL);

	~WINMapper();

};

