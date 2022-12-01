# Project Overview
This repo contains the semester project for team 2, section 001 of CSCI-4250 for the Fall 2022 semester. It is an implementation of phase 1 of the BucHunt concept, a scavenger hunt application that uses a client-server architecture to allow users to join scavenger hunts, complete tasks, and track their progress. We built the app in ASP.NET using a model-view-controller pattern and it persists data to a SQLServerExpress database. The app uses Entity Framework to interface with the database and to create the necessary database tables from the defined models.


#Migrations
- ApplicationDbContextModelSnapshot: Migrates database into application


# Models
- BucHunt: Represents a Hunt with a collection of people in it.
- HuntTask: Models tasks which are tied to a location.
- Location: Models a location in a hunt with a collection of tasks.
- Person: Models a person in a hunt with ties to hunt and tasks.
- PersonHuntTask: Associates a single instance of a person to a single instance of a task


# Views
- BucHunt
  - Details: Displays the details of each hunt and allows them to be edited.
  - GetListOfTasks: Displays all the tasks associated with a specific player.
  - Index: Displays a list of all available hunts and allows new hunts to be added.
  - Players: Displays a list of all registered players.
  - Register: Displays an input box where a user can input their phone number to register.


- Home
  - Index: Displays a basic homepage
  - Privacy: auto-generated/unchanged
  - Tasklist: Displays a list of all available tasks and allows tasks to edited or deleted


# Controllers
- BucHuntController
  - Index(): Returns the Index view.
  - Details(int id): Returns the Details view depending on the given id.
  - Register(): Returns the Register view.
  - Register(string phonenumber): Registers a phone number in the database and redirects to the Players method.
  - Players(): Returns the Players view.
  - GetListOfTasks(string Id): Returns the GetListOfTasks view after reading a list of tasks for the person with the given Id.
- HomeController: auto-generated/unchanged


# Services
-ApplicationDBContext: Service which allows the Repositories to be injected and interact with the T-Sql.


-DBBucHuntRepository: Contains the methods which are called upon by the interface
* ReadAsync(int id) : Reads a location from the db using an Id
* CreateAsync(Location location): creates a location in the db by taking a location input
* ReadAllAsync(): reads all locations from the database
* CreateTaskAsync(int locationId, HuntTask huntTask): adds a task to a specified location by ID
* ReadAsync(string huntId): reads a hunt from the db using an id
* ReadPerson(string phoneNumber): reads a person from the db using our specified PK of phone number.
* CreatePerson(Person person): adds a person to the db with specific phone number
* IsValidPhoneNumber(string input): regex checker to ensure the phone number is valid
* AddPersonToHunt(string huntId, string phoneNumber): adds the person into a buchunt as long as they are not already in it.
* ReadAllPeople(): reads all people from the db


-IBucHuntRepository: Calls upon methods from DBBucHuntRepository, If you need to make a new method you need to make sure to add it here first.


-AppSettings.json: Sets up the connection string for the server don't touch unless you want to create a new database.


- Program.cs: Sets up services and middleware, and starts the application.




Scrum Master Responsibilities:
First and foremost, from day one it is up to the SM to establish each of the team member’s understanding of the process and purpose of Scrum. 
To ensure each Sprint event that takes place is a positive experience.
Encourage your team members with a positive uplifting attitude.
Keep up with the conversation, if it begins to drift off topic or to issues that are not related to your team’s Sprint Goal, then it is up to you to redirect the conversation back on topic.
Coach the team members in self-management and cross-functionality.
Causing the removal of impediments to the Scrum Team’s progress.
Make sure everyone is getting the option to speak their opinion on what they feel should be done (Reminder: there is no “leader” in Scrum. You want this to be a smooth, agile, and an adapting process. Everyone is working at the same level towards the same goal to complete a Sprint one at a time. This requires a lot of communicating between all members: the Scrum Master, Product Owner, and Development Team).
You want your team to have a good understanding of: 
Scrum vocabulary (Agile, User Story, Sprint Goal, Done [Which, you are the team will define the definition of what done will look like for you all], Sprint Backlog, Grooming, etc).
Along with what the roles entail (Scrum Master, Product Owner, and Development Team). It is best to explain all of these upfront, so you can ensure everyone understands their responsibilities.
The order of steps to take to complete a Sprint.
The purpose for each step in the Sprint (why you are doing each step and the purpose it holds, how long it should take, what is to be done in that time frame, etc.).
