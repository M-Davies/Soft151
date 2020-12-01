import calendar
import csv
import datetime
import http.cookiejar as cookieLib
import json
import math
import os
import pdb
import time
import urllib
from datetime import date, datetime, timedelta
from urllib import request
from dotenv import load_dotenv
load_dotenv()

import gpxpy
import mechanize
import pandas as pd
import requests
from bs4 import BeautifulSoup as soup

#Predictor Function
def Predictor(url, api_key, inputData, timestamp):
    body = str.encode(json.dumps(inputData)) # Setup data
    headers = {'Content-Type': 'application/json','Authorization': ('Bearer ' + api_key)}

    # Request machine learning response
    req = urllib.request.Request(url, body, headers)

    try:
        response = urllib.request.urlopen(req)  #Recieved

        result = response.read() #Open binary

        #Extract relevant data
        decoded = json.loads(result.decode('utf8'))
        outputData = decoded['Results']['output1']['value']['Values'].pop(0)
        return outputData

    #Error thrown if connection fails
    except urllib.error.HTTPError as error:
        print("The request failed with status code: " + str(error.code))
        print(error.info())
        print(json.loads(error.read()))

###MAIN START###
#Globals
lat_url = 'https://ussouthcentral.services.azureml.net/workspaces/997dd3de794a451c868b442b6c620f7b/services/abb1abca5fc84e9095d1640f2cbe0173/execute?api-version=2.0&details=true'
lat_api_key = os.environ.get("lat_api_key")
lon_url = 'https://ussouthcentral.services.azureml.net/workspaces/997dd3de794a451c868b442b6c620f7b/services/2d6fca6ad8074a5396097dd8465f044b/execute?api-version=2.0&details=true'
lon_api_key = os.environ.get("lon_api_key")

###Tests user input. Replaced with a form entry in final product###
timestamp = int(input("Timestamp to base data off of:"))
if(type(timestamp) != int):
        print("Invalid input. Make sure your input is an integer")
        print("Exiting...")
        exit(0)

#Input dictionary. Contains data from csv files. Final product will scan csv file#
inputData = {
    "Inputs":
            {
                "input1":
                {
                    "ColumnNames": ["Column 0", "Latitude", "Longitude", "Timestamp"],
                    "Values": [["0", "", "", timestamp]]
                },
            },
    "GlobalParameters": {}
    }

#Insert big csv or gpx file here containing the location data
path = "C:/Users/Stephen/Documents/UNIVERSITY/Year 2/SEC203 - Project/17887076.csv"

r = open(path,'r') #Open and read 
reader = csv.reader(r)
for row in reader:
    inputData['Inputs']['input1']['Values'].append(row) #Append data from csv to learning input

inputData['Inputs']['input1']['Values'].pop(1) #Pop off column names

latPredict = Predictor(lat_url, lat_api_key, inputData, timestamp) #Run predictor for lat
lonPredict = Predictor(lon_url, lon_api_key, inputData, timestamp) #Run predictor for lon

#Change accuracy to float value
float(latPredict[1])
float(lonPredict[1])

#Use highest accuracy for output
if(latPredict[1] > lonPredict[1]):
    accuracy = latPredict[1]
else:
    accuracy = lonPredict[1]

#Print out
print("Latitude Prediction = %s.\nLongitude Prediction = %s.\nAccuracy = %s.\n" % (latPredict[0], lonPredict[0], accuracy))
print("## Prediction Script Complete ##\n")