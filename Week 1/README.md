[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 1 Notes

1. [Spartan Skills](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%201#1-spartan-skills)
2. [Git](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%201#2-git)
3. [Markdown](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%201#3-markdown)
4. [PowerShell](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%201#4-powershell)
5. [Agile & Scrum](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%201#5-agile--scrum)

### 1. Spartan Skills

Spartan skills cover the necessary consultancy skills to succeed as a Sparta C# consultant. 

On this topic we learned about the importance of soft skills, how we are going to be accessed throughout the training and interviewing preparation.

The Spartan skills to be accessed are divided into consultant and technical skills and can are broken down into the following behaviours:
-	*Communication*
-	*Engagement*
-	*Professionalism*
-	*Delivery*

We also learned and trained our elevator pitch to be used as a short and concise introduction of ourselves, and covered common interview questions which include:
-	Tell me about yourself. (Elevator pitch)
-	Where do you see yourself in 5 years’ time?
-	Why did you choose Sparta Global?
-	Why do you want to be a C# SDET/DEV?
-	What is your greatest strength/weakness? What are you doing to improve/overcome it?
-	What qualities are needed to succeed as a C# SDET/DEV and how have you developed/shown them?
-	Tell me about a time where you had a tight deadline to complete something.
-	What makes you excited to work for ASOS/Sky/Deloitte? (Or whichever company you are being interviewed by)
-	Tell me about a time you had a disagreement.

 [Unpacking Interview Questions – Jacob Kaplan-Moss]( https://jacobian.org/series/unpacking-interview-questions/)

### 2. Git

Git is a free and open-source Version Control System (VCS) which allows developers to keep track of changes made to their codebase, collaborate with other developers on the same project, and easily roll back to previous versions of their code if needed.

Git uses repositories (or “repo”) which is a collection of files, directories, and version history. Repositories are where all the files for a project are stored, including metadata that tracks the changes to those files over time. It works by creating snapshots (or “commits”) of the codebase at different points in time. Git supports branching allowing developers to create parallel versions (fork) of the codebase, make changes independently and merge back to the main branch when ready.

There are 3 main “zones” in a repository:
-	*Working directory*: The directory on a developers computer where they are actively working. It contains the current version of the files in the project.
-	*Staging area*: Intermediate stage that contains the changes that are ready to be committed but have not yet been saved to the repository.
-	*Local repository*: Where the committed changes are stored. It is where branches are managed, and contains the history of all the committed changes which can be viewed by the project developers.

We can interact with Git by using the Git CLI Git bash.

Some important commands to remember are:
- **git init** :  initialises a git repository in the current working directory.
- **git add [file]** : add [file] to the staging area.
- **git add .** : add all modified files in the working directory to the staging area.
- **git commit -m “message”** : commits all the staged files to the repository.
- **git status** : display the current changes in the repository.

In addition to Git there is also GitHub which is a free cloud Git service that provides Git functionalities remotely in an easy-to-use GUI, allowing to work on the files in our repository from anywhere as long as we have access to the internet.
 
GitHub can be used independently or in combination to our local git repository, providing its remote repository capabilities. This allows the developers to store their local repository content in their remote repository and vice-versa.
 
Some important commands to interact with the GitHub repository:
- **git remote add origin [URL]** : set a new remote repository.
- **git remote set-url origin [URL]** : change the remote repository.
- **git remote -v** : verify the remote repository URL.
- **git push [remote-name] [remote-branch]** : push local change to the remote repository.
- **git pull [remote-name] [remote-branch]** : pull remote changes to the local repository.
- **git clone [URL]** : copy a remote repository to a local repository in the current working directory.

The commands above are just a few useful commands to work with git and GitHub. For an extensive list and description of git commands we must refer to the [official documentation](https://git-scm.com/docs).
 
Git also uses a very useful file named .gitignore which informs git which files it must ignore. This file should be used to guarantee that unnecessary files and files containing sensitive information are not stored in the git repository.
 
[gitignore documentation](https://git-scm.com/docs/gitignore)

### 3. Markdown

Markdown is a markup language used to format text and is widely used for writing documentation, README files, and other content on the web as it is easily converted into HTML or other formats.
 
During our training we learned the syntax to format text which is being used to create all the README files in my repository.
 
The file created during this lesson can be found [here]( https://github.com/RicardoGoncalves-CS/Sparta/blob/main/Week%201/1_Markdown/ExampleMarkdown.md).

### 4. PowerShell

A shell is a program that serves as an interface to access the services and functions provided by the operating system.
 
PowerShell is a command-line shell and scripting language developed by Microsoft for managing and automating Windows operating systems and applications.
 
Some important PowerShell commands:
- **pwd** : prints the path of the current working directory.
- **ls** : lists the files and directories in the current working directory.
- **cd [directory]** : change directory to [directory].
- **cd ..** : change directory to the parent directory of the current working directory.
- **md [name]** : create a new directory named [name].
- **cp [file] [directory]** : copy [file] to directory [directory].
- **mv [file] [directory]** : move [file] to directory [directory].
- **del [file]** : deletes [file].
 
[More PowerShell commands](https://devblogs.microsoft.com/scripting/table-of-basic-powershell-commands/)

PowerShell ISE (Integrated Scripting Environment) is an IDE that provides a GUI designed to help users develop and debug PowerShell scripts more easily.

Find the files created during this lesson [here](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%201/2_Shell).

### 5. Agile & Scrum
  
***Agile***
 
Agile is a project management methodology that emphasizes flexibility, collaboration, continuous improvement and is based on a set of values and principles outlined in the Agile Manifesto, which are:
-	Individuals and interactions over processes and tools.
-	Working software over comprehensive documentation.
-	Customer collaboration over contract negotiation.
-	Responding to change over following a plan.
 
These Agile values are supported by 12 Agile principles:
1.	Our highest priority is to satisfy the customer through early ad continuous delivery of valuable software.
2.	Welcome changing requirements, even late in development. Agile processes harness change for the customer’s competitive advantage
3.	Deliver working software frequently.
4.	Businesspeople and developers must work together daily throughout the project.
5.	Build projects around motivated individuals. Give them the environment and support they need and trust them to get the job done.
6.	The most efficient and effective method of conveying information to and within a development team is face-to-face conversation.
7.	Working software is the primary measure of progress.
8.	Agile processes promote sustainable development. The sponsors, developers, and users should be able to maintain a constant pace indefinitely.
9.	Continuous attention to technical excellence and food design enhances agility.
10.	Simplicity – the art of maximizing the amount of work not done is essential.
11.	The best architectures, requirements, and designs emerge from self-organizing teams.
12.	At regular intervals, the team reflects on how to become more effective, then tunes and adjusts its behaviour accordingly.
 
Agile projects are typically executed in short iterations called sprints during which a cross-functional team works together to deliver a working product or feature that meets the customer's needs. 
 
The team meets regularly to review progress, identify problems, and make adjustments as needed.
 
Agile emphasizes communication, collaboration, and teamwork, and it encourages continuous feedback and learning. Agile teams are self-organizing and cross-functional, and they are empowered to make decisions and take ownership of their work.
  
***Scrum***
 
Scrum is a specific Agile framework and is commonly used in software development.
 
The three pillars of Scrum:
-	*Transparency*: Everyone presents the facts as it is and collectively collaborate for the common organizational objectives. No one has a hidden agenda.
-	*Inspection*: Not done by an inspector but by everyone on the Scrum team. The inspection can be done for the product, processes, people aspects, or practices.
-	*Adaptation*: Adaptation is about continuous improvement, to adapt based on the results of the inspection. Everyone should reflect on how to improve.

Scrum is based on a set or roles, events, and artifacts.
 
**Scrum roles**:
-	*Product Owner*: responsible for defining and prioritizing the product backlog and ensuring that the team is building the right product.
-	*Scrum Master*: responsible for facilitating the Scrum process, removing impediments, and coaching the team.
-	*Development Team*: responsible for building the product and delivering working increments of the product at the end of each sprint.
 
**Scrum events**:
-	*Sprint Planning*: at the beginning of each sprint, the team meets to plan the work that will be done during the sprint.
-	*Daily Scrum*: a brief meeting held every day to synchronize the team's work and plan the day's activities.
-	*Sprint Review*: at the end of each sprint, the team presents the work that was completed during the sprint and receives feedback from stakeholders.
-	*Sprint Retrospective*: a meeting held after each sprint to reflect on the team's performance and identify opportunities for improvement.
 
**Scrum artifacts**:
-	*Product Backlog*: a prioritized list of features and requirements that the team will work on during the project.
-	*Sprint Backlog*: a subset of the product backlog that the team will work on during a specific sprint.
-	*Increment*: a working product or feature that is delivered at the end of each sprint.

*Other important concepts in Scrum*:
  
**User stories**
 
User stories are a simple and effective way to communicate requirements and define the scope of a project, provide a customer-focused approach to development, and typically follow a simple format such as "As a [user], I want [feature/requirement], so that [benefit/value]."
 
They can be written by anyone in the Scrum team, but the Product Owner is responsible to put them into the backlog. The goal is to capture the user's needs and expectations in a simple and understandable format that can be easily communicated to the Development Team.
 
User stories should be:
-	Independent
-	Negotiable
-	Valuable
-	Estimable
-	Small
-	Testable
 
We can personas (fictitious groups of people we want to target or will use the product) to understand their perspective.

**Epic**
 
An epic is a large body of work that is too big to be completed in a single sprint or iteration. Epics are typically divided into smaller, more manageable user stories, which can be worked on and completed within a single sprint.
User stories are often used to determine the acceptance criteria.
  
**Acceptance criteria**
 
Acceptance criteria are a set of conditions or requirements that must be met in order for a user story or feature to be considered complete and accepted by the Product Owner. They are a way to define the specific functionality or behaviour that is expected of a user story, and are used to ensure that the development work meets the needs and expectations of the stakeholders.
 
Acceptance criteria are used to guide the Development Team in building the product, and they provide a way to measure the completeness and quality of the work.

**Gherkin Scenarios**
 
A Gherkin scenario is a structured way of describing the behaviour of a software system in plain language, using a specific syntax called the Gherkin language. Gherkin is a format for specifying software requirements, acceptance criteria, and automated tests.
 
A Gherkin scenario is typically written in a Given-When-Then format and describes a specific behaviour or interaction of the system. The format is as follows:
-	*Given*: A set of preconditions or initial context that must be satisfied before the behaviour can occur.
-	*When*: The action or event that triggers the behaviour of the system.
-	*Then*: The expected outcome or result of the behaviour.

Gherkin scenarios are often used to document requirements and acceptance criteria in a way that is easily understandable by both technical and non-technical stakeholders.

**Definition of Ready**
 
Definition of Ready is a checklist of criteria that must be fulfilled before a user story is considered ready to be worked on by the Development Team. It is a formal agreement between the Product Owner and the Development Team that helps to ensure that the user story is well-defined, understood, and estimated before the development work begins.

**Definition of Done**
 
Definition of Done is a checklist of criteria that must be fulfilled before a user story or feature can be considered completed and ready for release. It is a formal agreement between the Development Team and the Product Owner that helps to ensure that the work meets the quality standards and is ready for release.
