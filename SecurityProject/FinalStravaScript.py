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

#####EXTRACTION SECTION#####

#Parses gpx to csv style
def parsegpx(filename):
   print("# Parsing file: -",filename)
   points2 = list()
   with open(filename, 'r') as gpxdata:
       print("# "+filename," - Loading")
       gpx = gpxpy.parse(gpxdata)
       print("# "+filename," - Parsing")
       for track in gpx.tracks:
           for segment in track.segments:
               for point in segment.points:
                   dict = {'Timestamp': point.time,
                           'Latitude': point.latitude,
                           'Longitude': point.longitude,
                           'Elevation': point.elevation
                           }
                   points2.append(dict)
               return points2
           
stravaWeb = "https://www.strava.com"

cj = cookieLib.CookieJar()
br = mechanize.Browser()
br.set_cookiejar(cj)
print("# Strava site - Loading")
br.open(stravaWeb + '/login')
br.form = list(br.forms())[0]
print("# Strava site - Signing in")
### FILL IN YOUR STRAVA CREDENTIALS HERE ###
br.form['email'] = ''
br.form['password'] = 'password'
#// FILL IN YOUR STRAVA CREDENTIALS HERE #//
br.submit()
print("# Strava site - Accessing athlete")
pageHtml = br.open('https://www.strava.com/athletes/39831556')
print("# Strava site - Parsing athlete page")
pageSoup = soup(pageHtml, "html.parser")
containers = pageSoup.findAll("div", {"class" : "activity entity-details feed-entry"})
activityLinks = []

for i in containers:
   activityLinks.append(stravaWeb + i.find("a", {"class" : "entry-image activity-map"})['href'])

for i in activityLinks:
   #br.retrieve(i + '/export_gpx', i[-6:-1] + '.gpx')  #doesn't actually get the files atm to reduce load, uncomment for actual use
   filename = i[-6:-1] + ".gpx"
   print("# Strava site - Downloading file : ", filename)
   print("## Download complete")
   print("# "+filename," - Converting contents to DataFrame")
   df2 = pd.concat([pd.DataFrame(parsegpx(filename))])
   #print(df2.head(5))    #prints out a preview of the file, only shows first 5 lines
   print("# "+filename," - Storing DataFrame as .csv \n")
   df2.to_csv(filename[:-4]+".csv")



#Convert datetimes to timestamps
dates = []

with open("24297.csv", 'r') as readFile:
   reader = csv.reader(readFile, delimiter = ',', quotechar='"', quoting=csv.QUOTE_MINIMAL)
   lines = list(reader)
   dates.append(lines[0])
   lines.pop(0)

   for row in lines:
       print(row[4])
       row[4] = datetime.strptime(row[4],"%Y-%m-%d %H:%M:%S%z")
       timestamp = datetime.timestamp(row[4])
       row[4] = math.floor(timestamp)
       dates.append(row)

   
with open("24297.csv", 'w', newline='') as writeFile:
   writer = csv.writer(writeFile)
   writer.writerows(dates)
    
print("## Extraction Script complete ##")

#####MACHINE LEARNING SECTION#####
#Predictor Function
def Predictor(url, api_key, inputData, timestamp):
    body = str.encode(json.dumps(inputData)) # Setup data
    headers = {'Content-Type': 'application/json','Authorization': ('Bearer ' + api_key)}

    # Request machine learning response
    req = urllib.request.Request(url, body, headers)

    try:
        response = urllib.request.urlopen(req)  #Recieved

        result = response.read()  # Open binary

        #Extract relevant data
        decoded = json.loads(result.decode('utf8'))
        outputData = decoded['Results']['output1']['value']['Values'].pop(0)
        return outputData

    #Error thrown if connection fails
    except urllib.error.HTTPError as error:
        print("The request failed with status code: " + str(error.code))
        print(error.info())
        print(json.loads(error.read()))

#Globals
lat_url = 'https://ussouthcentral.services.azureml.net/workspaces/997dd3de794a451c868b442b6c620f7b/services/abb1abca5fc84e9095d1640f2cbe0173/execute?api-version=2.0&details=true'
lat_api_key = os.environ.get("lat_api_key")
lon_url = 'https://ussouthcentral.services.azureml.net/workspaces/997dd3de794a451c868b442b6c620f7b/services/2d6fca6ad8074a5396097dd8465f044b/execute?api-version=2.0&details=true'
lon_api_key = os.environ.get("lon_api_key")

###Tests user input. Replaced with a form entry in final product###
timestamp = int(input("Timestamp to base data off of:"))
if(type(timestamp) != int):
        print("Invalid input. Make sure your input is an integer")
        exit(0)

#Input dictionary. Contains data from csv files. Final product will scan the files from above
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
path = "C:/Users/toxic/Documents/UNIVERSITY/Year 2/SEC203 - Project/Data Combined/combinedColumnWise.csv"

r = open(path,'r') #Open and read 
reader = csv.reader(r)
for row in reader:
    inputData['Inputs']['input1']['Values'].append(row) #Append data from csv to learning input

inputData['Inputs']['input1']['Values'].pop(1) #Pop off column names

print(Predictor(lat_url, lat_api_key, inputData, timestamp)) #Run predictor for lat
print(Predictor(lon_url, lon_api_key, inputData, timestamp)) #Run predictor for lat