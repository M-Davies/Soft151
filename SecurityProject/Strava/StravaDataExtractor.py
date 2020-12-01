import http.cookiejar as cookieLib
import requests

import mechanize
from bs4 import BeautifulSoup as soup

#sets root website, if using subdomains change
stravaWeb = "https://www.strava.com"

cj = cookieLib.CookieJar()
br = mechanize.Browser()
br.set_cookiejar(cj)

#login suffix
br.open(stravaWeb + '/login')
#selects right form
br.form = list(br.forms())[0]
#adds form data
### FILL IN YOUR STRAVA CREDENTIALS HERE ###
br.form['email'] = ''
br.form['password'] = 'password'
#// FILL IN YOUR STRAVA CREDENTIALS HERE #//
#submits
br.submit()

#opens the users own page
#TODO: make this automatic
pageHtml = br.open('https://www.strava.com/athletes/39831556')
#Soups it
pageSoup = soup(pageHtml, "html.parser")
#finds the divs that hold the different activities
containers = pageSoup.findAll("div", {"class" : "activity entity-details feed-entry"})
activityLinks = []

#adds each link to a list
for i in containers:
    activityLinks.append(stravaWeb + i.find("a", {"class" : "entry-image activity-map"})['href'])


#downloads each file
for i in activityLinks:
    br.retrieve(i + '/export_gpx', i[-6:-1] + '.gpx')
