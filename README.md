# Travel Explorer (service-oriented architecture)

## Overview 

In this project, we have evolved the initial monolithic [Travel Explorer application](https://github.com/petrovicmilica/travel-explorer-backend/blob/master/README.md) into a sophisticated service-oriented architecture. This transformation aims to improve scalability, maintainability, and flexibility by breaking down the application into distinct, loosely-coupled services. Each module of the application now operates as an independent microservice with its own logic and responsibilities.

## Technologies 
- Initial monolithic application: C# with .NET (ASP .NET) + relational database (PostgreSQL)
- Front-end: Angular + REST services
- Microservices:
    - Tours: Golang + relational database (PostgreSQL)
    - Encounters: Golang + document-oriented database (MongoDB)
    - Followers: Golang + graph database (Neo4J)
 
## Getting started

To set up the project locally using Docker, follow these steps:

1. Clone the repository
2. Run the entire setup using Docker Compose

- Ensure Docker and Docker Compose are installed and running on your machine
- Use the provided docker-compose.yml file and docker-compose-migrations.yml file to manage the services
- To build and start all services:
```
docker-compose up --build
```
- To stop all services:
```
docker-compose down
```
Use appropriate tools like pgAdmin and MongoDB Compass to interact with the database.

## Configuration

Make sure to review the docker-compose.yml file and Dockerfiles for specific configuration details, such as environment variables, volume mounts, and network settings.

Check the port mappings in docker-compose.yml to ensure that services are properly exposed and accessible.

You can download the files from [this link](https://ufile.io/f/ud3nw). If you are unable to do so, please contact me via email.

## Contributors
[Milica Petrović](https://github.com/petrovicmilica)

[Ana Radovanović](https://github.com/anciii13)

[Kristina Zelić](https://github.com/zelick)

Petar Kovačević
