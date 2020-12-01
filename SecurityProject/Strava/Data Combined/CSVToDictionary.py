import csv
import os
# timestamp = int(input("Timestamp to base data off of:"))
# if(type(timestamp) != int):
#         print("Invalid input. Make sure your input is an integer")
#         exit(0)
inputData = {
    "Inputs":
            {
                "input1":
                {
                    "ColumnNames": ["Column 0", "Latitude", "Longitude", "Timestamp"],
                    "Values": [["", "", "", '1524367453']]
                },
            },
    "GlobalParameters": {}
    }

path = "C:/Users/toxic/Documents/UNIVERSITY/Year 2/SEC203 - Project/Data Combined/combinedColumnWise.csv"

r = open(path,'r')
reader = csv.reader(r)
exdict = {}
for row in reader:
    exdict[row[0]] = {'Latitude':row[1],'Longitude':row[2],'Timestamp':row[3]}
    inputData['Inputs']['input1']['Values'].append(row)
print(inputData)

