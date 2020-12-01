import os
import random
import re
import time
from bs4 import BeautifulSoup as soup

import functionsFile
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from timePrint import timePrint


def main():
    run('Crosswaite')

def run(user):
    timer = timePrint()

    usernameText = 'textuni'
    passwordText = 'password'


    url = 'https://untappd.com/'
    driver = webdriver.Firefox()
    driver.get(url + 'login')

    username = driver.find_element_by_id("username")
    password = driver.find_element_by_id("password")

    username.send_keys(usernameText)
    password.send_keys(passwordText)

    driver.find_element_by_class_name("submit-btn").click()

    user = url + 'user/' + user
    driver.get(user)

    containers = getAllContainers(driver, timer)

    containers = removeVenuelessContainer(containers)

    allData = extractData(containers, driver, url, timer)

    driver.switch_to_window(driver.window_handles[0])
    driver.close()
    driver.quit()
    #writeCSV with the username after the last /
    functionsFile.writeToCsv(allData, user[user.rfind('/')+1:]+'untap')

def extractData(containers, driver, url, timer):
    #gets time and data and returns it is a list
    visitedVenues = {}
    allData = []

    for i in containers:
        try:
            #opens each checkin from container
            #gets the location address and date string
            checkinHtml = ('https://untappd.com/user/Crosswaite' + '/checkin/' + i['data-checkin-id'])
            driver.get(checkinHtml)
            pageSoup = soup(driver.page_source, 'html.parser')
            location = pageSoup.find("p", {"class" : "location"}).a['href']
            dateString = pageSoup.find("p", {"class" : "time"})["data-gregtime"]
            structTime = time.strptime(dateString, "%a, %d %b %Y %H:%M:%S %z")

            #If the location isn't in the dictioary, it goes to the link then to google to get the lat/long
            if(location not in visitedVenues):
                driver.get(url + location)
                pageSoup = soup(driver.page_source, 'html.parser')

                mapLink = driver.find_element_by_link_text('Map')
                if (functionsFile.get_platform() == 'OS X'):
                    mapLink.send_keys(Keys.COMMAND + Keys.RETURN)
                else:
                    mapLink.send_keys(Keys.CONTROL + Keys.RETURN)

                time.sleep(10)
                driver.switch_to_window(driver.window_handles[1])

                time.sleep(10)
                curUrl = driver.current_url
                curUrl = curUrl[curUrl.find('@')+1:]
                lat = curUrl[:curUrl.find(',')]
                curUrl = curUrl[curUrl.find(',')+1:]
                lon = curUrl[:curUrl.find(',')]
                visitedVenues[location] = lat + ',' + lon
                time.sleep(random.randint(5,8))
                driver.close()
                driver.switch_to_window(driver.window_handles[0])
            else:
                latLon = visitedVenues[location]
                index = latLon.find(",")
                lat = latLon[:index]
                lon = latLon[index+1:]
            print(time.mktime(structTime))
            print(lat)
            print(lon)
            timer.printTime()
            allData.append([lat, lon, time.mktime(structTime)])
        except:
            print('error')
    return allData

def removeVenuelessContainer(containers):
    #removes containers that do not feature a venue, using a regex
    toReturn = []
    for i in containers:
        text = str(i)
        index = text.find('<a class="user"')
        text = text[index:]
        index = text.find('</p>')
        text = text[:index + 4]
        #print(text)
        pattern = r"<a class=\"user\" (href)=\"\/user\/.*?\">.*?(</a>) is drinking (a|an) (<a \1)=\"/b/.*?\">.*?\2 by \4=\"\/.*?\">.*?\2 at \4=\"\/v\/.*\">.*?\2"
        if(re.match(pattern, text)):
            toReturn.append(i)

    return toReturn

def getAllContainers(driver, timer):
    #opens th unstapped profile,
    #keeps clicked show more until the container count is equal to the new count.
    #returns the containers

    containerCount = 0

    while True:
        pageSoup = soup(driver.page_source, "html.parser")
        #finds the divs that hold the different activities
        mainS = pageSoup.find("div", {"id" : "main-stream"})
        containers = mainS.find_all("div", {"class" : "item"})
        if len(containers) == containerCount:
            break
        containerCount = len(containers)
        time.sleep(5)
        try:
            element = driver.find_element_by_id("branch-banner-iframe")
            driver.execute_script("arguments[0].style.visibility='hidden'", element) 
        except:
            print("")
        try:
            driver.find_element_by_link_text('Show More').click()
        except:
            time.sleep(random.randint(2,3))
            driver.find_element_by_link_text('Show More').click()
        time.sleep(random.randint(3,4))
        print(containerCount)
        timer.printTime()
        #break here for testing
        #break
    return containers


if __name__ == "__main__":
    main()
