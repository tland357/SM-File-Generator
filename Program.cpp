#include "APPMapper.hpp"
#include <wx/wx.h>
#include <random>
//wxIMPLEMENT_APP(APPMapper);

wxIMPLEMENT_APP_NO_MAIN(APPMapper);

int main(int argc, char** argv) {
	srand(time(0));
	wxEntry();
}