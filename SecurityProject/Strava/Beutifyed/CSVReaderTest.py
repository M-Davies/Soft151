import csv
import datetime
from datetime import date, datetime, timedelta
#import dateutil.parser
#from dateutil.parser import parse
import time
import calendar
import pdb
import math

dates = []

with open('24297.csv', 'r') as readFile:
    reader = csv.reader(readFile, delimiter = ',', quotechar='"', quoting=csv.QUOTE_MINIMAL)
    lines = list(reader)
    dates.append(lines[0])
    lines.pop(0)
    
    for row in lines:
        row[4] = datetime.strptime(row[4],"%Y-%m-%d %H:%M:%S%z")
        timestamp = datetime.timestamp(row[4])
        row[4] = math.floor(timestamp)
        dates.append(row)

with open('24297.csv', 'w', newline='') as writeFile:
    writer = csv.writer(writeFile)
    writer.writerows(dates)