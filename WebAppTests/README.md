# WatiX-cs
## Web Application Testing with Excel and C sharp
A framework for test automation using C#, Selenium Webdriver, input from Excel, output results to a web page

## Purpose       
	- Keyword driven test harness; uses Selenium WebDriver
	- Parameters fetched from Excel file
	- Test results stored to .log file and html


![logo](http://www.gluefish.com/watix/watix-flow.png "")

**************************************************************************************************************************
##In Progress
**************************************************************************************************************************

- [ ] Log Output:  
	As a user, I want to be able to examine a log file of the processes that occurred within a test run.
- [ ] Excel Read Vars - started 9/4:  
	As a user, I want to have my variables on an Excel sheet, be imported into the test program.
- [ ] Output Location - Started 9/21:  
	As a user, I want the log file and web page to be put in a separate folder for each testing session, under a folder "results".
- [ ] Web Page Header Info - Started 9/24:  
	As a tester, I want the html output page to include data about the test session, in a header above the individual test lines.
- [ ] Web Output - started 9/11:  
	As a user, I want to see a web page with the information and results of every test that has been run.
	I want to put these in a unique folder along with the other results of individual tests.
	

**************************************************************************************************************************
##Complete
**************************************************************************************************************************

- [x] exec() function - done 9/17:  
	As a developer I want to have a string variable with a command in it, cause the execution of a method by that name.
- [x] Read Excel function - created 9/17:  
	As a developer I want to have the program open an Excel file, read cells from it, and close it.
- [x] Excel Import Commands - started 9/16, done 9/17:  
		As a user, I want commands on the sheet be executable in the program.
- [x] Method locations - completed 9/17:  
		As a programmer I want to have my methods in a logical location, with a file for each kind - like Excel 
		methods in an Excel file	
- [x] GIT - created 9/18:  
		As a developer I want to have a structure for saving, committing, checking in & out, and tracking, file edits
- [x] Web Page Test Info - done 9/21:  
		As a tester, I want the html output page to have some meta info present on individual test lines.
	
**************************************************************************************************************************	
##Backlog
**************************************************************************************************************************

- [ ] WatiX-cs:  
		As a tester I want a system that will allow me to input my C# Selenium commands, or keywords & parameters,
		that will execute a test without my having to go into C#.  I also want this to output the results to a web
		page.
- [ ] Keywords:  
		As a tester I want some keywords to be simple shortcuts to the longer C#/Webdriver commands.
- [ ] Read all tests in from Excel:  
		As a tester I want the program to read all the test names to execute from Excel, then run them all.
- [ ] Web Footer:  
		As a tester I want to see a footer section in the HTML output, with a number of tests passed, failed, not
		executed, etc
- [ ] Excel write script:  
		As a test writer, I want Excel to generate the source code for test .cs script 
- [ ] Excel Compile:  
		As a test writer, I want Excel to compile the script
- [ ] Excel Execute:  
		As a tester, I want Excel to execute the test
- [ ] Program Error Handling:  
		As a tester, I want all functions and tests wrapped in try-catch traps, with the error echoed in the output
- [ ] Excel Execute:  
		As a tester, I want to have the program execute all the tests marked as "test" in the spreadsheet
		
###Research

- [ ] Try to make a DLL of the WebAppUtils, ExcelUtils, and WebPageUtils - executable by an .exe Program.exe  
- 10/1 Built a simple sample dll, executed it from Program.
- [x] 9/27 Built a compile from command line .exe = see foo.bar
- [x] 9/28 Built a batch file to compile foo.bar into foobar.exe and execute it 
- [x] 9/28 Executed the compile, executed the result .exe, from the Excel immediate window  
	shell “cmd.exe /k cd “ & thisworkbook.path & “&& foobar.bat”  
(added a System.Console.ReadLine(); to the foo.bar to pause the execution)

###Comment: 
9/28 - For a csc compile to work - you have to generate the csc code from vs to get all the references.  
  * This is a huge amount of text - best to put it ina batch file.  
  * The csc.exe has to be quoted because of the space in "program files".  
  * Also, at the end, need to add /out:yourappname.exe.  This solution worked today. 
  * Test: make a change to the program.cs, run the batch, run the exe, check for change.  
  * Result: Passed.  I added a couple of comments output to console, saved program.cs, ran the batch, 
  ran the exe, the resulting console had the comments displayed.  
  * 10/7: Merging all the loose pieces
