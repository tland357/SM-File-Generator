#include "APPMapper.hpp"
#include "WINMapper.hpp"

bool APPMapper::OnInit() {
	static WINMapper* window = new WINMapper(nullptr);
	window->Show();
	return true;
}