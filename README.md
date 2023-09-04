
Application Description
In the ever-globalizing world, accessing and processing country-related data quickly and efficiently has become more important than ever. Our newly developed application serves as a powerful tool that facilitates seamless interactions with a vast array of country information, by leveraging the robust capabilities of the REST Countries API. Through a series of endpoints and functions, users can filter, sort, and paginate country data based on various attributes such as country name and population, catering to a wide array of user needs and data applications. The implementation incorporates cutting-edge technologies and follows best practices, ensuring a stable and responsive experience for all users.

Built with flexibility and ease of use in mind, our application introduces a series of endpoints capable of handling varying parameter inputs, ranging from zero to four in a single request. These parameters can be strings or numbers, allowing for versatile data querying and manipulation. The core functionalities include filtering countries by partial name matches in a case-insensitive manner, sorting them in ascending or descending order based on the common name, and filtering them based on population thresholds. Additionally, a pagination function facilitates data handling by limiting the number of records retrieved in a single request, thus making data management more streamlined and efficient.

How to Run the Application Locally
To run the application locally, follow these steps:

Clone the repository from GitHub to your local machine.
Navigate to the project's root directory in your terminal.
Install the necessary dependencies by running the command npm install or yarn install.
Start the application by running the command npm start or yarn start.
The application should now be running on your local server. Access the Swagger documentation to explore the available endpoints and their functionalities.
Run unit tests to ensure all functionalities are working as expected using the command npm test or yarn test.
Examples of Using the Developed Endpoint
Filter by Country Name:
GET /countries?name=st - Retrieves countries with names containing 'st', such as 'Estonia'.

Case-Insensitive Search:
GET /countries?name=sT - Retrieves countries with names containing 'st' or 'sT', like 'Estonia'.

Filter by Population:
GET /countries?population=10 - Retrieves countries with a population less than 10 million.

Sort by Name in Ascending Order:
GET /countries?sort=name&order=ascend - Retrieves countries sorted by name in ascending order.

Sort by Name in Descending Order:
GET /countries?sort=name&order=descend - Retrieves countries sorted by name in descending order.

Pagination - Limit Number of Records:
GET /countries?limit=15 - Retrieves the first 15 records from the API.

Combined Filter and Sort:
GET /countries?name=st&sort=name&order=ascend - Retrieves countries containing 'st' in the name and sorts them in ascending order.

Combined Filter and Pagination:
GET /countries?name=st&limit=10 - Retrieves up to 10 countries containing 'st' in the name.

Combined Sort and Pagination:
GET /countries?sort=name&order=descend&limit=20 - Retrieves the first 20 countries sorted by name in descending order.

Combined Filter, Sort, and Pagination:
GET /countries?name=st&sort=name&order=ascend&limit=15 - Retrieves up to 15 countries containing 'st' in the name and sorts them in ascending order.

Feel free to modify the endpoint examples to suit the specific functionalities and parameter combinations you've implemented in your application.


HOW TO USE/RUN THIS APPLICATION

Please do the following:

1. Clone this repo to some folder
2. Navigate to with-chat-GPT\AndriiKutenWithChatGPT sub-folder
3. Open AndriiKutenWithChatGPT.sln file
4. Press "Start without debugging" glyph or Ctrl + F5
5. https://localhost:7102/swagger/index.html will be open in default browser
6. Expand /api/Countries item
7. Click 'Try it out' and try to specify country, population, sort order and limit (all items except of sort order can be omitted)
8. Press 'Execute' button and observe results.
