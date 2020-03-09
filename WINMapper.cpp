///////////////////////////////////////////////////////////////////////////
// C++ code generated with wxFormBuilder (version Oct 26 2018)
// http://www.wxformbuilder.org/
//
// PLEASE DO *NOT* EDIT THIS FILE!
///////////////////////////////////////////////////////////////////////////

#include "WINMapper.hpp"
#include "Measure.hpp"
#include "Step.hpp"

///////////////////////////////////////////////////////////////////////////

Song* createTestSong() {
	Song* s = new Song("");
	s->BeatsPerMeasure = 4;
	s->Difficulties.push_back(Difficulty(EDifficulty::Hard));
	std::vector<Step> stepsMeasure1;
	stepsMeasure1.push_back(Step("1000"));
	stepsMeasure1.push_back(Step("0200"));
	stepsMeasure1.push_back(Step("0320"));
	stepsMeasure1.push_back(Step("0030"));
	stepsMeasure1.push_back(Step("1001"));
	s->Difficulties[0].Measures.push_back(stepsMeasure1);
	return s;
}

WINMapper::WINMapper(wxWindow* parent, wxWindowID id, const wxString& title, const wxPoint& pos, const wxSize& size, long style) : wxFrame(parent, id, title, pos, size, style)
{
	this->SetSizeHints(wxDefaultSize, wxDefaultSize);
	
	m_auiToolBar2 = new wxAuiToolBar(this, wxID_ANY, wxDefaultPosition, wxSize(-1, -1), wxAUI_TB_HORZ_LAYOUT);
	LBLLoad = new wxStaticText(m_auiToolBar2, wxID_ANY, wxT("Select Audio File: "), wxDefaultPosition, wxDefaultSize, 0);
	LBLLoad->Wrap(-1);
	m_auiToolBar2->AddControl(LBLLoad);
	FPCAudioFile = new wxFilePickerCtrl(m_auiToolBar2, wxID_ANY, wxEmptyString, wxT("Select a file"), wxT("*.*"), wxDefaultPosition, wxDefaultSize, wxFLP_DEFAULT_STYLE);
	m_auiToolBar2->AddControl(FPCAudioFile);
	BTNExport = new wxButton(m_auiToolBar2, wxID_ANY, wxT("Export To Simfile"), wxDefaultPosition, wxDefaultSize, 0);
	BTNExport->Enable(false);

	m_auiToolBar2->AddControl(BTNExport);
	m_auiToolBar2->Realize();

	wxFlexGridSizer* fgSizer4;
	fgSizer4 = new wxFlexGridSizer(0, 2, 0, 0);
	fgSizer4->SetFlexibleDirection(wxBOTH);
	fgSizer4->SetNonFlexibleGrowMode(wxFLEX_GROWMODE_SPECIFIED);

	wxFlexGridSizer* fgSizer3;
	fgSizer3 = new wxFlexGridSizer(0, 2, 0, 0);
	fgSizer3->SetFlexibleDirection(wxBOTH);
	fgSizer3->SetNonFlexibleGrowMode(wxFLEX_GROWMODE_SPECIFIED);

	m_panel11 = new wxPanel(this, wxID_ANY, wxDefaultPosition, wxSize(-1, 26), wxTAB_TRAVERSAL);
	fgSizer3->Add(m_panel11, 1, wxEXPAND | wxALL, 5);

	
	m_panel12 = new wxPanel(this, wxID_ANY, wxDefaultPosition, wxDefaultSize, wxTAB_TRAVERSAL);
	m_panel12->Hide();
	fgSizer3->Add(m_panel12, 1, wxEXPAND | wxALL, 5);

	m_staticText3 = new wxStaticText(this, wxID_ANY, wxT("Select Background Image: "), wxDefaultPosition, wxDefaultSize, 0);
	m_staticText3->Wrap(-1);
	fgSizer3->Add(m_staticText3, 0, wxALL, 5);

	FPCBackgroundImage = new wxFilePickerCtrl(this, wxID_ANY, wxEmptyString, wxT("Select a file"), wxT("*.*"), wxDefaultPosition, wxDefaultSize, wxFLP_DEFAULT_STYLE);
	fgSizer3->Add(FPCBackgroundImage, 0, wxALL, 5);

	m_staticText4 = new wxStaticText(this, wxID_ANY, wxT("Select Cover Image: "), wxDefaultPosition, wxDefaultSize, 0);
	m_staticText4->Wrap(-1);
	fgSizer3->Add(m_staticText4, 0, wxALL, 5);

	FPCCoverImage = new wxFilePickerCtrl(this, wxID_ANY, wxEmptyString, wxT("Select a file"), wxT("*.*"), wxDefaultPosition, wxDefaultSize, wxFLP_DEFAULT_STYLE);
	fgSizer3->Add(FPCCoverImage, 0, wxALL, 5);

	LBLSelectDifficulties = new wxStaticText(this, wxID_ANY, wxT("Select Difficulties"), wxDefaultPosition, wxDefaultSize, 0);
	LBLSelectDifficulties->Wrap(-1);
	fgSizer3->Add(LBLSelectDifficulties, 0, wxALL, 5);

	BTNSelectAllDifficulties = new wxButton(this, wxID_ANY, wxT("Select All"), wxDefaultPosition, wxSize(215, -1), 0);
	fgSizer3->Add(BTNSelectAllDifficulties, 0, wxALL, 5);

	CHKEasy = new wxCheckBox(this, wxID_ANY, wxT("Easy"), wxDefaultPosition, wxDefaultSize, 0);
	CHKEasy->SetValue(true);
	fgSizer3->Add(CHKEasy, 0, wxALL, 5);

	CHKMedium = new wxCheckBox(this, wxID_ANY, wxT("Medium"), wxDefaultPosition, wxDefaultSize, 0);
	CHKMedium->SetValue(true);
	fgSizer3->Add(CHKMedium, 0, wxALL, 5);

	CHKHard = new wxCheckBox(this, wxID_ANY, wxT("Hard"), wxDefaultPosition, wxDefaultSize, 0);
	CHKHard->SetValue(true);
	fgSizer3->Add(CHKHard, 0, wxALL, 5);

	CHKExpert = new wxCheckBox(this, wxID_ANY, wxT("Expert"), wxDefaultPosition, wxDefaultSize, 0);
	CHKExpert->SetValue(true);
	fgSizer3->Add(CHKExpert, 0, wxALL, 5);

	CHKExtreme = new wxCheckBox(this, wxID_ANY, wxT("Extreme"), wxDefaultPosition, wxDefaultSize, 0);
	CHKExtreme->SetValue(true);
	fgSizer3->Add(CHKExtreme, 0, wxALL, 5);

	m_panel7 = new wxPanel(this, wxID_ANY, wxDefaultPosition, wxDefaultSize, wxTAB_TRAVERSAL);
	m_panel7->Hide();

	fgSizer3->Add(m_panel7, 1, wxEXPAND | wxALL, 5);

	LBLSettings = new wxStaticText(this, wxID_ANY, wxT("Settings: "), wxDefaultPosition, wxDefaultSize, 0);
	LBLSettings->Wrap(-1);
	fgSizer3->Add(LBLSettings, 0, wxALL, 5);

	m_panel9 = new wxPanel(this, wxID_ANY, wxDefaultPosition, wxDefaultSize, wxTAB_TRAVERSAL);
	m_panel9->Hide();

	fgSizer3->Add(m_panel9, 1, wxEXPAND | wxALL, 5);

	LBLBeatsPerMeasure = new wxStaticText(this, wxID_ANY, wxT("Number of Beats Per Measure:"), wxDefaultPosition, wxDefaultSize, 0);
	LBLBeatsPerMeasure->Wrap(-1);
	fgSizer3->Add(LBLBeatsPerMeasure, 0, wxALL, 5);

	m_textCtrl2 = new wxTextCtrl(this, wxID_ANY, wxT("4"), wxDefaultPosition, wxSize(215, -1), 0);
	fgSizer3->Add(m_textCtrl2, 0, wxALL, 5);

	LBLDifficultyPicker = new wxStaticText(this, wxID_ANY, wxT("Choose Difficulty"), wxDefaultPosition, wxDefaultSize, 0);
	LBLDifficultyPicker->Wrap(-1);
	fgSizer3->Add(LBLDifficultyPicker, 0, wxALL, 5);

	wxString CHODifficultyPickerChoices[] = { wxT("None"), wxT("All"), wxT("Easy"), wxT("Medium"), wxT("Hard"), wxT("Expert"), wxT("Extreme") };
	int CHODifficultyPickerNChoices = sizeof(CHODifficultyPickerChoices) / sizeof(wxString);
	CHODifficultyPicker = new wxChoice(this, wxID_ANY, wxDefaultPosition, wxSize(215, -1), CHODifficultyPickerNChoices, CHODifficultyPickerChoices, 0);
	//CHODifficultyPicker->SetWindowStyleFlag(wxTE_PROCESS_ENTER);
	CHODifficultyPicker->SetWindowStyle(wxTE_PROCESS_ENTER);
	CHODifficultyPicker->SetSelection(0);
	fgSizer3->Add(CHODifficultyPicker, 0, wxALL, 5);
	

	CHKHands = new wxCheckBox(this, wxID_ANY, wxT("Allow Hands"), wxDefaultPosition, wxDefaultSize, 0);
	CHKHands->Enable(false);

	fgSizer3->Add(CHKHands, 0, wxALL, 5);

	CHKRolls = new wxCheckBox(this, wxID_ANY, wxT("Allow Rolls"), wxDefaultPosition, wxDefaultSize, 0);
	CHKRolls->Enable(false);

	fgSizer3->Add(CHKRolls, 0, wxALL, 5);

	CHKJackhammers = new wxCheckBox(this, wxID_ANY, wxT("Allow Jackhammers"), wxDefaultPosition, wxDefaultSize, 0);
	CHKJackhammers->Enable(false);

	fgSizer3->Add(CHKJackhammers, 0, wxALL, 5);

	CHKMines = new wxCheckBox(this, wxID_ANY, wxT("Allow Mines"), wxDefaultPosition, wxDefaultSize, 0);
	CHKMines->Enable(false);

	fgSizer3->Add(CHKMines, 0, wxALL, 5);

	LBLJumpPercent = new wxStaticText(this, wxID_ANY, wxT("Suggest Jump Percentage: "), wxDefaultPosition, wxDefaultSize, 0);
	LBLJumpPercent->Wrap(-1);
	fgSizer3->Add(LBLJumpPercent, 0, wxALL, 5);

	SLDJumpPercentage = new wxSlider(this, wxID_ANY, 12, 0, 100, wxDefaultPosition, wxSize(215, -1), wxSL_HORIZONTAL);
	SLDJumpPercentage->Enable(false);

	fgSizer3->Add(SLDJumpPercentage, 0, wxALL, 5);

	BTNGenerateFile = new wxButton(this, wxID_ANY, wxT("Generate Sim Data"), wxDefaultPosition, wxDefaultSize, 0);
	fgSizer3->Add(BTNGenerateFile, 0, wxALL, 5);


	fgSizer4->Add(fgSizer3, 1, wxEXPAND, 5);

	m_scrolledWindow1 = new wxScrolledWindow(this, wxID_ANY, wxDefaultPosition, wxSize(460,600), wxVSCROLL);
	m_scrolledWindow1->SetScrollRate(5, 5);
	wxSizer* bSizer1;
	bSizer1 = new wxGridSizer(1, 1, wxSize(460, 600));

	GRDSteps = new wxGrid(m_scrolledWindow1, wxID_ANY, wxDefaultPosition, wxSize(460,600), 0);

	// Grid
	GRDSteps->CreateGrid(0, 4);
	GRDSteps->EnableEditing(false);
	GRDSteps->EnableGridLines(true);
	GRDSteps->EnableDragGridSize(false);
	GRDSteps->SetMargins(0, 0);

	// Columns
	GRDSteps->EnableDragColMove(false);
	GRDSteps->EnableDragColSize(true);
	GRDSteps->SetColLabelSize(30);
	GRDSteps->SetColLabelValue(0, wxT("L"));
	GRDSteps->SetColLabelValue(1, wxT("D"));
	GRDSteps->SetColLabelValue(2, wxT("U"));
	GRDSteps->SetColLabelValue(3, wxT("R"));
	GRDSteps->SetColLabelAlignment(wxALIGN_CENTER, wxALIGN_CENTER);

	// Rows
	GRDSteps->AutoSizeRows();
	GRDSteps->EnableDragRowSize(true);
	GRDSteps->SetRowLabelSize(80);
	GRDSteps->SetRowLabelAlignment(wxALIGN_CENTER, wxALIGN_CENTER);

	// Label Appearance

	// Cell Defaults
	GRDSteps->SetDefaultCellAlignment(wxALIGN_CENTER, wxALIGN_CENTER);
	bSizer1->Add(GRDSteps, 0, wxALL, 5);


	m_scrolledWindow1->SetSizer(bSizer1);
	m_scrolledWindow1->Layout();
	bSizer1->Fit(m_scrolledWindow1);
	fgSizer4->Add(m_scrolledWindow1, 1, wxEXPAND | wxALL, 5);


	this->SetSizer(fgSizer4);
	this->Layout();

	this->Centre(wxBOTH);

	// Connect Events
	FPCAudioFile->Connect(wxEVT_COMMAND_FILEPICKER_CHANGED, wxFileDirPickerEventHandler(WINMapper::SetupFile), NULL, this);
	FPCBackgroundImage->Connect(wxEVT_COMMAND_FILEPICKER_CHANGED, wxFileDirPickerEventHandler(WINMapper::UploadedBackgroundImage), NULL, this);
	FPCCoverImage->Connect(wxEVT_COMMAND_FILEPICKER_CHANGED, wxFileDirPickerEventHandler(WINMapper::UploadedCoverImage), NULL, this);
	CHKEasy->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKMedium->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	BTNSelectAllDifficulties->Connect(wxEVT_COMMAND_BUTTON_CLICKED, wxCommandEventHandler(WINMapper::SelectAllDiffs), NULL, this);
	CHKHard->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKExpert->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKExtreme->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	m_textCtrl2->Connect(wxEVT_COMMAND_TEXT_ENTER, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHODifficultyPicker->Connect(wxEVT_COMMAND_CHOICE_SELECTED, wxCommandEventHandler(WINMapper::ChangeDifficulty), NULL, this);
	CHKHands->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKRolls->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKJackhammers->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKMines->Connect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	SLDJumpPercentage->Connect(wxEVT_SLIDER, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	BTNGenerateFile->Connect(wxEVT_COMMAND_BUTTON_CLICKED, wxCommandEventHandler(WINMapper::GenerateSimData), NULL, this);


	songChartInterface = SongChartInterface(createTestSong(), GRDSteps);

}

WINMapper::~WINMapper()
{
	// Disconnect Events
	FPCAudioFile->Disconnect(wxEVT_COMMAND_FILEPICKER_CHANGED, wxFileDirPickerEventHandler(WINMapper::SetupFile), NULL, this);
	FPCBackgroundImage->Disconnect(wxEVT_COMMAND_FILEPICKER_CHANGED, wxFileDirPickerEventHandler(WINMapper::UploadedBackgroundImage), NULL, this);
	FPCCoverImage->Disconnect(wxEVT_COMMAND_FILEPICKER_CHANGED, wxFileDirPickerEventHandler(WINMapper::UploadedCoverImage), NULL, this);
	CHKEasy->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKMedium->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	BTNSelectAllDifficulties->Disconnect(wxEVT_COMMAND_BUTTON_CLICKED, wxCommandEventHandler(WINMapper::SelectAllDiffs), NULL, this);
	CHKHard->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKExpert->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKExtreme->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	m_textCtrl2->Disconnect(wxEVT_COMMAND_TEXT_ENTER, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHODifficultyPicker->Disconnect(wxEVT_COMMAND_CHOICE_SELECTED, wxCommandEventHandler(WINMapper::ChangeDifficulty), NULL, this);
	CHKHands->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKRolls->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKJackhammers->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	CHKMines->Disconnect(wxEVT_COMMAND_CHECKBOX_CLICKED, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	SLDJumpPercentage->Disconnect(wxEVT_SLIDER, wxCommandEventHandler(WINMapper::DirtyData), NULL, this);
	BTNGenerateFile->Disconnect(wxEVT_COMMAND_BUTTON_CLICKED, wxCommandEventHandler(WINMapper::GenerateSimData), NULL, this);

}
