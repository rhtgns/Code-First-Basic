This project implements the Code First approach using Entity Framework Core to create a database for managing users and their posts. The following tables are defined:

User Table:

Id: int, primary key, auto-incremented.
Username: string, the user's username.
Email: string, the user's email address.
Post Table:

Id: int, primary key, auto-incremented.
Title: string, the title of the post.
Content: string, the content of the post.
UserId: int, foreign key referencing the author of the post (the user's ID).
Relationships:
A user can have multiple posts, but each post belongs to only one user. This one-to-many relationship is established in the PatikaSecondDbContext class, which handles database configurations and relationships.
Database Context:
The context class is named PatikaSecondDbContext, and the database is named PatikaCodeFirstDb2. It contains the configurations for the Users and Posts tables.
Tools and Technologies:
The project utilizes Entity Framework Core for data access, and migrations are used to create and update the database schema.
