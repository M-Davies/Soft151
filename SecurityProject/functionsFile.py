import sys
import csv
#https://www.webucator.com/how-to/how-check-the-operating-system-with-python.cfm
#accessed 11/05/19

def main():
    print(get_platform())
    toWrite = []
    aList = ['d', '4', '4']
    toWrite.append(aList)
    toWrite.append(aList)
    name = 'https://untappd.com/user/Crosswaite'
    name = name[name.rfind('/')+1:]
    writeToCsv(toWrite, name)
    name = '92895616@N06'
    name = name[:name.find('@')]
    writeToCsv(toWrite, name)

def get_platform():
    platforms = {
        'linux1' : 'Linux',
        'linux2' : 'Linux',
        'darwin' : 'OS X',
        'win32' : 'Windows'
    }
    if sys.platform not in platforms:
        return sys.platform
    
    return platforms[sys.platform]

def writeToCsv(toWrite, name):
    with open( name + '.csv', 'w', newline='') as csvFile:
        writer = csv.writer(csvFile, delimiter = ',', quotechar='"', quoting=csv.QUOTE_MINIMAL)

        writer.writerow(['Latitude','Longitude','Timestamp'])

        for item in toWrite:
            writer.writerow(item)


if __name__ == '__main__':
    main()