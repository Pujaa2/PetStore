
<h3>

Software 1 - Class Exercise 1
Goals
Create the base classes for the store.
Interact with the classes by making some objects and running basic logic on them.
Learn how to make a console app wait for certain inputs before exiting a loop.
Instructions
Create a new console app in Visual Studio. Make sure to give the solution a good name and make sure you create the solution in place that you can find it later.
Add a class to your project called Product. This class will be what's called a base class or a parent class. This will be the most basic class that all product classes will inherit from.
Add the following properties to your new class.
Name - Type string
Price - Type decimal
Quantity - Type int
Description - Type string
Add another class called CatFood. Make this class inherit from the base class Product.
Give CatFood a few Properties.
WeightPounds - Type double
KittenFood- Type bool
Make another class called DogLeash and have it inherit from Product as well. Give it a the following Properties
LengthInches - Type int
Material - Type string
Now we want to get this console app to run until the user decides to end it. We will do this by using a while loop. Loops require 3 things: an inital condition, check in condition, and a change in condition. Our inital condition is going to be our first input from the user. Our check is what is in the while loop. Our change is going to be what the user inputs after an action has been complete. So, let's get started with the initial condition.
At the top of the files, add the following lines: Console.WriteLine("Press 1 to add a product"); and below that add Console.WriteLine("Type 'exit' to quit");.
Add this line of code below what you added in step 11 string userInput = Console.ReadLine();. This will get what the user enters before hitting enter.
Now add your while loop. The condition in the loop should be something like this: userInput.ToLower() != "exit". We use the method ToLower just in case the user enters "Exit" instead of "exit".
Inside the brackets for the while loop, at the end, add this line userInput = Console.ReadLine();. This is our change in condition. We will add code before this though, so it will make more sense after that. Add the instructions for the console app above that line again: Console.WriteLine("Press 1 to add a product"); and Console.WriteLine("Type 'exit' to quit");.
Inside of the while loop, above the what you added in the previous step, add an if statement. This if statment will check the input of the user a second time to see if they wanted to add a product. We told them to enter "1" to add a product, so check for that in the if statment. Remember, the input is a string type, not an int.
Create a new object. It should be CatFood or DogLeash, not the base class Product. Note: remember to add a using statment so that the Program class knows where to find your class.
Since we don't really have a database, when we add a product, we're going to just create that object and print it to the console. Use Console.Write() and Console.ReadLine() to get data from the user and then add it to the object you just created. Since some of the types aren't going to match, you will need to convert them using the target types Parse method. So to turn a string to an int, use int.Parse().
To make printing the object easier, we'll use the JsonSerializer class. You don't need to know all the ins and outs of how this works right now, but basically it will just convert our object to a json object. Add the following line to your code: Console.WriteLine(JsonSerializer.Serialize(dogLeash));. You will replace dogLeash with whatever you named your object.
Now, all you have to do is test it! Run the application and see if everything works properly.

Software 1 - Class Exercise 2
Goals
Learn how to use the 2 most commonly used collections: List and Dictionary.
Instructions
In the last exercise, we added a function to add a product to store. I this exercise, we're going to expand on that as well as add a new function to view our product list.

We're going to add a new class to handle all of our product functionality. Add a new class called ProductLogic.
In this class, add a new private variable called "products" of type List<Product>. Remember to add an underscore _ before the name because it's a private variable.
Create a constructor for the class and in that constructor, create a new instance of the list class. It should look something _products = new List<Product>();
Create a new function/method called AddProduct. It should have no return type (so it'll return void) and accept one argument called "product" and it should be of type Product. So the method will look like this: public void AddProduct(Product product)
In that method, use the _product variables Add method to add the method's argument to the private list.
Next create another method called GetAllProducts. The method's return type will be List<Product> and will have no arguments. This method will be really simple, all you have to do is return our private variable: return _products.
Back in our main "Program" class, we're going to create an instance of our new ProductLogic. Make it a variable at the top of the file under the using statments. var productLogic = new ProductLogic();
Replace the line where we are serializing the product that the user is creating with the AddProduct() method and pass the product the user created into the method.
After adding the product, add a nice message below it to let the user know that the product was added.
Our next major thing to add will be some dictionaries to hold our specific types of products. So back in ProductLogic, add 2 more private variables. The first will be of type Dictionary<string, DogLeash> and the second will be Dictionary<string, CatFood>. The string is the key and DogLeash/CatFood are the types of objects being stored in the Dictionary. I'll let you choose some names for these variables.
Now, in AddProduct add an if statement. It's condition will check for the Type of object. If it's a DogLeash it will be added to the dog leash dictionary. If it's a CatFood object, it will be added to the cat food dictionary. The key will be the product's name value. So an if statement will look like this: if (product is DogLeash).
Inside of this if statement, use the correct dictionaries Add method to add the product to it. Note: you will probably have to convert the product to the correct child class using the as keyword. That would look like this: product as DogLeash.
Add another if block that does the same thing except for CatFood instead of DogLeash.
Add another method called GetDogLeashByName it will have a return type of DogLeash and will have one argument of type string called "name".
This method will use the indexing brackets [] to use the name key being passed in to return the object with that key in the dictionary. That would look like something this: return _dogLeash[name].
Back in the program class, add a new option for the user. It will be option number 2 and will let them get a specific object out of the list. Since they're only adding a dog leash right now, we're going to just let them view a dog leash as well. Use option number 1 as a template for what you need to do right now and only use the soultion when you get stuck.
All you have left to do now is test your program to make sure it's working!


Software 1 - Class Exercise 3
Goals
Learn how to handle exceptions
Implement some OOP principles in your program.
Instructions
Error Handling
Run your program and add a product. Now use option 2 to get a product that doesn't exist. The program should have thrown an error and completely stopped. You generally don't want these kinds of things happening so let's add some error handling to our program.
In the ProductLogic class in the GetDogLeashByName method, wrap return _dogLeash[name]; with a try block. Wrap is a pretty common term that means basically "put inside of the curly braces".
After the try block, add a catch block. The catch keyword takes one argument and that has to be an Exception. This is a pretty standard way of writing a catch: catch(Exception ex). What you do inside of the catch block is really up to you and dependent on the situation. In ours, let's just return null and account for that in the class that uses the method.
Back in our Program file, check the result of GetDogLeashByName to see if it's null using an if/else statment. If it is null, write a message saying that the product couldn't be found. If it isn't null have the program do what it was doing before.
OOP Principles
You will need to work together with someone on this part, so find one or two people close to you OOP Principles:

encapsulation
abstraction
inheritance
polymorphism
We'll first look at encapsulation. In our program we've encapsulated our product specific logic in our ProductLogic class. Talk with someone else about why you think this could be helpful as the program gets larger. It is totally okay to look it up on the internet!
Next is abstraction. Abstraction will be expanded on much more in next weeks exercise, but for now discuss with someone what it means and how think it might be used in the future in the Pet Store application.
Inheritence is something you've already used. It is easier to understand using the "is-a" terminology. So Cat Food is a product. A dog leash is a product. Let's take this one step further and add one more level of is-a. Add a new class called DryCatFood and have it inherit from CatFood. Let's move the Weight property over to this new class since that would belong more in the dry cat food than it would in something like canned cat food.
Polymorphism was used in the AddProduct function. Discuss with someone how this is using the polymorphism principle.
</h3>
