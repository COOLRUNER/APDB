# Task 5

In the course of these exercises, a simple REST API application needs to be developed, which enables operations allowing for the modification of data in an SQL Server database. selected.

1. Add an Animals controller.
2. Add a method/endpoint that allows obtaining a list of animals. The endpoint should respond to an HTTP GET request sent to `/api/animals`
- The endpoint should allow for a query string parameter that specifies sorting. The parameter is named orderBy. Example: `api/animals?orderBy=name`
- The parameter accepts the following values: name, description, category, area. Sorting can only be done by one column. The sorting is always in the "ascending" direction.
- Default sorting (when no parameter is passed in the query string) should be by the name column.
3. Add a method/endpoint allowing for the addition of a new animal.
  - The method should respond to an HTTP POST request sent to api/animals
  - The method should accept data in JSON format.
4. Add a method/endpoint allowing for the update of data for a specific animal.
- The method should respond to an HTTP PUT request sent to `/api/animals/{idAnimal}`
- The method accepts data in JSON format.
- It is assumed that primary keys do not change (IdAnimal column).
5. Add a method/endpoint for deleting data about a specific animal.
-  The method should respond to an HTTP DELETE request sent to `/api/animals/{idAnimal}`

## Additional requirements
1. Remember about correct HTTP codes.
2. Try to use the built-in Dependency Injection mechanism.
3. Ensure data validation.
4. Pay attention to naming and style.
