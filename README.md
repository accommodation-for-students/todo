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

## Endpoints

You can retrieve all todos by doing a `GET` to `http://localhost:5000/api/todos`.

You can create a todo by doing a `POST` to `http://localhost:5000/api/todos`:

```
{
    "title": ".NET 6 is available!",
    "description": "Have a look at what's new in C# 10.",
    "completed": true
}
```