import random
import re
import time

from bs4 import BeautifulSoup as soup

import functionsFile
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from timePrint import timePrint


def main():
    run("92895616@N06")

def run(userToRead):
    timer = timePrint()

    #setting up
    loginUrl = 'https://identity.flickr.com/'
    url = 'https://www.flickr.com'
    photosUrl = url + '/photos/'
    driver = webdriver.Firefox()
    usernameText =  "simela@the-first.email"
    passwordText = "passwordpass"


    driver.get(loginUrl)
    loggingIn(driver, usernameText, passwordText, photosUrl, userToRead)

    allData = webScraping(driver, timer)

    functionsFile.writeToCsv(allData, userToRead[:userToRead.find('@')]+'flikr')

def webScraping(driver, timer):
    #clicks though all photos and takes gps and time
    allData = []
    failCount = 0
    while True:
        time.sleep(random.randint(6,9))

        try:
            pageSoup = extractData(driver, allData)

        except:
            #if not the right data avalible fails.
            print("unparsable data")
        try:
            failCount = loadNextPage(pageSoup, driver, timer, failCount)
        except:
            #lets the load fail a couple of times before counting it as reaching the end.
            if failCount == 3:
                break
            else:
                failCount += 1
                time.sleep(10)
                continue

    driver.close()
    return allData

def loadNextPage(pageSoup, driver, timer, failCount):
    nextUrl = pageSoup.find("a", {"class": "navigate-next"})['href']
    driver.get(nextUrl)

    timer.printTime()

    failCount = 0
    return failCount

def extractData(driver, allData):
    pageSoup = soup(driver.page_source, "html.parser")
    latLon = pageSoup.find("a", {"class" : "static-maps"})['href']
    lat = latLon[latLon.find("?fLat=")+6:latLon.find("&")]
    lon = latLon[latLon.find("&fLon=")+6:]
    lon = lon[:lon.find("&")]

    #'\n\t\t\t\tTaken on May 1, 2019\n\t\t'
    picDate = pageSoup.find("span", {"class" : "date-taken-label"}).text.strip()[9:]
    #'May 1, 2019'

    driver.find_element_by_class_name("show-extended-exif").click()
    time.sleep(2)
    pageSoup = soup(driver.page_source, "html.parser")

    exifData = str(pageSoup.find("div", {"class": "exif-column-1"}))
    startI = exifData.find("GPS Time Stamp - ")+50
    #12:15:54
    picTime = exifData[startI:startI+8]

    dateString = picDate + ' ' + picTime

    #May 1, 2019 12:15:54
    structTime = time.strptime(dateString, "%B %d, %Y %H:%M:%S")

    print(time.mktime(structTime))
    print(lat)
    print(lon)

    allData.append([lat, lon, time.mktime(structTime)])
    return pageSoup

def loggingIn(driver, usernameText, passwordText, photosUrl, userToRead):
    time.sleep(1)

    username = driver.find_element_by_id("login-email")
    username.send_keys(usernameText)
    driver.find_element_by_class_name("mt-5").click()

    time.sleep(2)

    driver.find_elements_by_class_name("orko-button-primary")
    driver.find_element_by_id("login-signin").click()

    time.sleep(2)

    password = driver.find_element_by_id("login-passwd")
    password.send_keys(passwordText)

    driver.find_element_by_id("login-signin").click()

    driver.get(photosUrl + userToRead)
    driver.find_element_by_class_name("overlay").click()

if __name__ == "__main__":
    main()
