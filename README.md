# MovieDatabaseAPI

Create an [ASP.NET](http://ASP.NET) Core API that allows you to add, edit, delete, and search for movies.

### The movie must have the following fields:

- Name (required field. Maximum length 200 characters)
- short description (mandatory field. maximum length 2000 characters)
- Release year (required field)
- director (required field)
- status (mandatory field. can be active or deleted)
- date of creation (required field)

### The API must have the following endpoints:

1. /movie/add - adding a movie to the database
2. /movie/get - search for a movie by a unique identifier (Id).
3. /movie/search - search for movies by name, description, director or year of release.
4. /movie/update - updating the movie database
5. /movie/delete - delete the movie (soft delete)


### Add movie

The following conditions must be checked when adding a film:

- The name of the movie must not be empty
- Short description should not be empty
- Year of issue must be at least 1895
- The director field must not be empty

### Search

Search by title, description, director or year of release.

### update

When updating a movie, it should be possible to change the title, short description, release year and director fields.

### Delete

When deleting a movie, the status of the movie should be changed. It should not be physically deleted.
