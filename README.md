# PROGpart1
Readme File for Recipe Management System

This readme file provides an overview of the code provided and explains how to use the Recipe Management System.


Code Overview

The provided code implements a Recipe Management System that allows users to create and manage recipes. It consists of three main classes: Ingredient, Step, and Recipe. Here's a brief description of each class:


Ingredient: Represents an ingredient used in a recipe. It has properties for the ingredient's name, quantity, and unit of measurement.

Step: Represents a step or instruction in a recipe. It has a property for the step's description.

Recipe: Represents a recipe. It has private fields for an array of ingredients and an array of steps. The class provides several methods to interact with the recipe, including adding ingredients, adding steps, displaying the recipe, scaling the recipe by a factor, resetting ingredient quantities, and clearing the recipe.


The Main method in the Program class serves as the entry point of the application. It creates an instance of the Recipe class, prompts the user to enter the number of ingredients and steps, and calls the corresponding methods to add ingredients and steps to the recipe. Finally, it displays the recipe.


How to Use the Recipe Management System

To use the Recipe Management System, follow these steps:


Run the program by executing the Main method in the Program class.

Enter the number of ingredients when prompted. Each ingredient requires a name, quantity, and unit of measurement. Enter the information for each ingredient as requested.

Enter the number of steps when prompted. Each step requires a description. Enter the description for each step as requested.

After entering all the ingredients and steps, the program will display the recipe, listing all the ingredients and steps.

You can perform additional actions on the recipe based on user input. The available actions are scaling the recipe by a factor, resetting ingredient quantities to their original values, and clearing the recipe to start a new one. The program will prompt for user input to perform these actions.


Additional Information

The ScaleRecipe method allows you to scale the quantities of all ingredients in the recipe by a given factor. For example, if you enter a factor of 2, all ingredient quantities will be doubled.

The ResetQuantities method is currently not implemented in the provided code. You can implement it to reset all ingredient quantities to their original values.

The ClearRecipe method is also not implemented. You can implement it to clear all the data in the recipe, allowing the user to enter a new recipe.


Conclusion

The Recipe Management System provides a basic framework for creating and managing recipes. By following the steps outlined above, you can easily create recipes, view their details, and perform various actions on them. Feel free to modify and expand the code to suit your specific requirements.





