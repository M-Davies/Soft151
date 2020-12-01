import http.cookiejar as cookieLib
import requests
import mechanize
from bs4 import BeautifulSoup as soup
import    gpxpy
import os
import pandas as pd

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

print("## Script complete ##")
