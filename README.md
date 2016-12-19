# sample-dnca2s

## Purpose
The purpose of this sample has several important parts:
  * It shows the Token Based Authentication using OWIN middleware pipeline with ASP.NET Core Web Api.
  * It provides the perfect playground to experience new technologies

## Technical details
We are going to use different tools and technologies. The system will be split into two:
  * Api: a RESTFUL Api providing the data(we are going to secure this)
  * Web: the Client of the Api which is going to present the information to the viewer(mainly build with Angular 2)

You can have a look at the **OAuth 2** standard that we'll be using [here](https://tools.ietf.org/html/rfc6749). We'll be using the **Resource Owner Password Credentials Grant** which is explained [here](http://tools.ietf.org/html/rfc6749#section-4.3).

Source code of the **OWIN middleware** aka ***Katana Project*** can be found on [codeplex](https://katanaproject.codeplex.com/SourceControl/latest#README).

### Technology stack
 * ASP.NET Core Web Api
 * ASP.NET Core MVC
 * OWIN, OAuth 2
 * HTML, CSS, Javascript
 * Angular 2
 * MsSql Server
 * Entity Framework Core
 * Bootstrap
