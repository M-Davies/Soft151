import http.cookiejar as cookieLib
import random
import re
import time

import mechanize
from bs4 import BeautifulSoup as soup
from selenium import webdriver
from selenium.webdriver.common.keys import Keys

import functionsFile
from timePrint import timePrint


def main():
    run("17887076")

def run(userToRead):
    timer = timePrint()

    #setting up
    stravaWeb = "https://www.strava.com"
    driver = webdriver.Firefox()
    ### FILL IN YOUR STRAVA CREDENTIALS HERE ###
    emailText = ''
    passwordText = 'password'
    #// FILL IN YOUR STRAVA CREDENTIALS HERE #//


    loggingInSelinium(driver, stravaWeb, emailText, passwordText)
    follow(driver, stravaWeb, userToRead, "follow")

    driver.get(stravaWeb + '/dashboard')
    time.sleep(2)

    scrollToBottom(driver)

    pageSoup = soup(driver.page_source, 'html.parser')

    mainFeed = pageSoup.find("div", {"id" : "dashboard-feed"})
    links = mainFeed.find_all("div",{"class" : "activity"})

    activityLinks = []
    for link in links:
        tetime = link.find('time').find('time').string.strip()
        activityLinks.append([tetime ,stravaWeb + link.find_all('a')[2].get('href')])

    
    follow(driver, stravaWeb, userToRead, "unfollow")
    driver.close()

    for i in activityLinks:
        print(i)

    br = loggingInMech(stravaWeb, emailText, passwordText)

    for link in activityLinks:
        #to speed up debugging
        fileName = link[1][-6:-1] + '.gpx'
        br.retrieve(link[1] + '/export_gpx', link[-6:-1] + '.gpx') 
        #br.retrieve(link[1] + '/export_gpx/' + fileName)
        fileList = parsegpx(fileName)

        for i in fileList:
            i['Timestamp'] = link[0]

        time.sleep(random.randint(4,8))
        timer.printTime()


def loggingInMech(stravaWeb, emailText, passwordText):
    cj = cookieLib.CookieJar()
    br = mechanize.Browser()
    br.set_cookiejar(cj)

    #login suffix
    br.open(stravaWeb + '/login')
    #selects right form
    br.form = list(br.forms())[0]
    #adds form data
    br.form['email'] = emailText
    br.form['password'] = passwordText
    #submits
    br.submit()
    time.sleep(2)
    return br



def scrollToBottom(driver):
    #https://stackoverflow.com/questions/20986631/how-can-i-scroll-a-web-page-using-selenium-webdriver-in-python
    # Get scroll height
    last_height = driver.execute_script("return document.body.scrollHeight")

    SCROLL_PAUSE_TIME = 0.5

    while True:
        # Scroll down to bottom
        driver.execute_script("window.scrollTo(0, document.body.scrollHeight);")

        # Wait to load page
        time.sleep(SCROLL_PAUSE_TIME)

        # Calculate new scroll height and compare with last scroll height
        new_height = driver.execute_script("return document.body.scrollHeight")
        if new_height == last_height:
            break
        last_height = new_height

def follow(driver, stravaWeb, userToRead, whichButton):
    driver.get(stravaWeb + '/athletes/' + userToRead)
    time.sleep(2)

    driver.find_element_by_class_name(whichButton).click()
    time.sleep(2)

def loggingInSelinium(driver, stravaWeb, emailText,passwordText):
    driver.get(stravaWeb + '/login')
    time.sleep(2)
    username = driver.find_element_by_id("email")
    password = driver.find_element_by_id("password")

    username.send_keys(emailText)
    password.send_keys(passwordText)


    driver.find_element_by_id("login-button").click()
    time.sleep(2)


if __name__ == "__main__":
    main()
