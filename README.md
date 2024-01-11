Project was developed utilizing onion architecture. Command query responsibility segregation (CQRS) design pattern and repository design pattern have been applied. EF Core has been integrated into the project as ORM tool. Microsoft SQL Server is being used to manage the database. There exists a command for adding products, a query to present a list of all products, and another query designed to list products based on their names. The MediatR library was utilized within the implementation of the CQRS design pattern to establish loosely coupled communication from a single point between command query models and the classes responsible for executing operations by handling these models. The authentication process was conducted using the Jwt token structure.