# WatiX-cs
## Web Application Testing with Excel and C sharp
A framework for test automation using C#, Selenium Webdriver, input from Excel, output results to a web page

## Purpose       
	- Keyword driven test harness; uses Selenium WebDriver
	- Parameters fetched from Excel file
	- Test results stored to .log file and html

## Overview
* Excel file contains parameters to start the test with
* Excel VBA has macro to generate an .exe file and execute it
* The .exe file acceses functions in a .Com file which contains code to access web pages
* The .exe file opens a browser and web page and executes tests
* The results are logged and written and displayed in a web page

![logo](http://www.gluefish.com/watix/watix-flow.png "")

## Intention
We want the tester - a non-programmer - to have an Excel file that will run a test automation suite and produce an output based on some parameters he enters.  
Suites and tests need to be developed on Visual Studio, but can be called by the Excel sheet.

## Branches:  
WebAppTests - generic, using forbes-kimball-family.com as the testbed for development  
webapptests - ??
