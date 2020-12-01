import json
import urllib
from urllib import request
import os
from dotenv import load_dotenv
load_dotenv()

#Tests user input. Replaced with a form entry in final product
timestamp = int(input("Timestamp to base data off of:"))

if(type(timestamp) != int):
    print("Invalid input. Make sure your input is an integer")
    exit(0)

#Input dictionary. Contains data from csv files
inputDatabase =  {
            "Inputs": 
            {
                "input1":
                {
                    "ColumnNames": ["Column 0", "Latitude", "Longitude", "Timestamp"],
                    "Values": [ [ "0", "", "", timestamp ] ]
                },        
            },
        "GlobalParameters": {}
}

body = str.encode(json.dumps(inputDatabase)) #Setup data

url = 'https://ussouthcentral.services.azureml.net/workspaces/997dd3de794a451c868b442b6c620f7b/services/2d6fca6ad8074a5396097dd8465f044b/execute?api-version=2.0&details=true'
api_key = os.environ.get("lon_api_key")
headers = {'Content-Type':'application/json', 'Authorization':('Bearer '+ api_key)}

req = urllib.request.Request(url, body, headers) #Request machine learning response

try:
    response = urllib.request.urlopen(req) #Recieved

    result = response.read() #Open binary

    #Extract relevant data
    decoded = json.loads(result.decode('utf8'))
    outputData = decoded['Results']['output1']['value']['Values'].pop()
    print(outputData)
    
#Error thrown if connection fails
except urllib.error.HTTPError as error:
    print("The request failed with status code: " + str(error.code))
    print(error.info())
    print(json.loads(error.read()))