# elastic-user-service
A small full stack app utilizing ElasticSearch to search through a list of users

## Requirements 

 - Docker
 - .Net 6
 - NPM

## Tech Stack

 - ElasticSearch & Kabana
 - .Net 6 using Mediator 
 - React & Vite

## How to run 

 - Open a CLI in the root directory
 - Run `docker compose up -d` (-d is optional but it retains your terminal)
 - Run `inflate-elastic-data.bat` This will populate the ElasticSearch instance with some test data
 - Either run `dotnet watch ./src/UserService/UserService.Api.csproj` or open `./src/UserService/UserService.sln` in Visual Studio
 - Navigate to `./src/react-user-search` and run `npm i` then `npm run dev`
 - Boom. Ye should now be looking at the single most visually unappealing website since folk could make Piczo sites

## TODO

 - Unit testing ... this just isn't here and I was hoping to get to it
 - E2E testing, same as above
 - Some form of styling. CSS takes time! 
 - More fleshed out CRUD operations. This is the lowest hanging of the fruit