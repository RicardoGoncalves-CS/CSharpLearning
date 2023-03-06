[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 1 repository

This folder contains the following subfolders:
- 1_Markdown
- 2_Shell

\n
### Subfolders description:

## **1_Markdown**

Contains a file named *ExampleMarkdown.md* which is a file containing some useful syntax to format text using markdown.

## **2_Shell**

Contains some files created to test and experiment with Powershell commands.

**NOTE**: to give temporary permission to execute a Powershell script we can use _**set-ExecutionPolicy -scope process -executionPolicy unrestricted**_

The files contained in this folder are:

- ExampleScript.ps1
- MyShellScript.ps1
- gcm-date.txt

### *ExampleScript.ps1*

This script was provided as an example during the Powershell scripting lesson.

### *MyShellScript.ps1*

This script is the result of an exercise to create my own shell script.

*Description*

I like to have my Desktop folder as clean as possible but often I find myself with many files in it as I use it as easy-to-access space where I can dump files I'm currently working on, and as a result it often gets "polluted" with all kind of files.

This script aims to help me keep my Desktop tidy by moving all the files that are currently in the Desktop folder to a new location in order to be properly organized later on.

This is achieved by moving all the files and folders in the Desktop folder to ~\Documents\Organize\ and then to a folder name with the date in which the operation was performed.

### *gcm-date.txt*

This file is the result of an exercise performed during the Powershell lesson where the objective was to find the commands to work with dates and output the result to a text file.

To achieve this result the following command can be user: get-command -Noun "date" > gcm-date.txt
