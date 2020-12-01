import time
import math

class timePrint():

    def __init__(self):
        self.start = time.time()

    def printTime(self):
        timeSoFar = math.floor(time.time() - self.start)

        mins = timeSoFar // 60
        seconds = timeSoFar % 60
        print(f"So far: {mins} : {seconds:02}")