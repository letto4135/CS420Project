Class Project
-----------------------
Tasks
-----------------------
Task 1 - Due 10/28 - Create the object models that will be used for the events


Task 2 - Due 11/04 -
Work on Hostess/Host service
Publish: Reservation taken event - taken when a customer comes in Seated Table event - they filled a reservation
Consume: Table ready event - be able to add it to the open tables data, fill a reservation
Work on Waiter/Waitress service
Consume: Table ready event
Publish: Order taken






-----------------------
Requirements
-----------------------
- Hostess/Host - Microservice
	- Seat table
	- Take reservations
	- Events
		Published Events
		- Seated table
		- Reservation taken
		Consumed Events
		- Table ready
		- Seated table
- Waiter/Waitress - Microservice
	- Take order
	- Pick up order
	- Check on table
	- Tender the check
	- Events
		Published Events
		- Order taken 
		- Check paid 
		Consumed Events
		- Ready to pay
		- Order ready
		- Drink ready
- Bartender - Microservice
	- Pours drinks
	- Events
		Published Events
		- Drink ready
		Consumed Events
		- Order taken
- Kitchen/Chef - Microservice
	- Cook food
	- Complete order
	- Wash dishes
	- Events
		Published Events
		- Order ready
		Consumed Events
		- Order taken
- Bus Boy - Microservice
	- Cleans tables
	Published Events
	- Table ready	
	Consumed Events
	- Check paid


-------------------------------
Misc
-------------------------------
docker run -v rabbitmq-data:/var/lib/rabbitmq -d --restart always --hostname my-rabbit --name rabbit_dev -p 15672:15672 -p 5672:5672 rabbitmq:3-management

Access Rabbit at http://localhost:15672
