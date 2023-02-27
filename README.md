# README for Sparta Repository

This repository is part of Sparta Tech 205 training and will be updated on an ongoing basis.

The objective of this repository is to store the various projects part of Tech 205 training.

The repo contains folders pertaining to each week of the training and named accordingly to the week each of those folders refer to.


## Week 1 Business Week

This folder contains the following folders:

- MarkdownTest
- Shell

### MarkdownTest

Contains a file named *ExampleMarkdown.md* which is a file containing some useful syntax to format text using markdown.

### Shell

Contains some files created to test and experiment with Powershell commands.

**NOTE**: to give temporary permission to execute a Powershell script we can use _**set-ExecutionPolicy -scope process -executionPolicy unrestricted**_

The files contained in this folder are:

- ExampleScript.ps1
- MyShellScript.ps1
- gcm-date.txt

#### *ExampleScript.ps1*

This script was provided as an example during the Powershell scripting lesson.

#### *MyShellScript.ps1*

This script is the result of an exercise to create my own shell script.

*Description*

I like to have my Desktop folder as clean as possible but often I find myself with many files in it as I use it as easy-to-access space where I can dump files I'm currently working on, and as a result it often gets "polluted" with all kind of files.

This script aims to help me keep my Desktop tidy by moving all the files that are currently in the Desktop folder to a new location in order to be properly organized later on.

This is achieved by moving all the files and folders in the Desktop folder to ~\Documents\Organize\ and then to a folder name with the date in which the operation was performed.

#### *gcm-date.txt*

This file is the result of an exercise performed during the Powershell lesson where the objective was to find the commands to work with dates and output the result to a text file.

To achieve this result the following command can be user: get-command -Noun "date" > gcm-date.txt


## Week 2

This folder contains the following folders:

- UsingVisualStudio

### UsingVisualStudio

This folder was created as a test to explore how to use some Visual Studio features and how to use the terminal inside Visual Studio to work with git.
