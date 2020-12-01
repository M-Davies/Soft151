import datetime
from datetime import date
from datetime import datetime
import time

#Timestamp to datetime
timestamp = datetime.fromtimestamp(1545730073)
print("Timestamp =", timestamp)
print("type(Timestamp) =", type(timestamp))

#Datetime to string
date_time = timestamp.strftime("%Y/%m/%d, %H:%M:%S")
print("Date and time:",date_time)

#Datetime to timestamp
now = datetime.now()

dt = datetime.fromtimestamp(1545730073)
print time.mktime(dt.timetuple())

