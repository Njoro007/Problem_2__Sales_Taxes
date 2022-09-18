# Problem 2: Sales Taxes - Printing receipt details for shopping baskets
<hr/>

<h2> Environment </h2>

<p>
	This Assessment Test was implemented using Visual Studio 2022 Community IDE, .NET 6 and C# Language
</p>


</hr>

<h2> Approach </h2>

<p>
	My approach to this problem was first to identify possible subroutines that may be required
	to be executed at any point of the program.
</p>
<p>
	Subroutines identified or implemented in this assessment are categorized and organized by topic into classes.
</p>
<p>
For this Problem Assessment 2 (Sales Tax), classes are: </br>
1.	RoundFigures – This class contains methods that return different values of rounded figures and arguments that fill equations of a formula for the method to complete its task.</br>
2.	Tax – This class contains methods, each with different tax formulas.</br>
3.	AppData – This class contains properties of different types of data and their data types required to complete the sales tax application.</br>
</p>

</hr>

<h2> Design Patterns </h2>

<p>
	The different types of programming syntax and design patterns used in the sales tax application are: </br>
	1.	The use of Lists and LINQ to handle CRUD operations </br>
	2.	The use of Custom Library </br>
	3.  Unit Tests 
</p>


</hr>


<h2> Class Library </h2>
<p>
Project Name: <i>AccountsLibrary</i> <br/>
<br/>
The use of a Custom Library would be recommended for such an application where it can scale up the number of 
subroutines that handle tax rules and can change overtime. Class Library is being added as a dependency to 
the main console application project. Which will make it possible for multiple programmers to work on
the library, code reuse, source control and code readability. 
</p>

</hr>

<h2> Unit Test </h2>


<p>
	Project Name: <i>AccountsLibraryTests</i> <br/>
	Testing Tool: <i>MSTest</i>
</p>

</hr>

<h2> Run </h2>

<p>
<h3> On Windows Platform </h3>
	Run Exe: Inside <i>App Run</i> Folder run the exe file
	Visual Studio: Run  Application from Visual Studio 2022
</p>
<p>
<h3> On MAC </h3>
	Visual Studio: Run  Application from Visual Studio 2022
</p>