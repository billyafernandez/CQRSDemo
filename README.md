# CQRS Demo

## App Video Overview


[![CQRS Demo](https://i.ytimg.com/vi/11IEfYo8BRE/maxresdefault.jpg?time=1465857215805)](https://www.youtube.com/watch?v=11IEfYo8BRE)


## Backend

Create a SQL Server Database called CQRS_Demo and execute dbScript.sql.
In order to use the Twitter API, go to CQRS.Demo.Web.API project and edit the webconfig to add your twitter credentials (appsettings section).

## FrontEnd

This demo uses Angular 2 Front End and Angular Material 2. In order to install them, follow this steps:

Note: you will need to have node.js installed.

### Globally install Angular CLI
 
```bash
 npm install -g angular-cli
```
### Install Angular Material 2 components 

```bash
npm install --save @angular2-material/core
npm install --save @angular2-material/button
npm install --save @angular2-material/checkbox
npm install --save @angular2-material/grid-list
npm install --save @angular2-material/toolbar
```

### Install app dependencies:

```bash
npm install
```

### Then execute this command in your console to run your app:

 ```bash
 ng serve
  ```

### Follow the query process in the code:

#### Queries:
* Web API: request
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.Web.API/Controllers/TwitterController.cs#L28
* Web API: return query
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.Web.API/Application/TweetsService.cs#L42

#### Command:

* Web API: request
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.Web.API/Controllers/TwitterController.cs#L28
* Web API: send command request
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.Web.API/Application/TweetsService.cs#L28
* Command Stack Domain: command Event
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.CommandStack.Domain/Model/Events/TweetRequestCreatedEvent.cs#L11
* Command Stack Domain: raise uncommited command events
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.CommandStack.Domain/Common/Aggregate.cs#L41
* Infrastucture Persistence: save comand info to database
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.Infrastructure.Persistence.SqlServer/Repositories/TweetRepository.cs#L42
* Command Stack: raise created command event
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.CommandStack/Sagas/TweetSaga.cs#L41
* Infrastucture Persistence: event store (creates a log of events)
https://github.com/billyafernandez/CQRSDemo/blob/master/BackEnd/CQRS.Demo.Infrastructure.EventStore.SqlServer/Repositories/EventRepository.cs#L16
