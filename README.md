# EurofinsCodingTask

Eurofins Coding Task:

Basic brief

Create an ASP.Net MVC or ASP.NET Core MVC web application that includes a page that will display on screen the numbers from 1 to 100 (by default), but for multiples of 3 display “Three” instead of the number, and for multiples of 5 display “Five”. For numbers which are multiples of both 3 and 5 display “Eurofins”. 
The start and end number should be customisable by the user, e.g. there should be two form fields (one for the start number and one for the end number). If no start number is explicitly provided it should default to 1. If no end number is provided it should default to 100. 

Bonus: 
Each time the action method is called the start number, end number and the date/time of the call should be stored in a database. Use EF code first for this.

Other considerations:

•	The logic to determine the text to display based on the number input may need to be reused in other areas of the application in the future, this should be considered in the design.

•	Text on the web page should be updated without causing a full page refresh

•	Any server-side code should be written in C#. Client-side code should be written in JavaScript (including any client side libraries you wish to use). 

•	The look and feel of the web page should be considered as an opportunity for you to demonstrate your design skills.

