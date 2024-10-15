Municipal Services App Instructions

The local events and announcements form will show the upcoming events and announcements. The user can filter event by categories.

1.	Features

•	Local Events & Announcements: an interface that recommends events based on user searches and allows event filtering by category. 
•	Sorted Dictionary & Priority Queue: Used to categorize and handle events according to priority.
•	User-Friendly Interface: Allows users to access several services with easy use.
•	Exit Button: This button lets you quickly and fully end the application. 

2.	Requirements

•	Operating System: Windows (compatible with versions 7, 8, 10, and above)
•	Development Environment: Visual Studio 2019 or later
•	Framework: .NET Framework 4.7.2 or later
•	Languages: C#

3.	Compiling the application

Step 1: Installing Visual Studio
•	Visual Studio 2019 should be downloaded and installed if it isn't already. 

Step 2: Download the repository or clone it
•	To access the contents, clone this repository or download it as a ZIP file.
•	Go to the folder for the project.

Step 3: Launch Visual Studio and open the project.
•	Start Visual Studio first.
•	Click File > Open > Solution/Project.
•	Open the folder from where the project was extracted or copied.
•	Launch the file MunicipalServicesApp.sln.

Step 4: If required, restore the NuGet packages
•	You might see a prompt from Visual Studio to restore NuGet packages. Then select Restore.

Step 5: Construct the Project
•	Select Build > Build Solution from the Visual Studio menu.
•	Verify that the build finishes error-free.

4.	Running the application

Step 1: Launch the application.
•	To launch the program after creating the solution, click Start (or hit F5).
•	The Main Menu page will appear when the app launches.

Step 2: Using the Main Menu, you have three choices from the Main Menu:
•	Report Issues: To report problems with the municipality, go to the form.
•	Local Announcements and Events: Find, browse, and filter local announcements and events. The user's search input will determine the events the app recommends.
•	Service Request Status
•	"Exit" Button: Press this button to end the application.

Step 3: Reporting Issues: Complete the form by providing the issue's location, category, and any other relevant information in the Report Issues area.  

Step 4: Announcements and Events
•	View future events in the section titled "Local Events and Announcements." Using the dropdown menus, you may filter events by date and category.
•	You can look up events by name or category using the Search Bar. Recommendations will be given by the app depending on your search habits.

Step 5: Closing the Application
•	Click the Exit button located on the Main Menu to close the application. A confirmation prompt will appear.

5.	Application Components

Main Classes
MainMenu: The main menu contains the app's main menu.
ReportIssuesForm: Manages peoples reports of issues.
LocalEvents_AnnouncementsForm: This form shows and controls how local events are filtered, searched for, and recommended.
PriorityQueue: Controls event priority and makes sure significant events are shown clearly.
SortedDictionary: Ensures efficient retrieval and filtering by classifying events.
Event: The class that has attributes such as name, date, category, and priority, and which represents events within the app.

6.	How to Use the Local Events and Announcements Form

•	Filter by Category: To filter events according to their type, choose a category from the Category ComboBox.
•	Filter by Date: To narrow down the events that take place on a particular date, use the Date Picker.
•	Search for Events: To find events, type keywords into the search bar and press the search button.
•	View Recommendations: The Recommendation TextBox will provide similar events that have been recommended following a search.

