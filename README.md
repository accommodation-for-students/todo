# 📝 Todos 

This is a small app for creating a todo list. The app currently has the functionality to add and read todos, however it does not have any test coverage.

There is an existing controller `TodosController.cs`. Using whichever tooling you would usually use, we'll work to get the controller under test and also implement the requirements for adding a todo below.

## Requirements

- Title can't be longer than 50 characters
- Title can't be empty
- Title can't contain HTML or scripts
- Description can't be empty
- Description can't contain HTML or scripts
- Get todos ordered by created date descending