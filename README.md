# CQRS Demo

## App Overview

<center>
<iframe width="560" height="315" src="https://www.youtube.com/embed/11IEfYo8BRE?rel=0" frameborder="0" allowfullscreen></iframe>
</center>

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
