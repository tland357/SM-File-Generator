// AubioAnalyzerCpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <math.h>
#include <iostream>
#include <aubio/aubio.h>
#include "MiniBpm.h"
#include "onsetsds.h"

using namespace std;
using namespace breakfastquay;


/*int main(int argc, char* argv[]) {
	//arg1 = current directory
	//arg2 = float array length
	//arg3 = samples
	MiniBPM bpmDetector = MiniBPM(4096);
	size_t length = stol(argv[2]);
	float current;
	float* samples = new float[length];
	float* iterator = samples;
	for (size_t i = 0; i < length; i += 1) {
		std::cin >> *(iterator++);
	}
	double BPM = bpmDetector.estimateTempoOfSamples(samples, length);
	printf("%f", BPM);
	delete[] samples;
}*/

int main() {
	OnsetsDS ods;

	// Allocate contiguous memory using malloc or whatever is reasonable.
	float* odsdata = (float*)malloc(onsetsds_memneeded(odftype, 512, 11));

	// There are various types of onset detector available, we must choose one
	odftype = ODS_ODF_RCOMPLEX;

	// Now initialise the OnsetsDS struct and its associated memory
	onsetsds_init(&ods, odsdata, ODS_FFT_FFTW3_HC, odftype, 512, 11);



	bool onset;
	while (running) {
		// Grab your 512-point, 50%-overlap, nicely-windowed FFT data, into "fftdata"

		// Then detect. "onset" will be true when there's an onset, false otherwise
		onset = onsetsds_process(&ods, fftdata);
	}
}


void Print(vector<float> onsets) {

}

float BPMFromBeats(vector<float>& beats) {
	float total = 0;
	vector<float> bpms;
	for (int i = 1; i < beats.size(); i += 1) {
		bpms.push_back(60.f/(beats[i] - beats[i - 1]));
	}
	sort(bpms.begin(), bpms.end());
	return (bpms[bpms.size() - bpms.size() / 2] + bpms[bpms.size() / 2]) / 2.0;
}

