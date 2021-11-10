# 📝 Todos 

This is a small app for creating a todo list. The app currently has the functionality to add and read todos, however it does not have any test coverage.

There is an existing controller `TodosController.cs`. Using whichever tooling you would usually use, we'll work to get the controller under test and also implement the requirements for adding a todo below. We'll work through this for approximately 1 hour, however the goal isn't to finish and this exercise is really just meant to promote discussion about design 🙂.

There is also an automated job called `IngestTodosJob.cs`. We'll take a short look at this and read through it and discuss any design issues you can spot and how you'd go about refactoring them.

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