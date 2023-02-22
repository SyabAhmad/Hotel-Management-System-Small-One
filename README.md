# Hotel-Management-System-Small-One
Hotel-Management-System-Small-One

You have to develop a restaurant order payment application. For Example, your restaurant is offering the following meals.

![image](https://user-images.githubusercontent.com/81256221/205335792-70403b39-f8bb-4503-86f4-aa6beb989a72.png)


Your program should print the name of dishes along with their corresponding codes so that a user can select one of the dishes
by using its code. For example, if the user selects code 1, then it means Chicken Polao, 2 means Rice, so on and so forth.
If the user has entered an invalid code, your program will print some error message and terminate. After the user has been asked
the dish that he wants to buy, your program will ask the user to enter the quantity of the dish that he wants to buy in kilograms.
The quantity will be greater than 0. If the user has entered an invalid quantity, then print some error message and terminate the program.
After that, the program should ask from the user about currency in which he/she wants to give payment. For this assignment, you are
required to use three currencies. One is Pakistani rupee, second is dollar and the last one is euro. Use 1 for Pakistani rupee,
2 for euro, and 3 for dollar. If the user has entered an invalid option, then your program will print some error message and terminate.
After that, your program will calculate the meal price, sales tax on the meal price and total price of the meal
(calculated after adding meal price and sales tax). For calculating sales tax, you can use meal price in rupees which is hard coded
in this case, and calculate sales tax on it using the table given below.

![image](https://user-images.githubusercontent.com/81256221/205335966-731c41aa-7a4f-4664-a578-30b9ac9ea17e.png)

After calculating the sales tax, the program will calculate the total amount or price payable by using the following formula:

![image](https://user-images.githubusercontent.com/81256221/205336075-b4f957d3-cbe7-42a1-8f1f-2e13a67696fa.png)

Hint: You can calculate everything in Pakistani rupees, and then convert them into the desired currency. After calculating the
total amount in rupees, you are required to convert the amount into the desired currency (based on the user’s choice). For example,
if the user selected rupees, then simply display final price, i.e., (Total Amount = Meal_Price + Sales_Tax) in rupees but if the user
selected dollar or euro, then
simply convert the final meal price that you calculated earlier (in rupees) into dollar or euro according to the currency exchange rate.
Also display the amount of sales tax and the meal price excluding sales tax.
Note: Use current exchange rate for this assignment as given below:

![image](https://user-images.githubusercontent.com/81256221/205336021-6227f82d-77e1-47a7-a697-db4fa4370eda.png)
