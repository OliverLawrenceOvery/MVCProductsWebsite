# MVCProductsWebsite

# Introduction

This is an ASP.NET MVC application created in Visual Studio which has user login functionality through MySQL, with CSS and React used for the front-end.

## Table of Contents
- [Installation](#installation)
- [Features](#features)

## Installation
Ensure that a MySQL connection is set-up, and create an arbitrary database which will contain seperate tables for products and user credentials. The syntax for the product table is shown below:
```shell
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductClass] [nvarchar](50) NULL,
	[ProductModel] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
	[Supplier] [nvarchar](50) NULL,
)
```
Insert some product records to be displayed by the application. User functionality is implemented using two tables: one table to record the username, password and role ID, and another table which dictates the user role that a roleID corresponds to. 
Hence there is a foreign key relationship between the 'roleID' columns present in both tables. The role ID is used to check if the user has permission to view the products page, and the 
code to create both tables is shown below:
```shell
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
)
```
```shell
CREATE TABLE [dbo].[UserRole](
	[RoleId] [int] NOT NULL,
	[RoleName] [nvarchar](50) NULL,
)
```
Insert role ID's of '1', '2' and '3' corresponding to rolename's of 'Admin', 'Manager', and 'User', and insert user credentials into the 'Users' table as desired. Once all tables are created, update model 'ProductsModel.edmx' from database.
## Features

This application allows the user to login with existing credentials or register with new credentials if no account currently exists. Note that user-created accounts 
by default will be given the role of 'User' and as such do not have access to the list of products. You must insert a record with rolename of 'Admin' in order to view 
the products list upon logging in.
