# Plugin Framework - Image Manipulation

## Description
This project demonstrate a simple image manipulation plugin framework which was given as a SSE technical test at Moresand Technologies (Backend only). 


This project is a simple application of image manipulation plugin framework. 

- No UIs have been developed. 
- Only the plugin structure has been considered. 
- No actual implementation. 
- Dummy data has been provided.
- Decorator design pattern concept has been considered.


Main features implemented are;

- Allows handling of multiple images at once, each one with its desired effects.
- Allow multiple effects for each of the photos.
- Effect might have one parameter which can be of different kinds (a value slider/ selector, numeric input box,...), but it's optional
- Allows adding/removing plugins (by plugin we assume a specific image operation, like Adobe Photoshop effects and filters) without touching the code of the rest of the application.

## How to Add New Plugin
- Create a new class for the required plugin
- Extend that class from *PluginDecorator* class.
- Implement the methods accordingly.


## Requirements 
- .Net 6

## Installation
1. Clone the repo and install the dependencies.
```bash
$ git clone https://github.com/devni-heraliyawala/plugin-framework.git
$ cd news-hub-backend
