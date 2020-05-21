# Dependency Injection for .Net Framework and .Net Core

This is simple Depencency Injection with no database just seeding with normal list.

### Solution Structure

-  DI.Common - Class Library(.Net Standard) 
											- a class library that can be references both on .Net Core and .Net Framework.
										    - This class have Product Entity and Repository(Interface and class) 
-  DI.Framework.Core 
				  - A .Net Framework class library for Product Entity Repositories.
				  - The Respository classes inherit from DI.Common generic classes.
- DI.Framework.ConsoleApp 
						- A .Net Framework Concole app for testing dependency injection using Autofac

- DI.NetCore.Core
				- A .Net Framework class library for Product Entity Repositories.
				- The Respository classes inherit from DI.Common generic classes.
- DI.NetCore.ConsoleApp
					  - A .Net Core Console App for testing Dependency Injection using Microsoft.Extensions.DependencyInjection



![Image of Testing]
(https://github.com/Menelis/DI/blob/master/DI.Common/images/test.PNG)