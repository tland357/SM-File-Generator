import sys
import aubio
from numpy import median, diff

f = open("output.da","w");
f.write("BPM = ")
samplerate = 0  # use original source samplerate
hop_size = 512  # number of frames to read in one block
win_size = hop_size
path = sys.argv[1]
#path = "C:\\Users\\boovi\\Downloads\\MetaKnightsRevenge.wav"
src = aubio.source(path, samplerate, hop_size)
onset = aubio.onset("default", win_size, hop_size, samplerate)
tempo = aubio.tempo("default", win_size, hop_size, samplerate)
total_frames = 0
beats = []
onsets = []

def BeatsToBPM(beatList):
    if len(beatList) > 1:
        bpms = 60./diff(beatList)
        return median(bpms)

while True:
    samples, read = src()  # read hop_size new samples from source
    is_beat = tempo(samples)
    if is_beat:
        this_beat = tempo.get_last_s()
        beats += [this_beat]
    is_onset = onset(samples)
    if is_onset:
        this_onset = onset.get_last_s()
        onsets += [this_onset]
    total_frames += read   # increment total number of frames
    if read < hop_size:    # end of file reached
        break



f.write(str(BeatsToBPM(beats)))
f.write('\n')

f.write("Onsets = [" + str(onsets[0]))
for i in range(1,len(onsets)):
    f.write(", ")
    f.write(str(onsets[i]))
f.write(']\n')
f.write("Beats = {" + str(onsets[0]))
for i in range(1,len(beats)):
    f.write(", ")
    f.write(str(beats[i]))
f.write('}\n')
f.close()