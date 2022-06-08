# SharpScape

An online multiplayer community

---

## Repository Overview

`Website/`: Contains the Blazor front-end project files for the web application that users will interact with.
 - This project's root namespace is `SharpScape.Website`.

`Api/`: Contains the ASP.NET Core web API project files for the backend that will serve the website and the game.
 - This project's root namespace is `SharpScape.Api`.

The game project files have not yet been created.  There are two reasons for this delay:
 - We have not reached an opinion on game engine.  Since the game will be a relatively simple project (as far as video games go), and will need to execute in WebGL, the two best contenders are [Unity](https://unity.com) and [Godot](https://godotengine.org).
 - The game engine will generate its *own* Solution file for the game project.  It will also be *loosely* coupled to our API, so I am unsure as to whether its project files should be included in this repository, or in a separate repository.

## Contributing

Only members of the Summer 2022 Quintrix .NET Cohort may submit contributions to this project.

Initial instructions for cohort members:
 - Fork this repository and clone your fork.  Your fork's URL will be known to git as `origin`.
 - Add *this* repository URL to your git remotes as `upstream`.

From then on:
 - Create a new branch for ***each*** feature you work on, and make your commits to each feature's respective branch.
 - Make sure your branch is up-to-date by pulling `upstream/master` into your feature branch.
 - Push your new branch to your `origin`.  Do not merge it into your `master` branch.
 - Pull-request your feature branch against this repository's `master` branch.
