# WatiX-cs
## Web Application Testing with Excel and C sharp
A framework for test automation using C#, Selenium Webdriver, input from Excel, output results to a web page

## Purpose       
	- Keyword driven test harness; uses Selenium WebDriver
	- Parameters fetched from Excel file
	- Test results stored to .log file and html




**************************************************************************************************************************
##In Progress
**************************************************************************************************************************

	Log Output - 
		As a user, I want to be able to examine a log file of the processes that occurred within a test run.
	Excel Read Vars - started 9/4
		As a user, I want to have my variables on an Excel sheet, be imported into the test program.
	Output Location -
		As a user, I want the log file and web page to be put in a separate folder for each testing session, under a 
		folder "results".
	Web Page Header Info -
		As a tester, I want the html output page to include data about the test session, in a header above the 
		individual test lines.
	Web Output - started 9/11 - 
		As a user, I want to see a web page with the information and results of every test that has been run.
		I want to put these in a unique folder along with the other results of individual tests.
	

**************************************************************************************************************************
##Complete
**************************************************************************************************************************

	exec() function - done 9/17
		As a developer I want to have a string variable with a command in it, cause the execution of a method by that
		name.
    	Read Excel function - created 9/17
		As a developer I want to have the program open an Excel file, read cells from it, and close it.
	Excel Import Commands - started 9/16, done 9/17
		As a user, I want commands on the sheet be executable in the program.
	GIT - created 9/18
		As a developer I want to have a structure for saving, committing, checking in & out, and tracking, file edits
	Web Page Test Info - done 9/21
		As a tester, I want the html output page to have some meta info present on individual test lines.
	
**************************************************************************************************************************	
##Backlog
**************************************************************************************************************************

	WatiX-cs -
		As a tester I want a system that will allow me to input my C# Selenium commands, or keywords & parameters,
		that will execute a test without my having to go into C#.  I also want this to output the results to a web
		page.
	Keywords -
		As a tester I want some keywords to be simple shortcuts to the longer C#/Webdriver commands.
	Read all tests in from Excel -
		As a tester I want the program to read all the test names to execute from Excel, then run them all.
	Method locations - completed 9/17
		As a programmer I want to have my methods in a logical location, with a file for each kind - like Excel 
		methods in an Excel file	
	Web Footer -
		As a tester I want to see a footer section in the HTML output, with a number of tests passed, failed, not
		executed, etc
	Excel write script -
		As a test writer, I want Excel to generate the source code for test .cs script 
	Excel Compile
		As a test writer, I want Excel to compile the script
	Excel Execute
		As a tester, I want Excel to execute the test
