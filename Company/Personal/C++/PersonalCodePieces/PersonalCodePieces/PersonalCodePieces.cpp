// PersonalSampleCode.cpp : Defines the entry point for the console application.
// This is a test enviroment to verify and archive code for future reference and utilization
// The test menu enviroment is built to test several different programs in a single build

#include "stdafx.h"
#include <iostream>
#include <string>
#include <stdlib.h>

using namespace std;

int WelcomeSelection()
{
	cout << " 1) Hello world " << endl;
	cout << " 2) Ethernet Connection " << endl;
	cout << " 3) insert program " << endl;
	cout << " 4) insert program " << endl;
	cout << " 5) insert program " << endl;
	cout << " 6) insert program " << endl;
	int menuSelection = 0;
	cin >> menuSelection;
	return menuSelection;
}
void LineBreak(int numberOfLines)
{
	for (int i = 0; i < numberOfLines; i++)
	{
		cout << endl;
	}
}


int main()
{

	cout << " Personal Sample Code Testing Enviroment" << endl;
	cout << " Make menu selection" << endl;

	// Menu variables being defined
	int menuSelection = 0;
	int repeat = 0;
	int programContinue = 1;


	while (programContinue == 1)
	{
		menuSelection = WelcomeSelection();
		switch (menuSelection)
		{
		case 1: // Hello World
			cout << " Program 1) " << endl;
			do
			{
				cout << "Hello world as text out" << endl;
				string helloWorld;
				helloWorld = "Hello world as a string";
				cout << helloWorld << endl;
			} while (repeat == 1);
			break;

		case 2: // program 2 Name
			cout << " Program 2) " << endl;
			do
			{
				// insert program here
			} while (repeat == 1);
			break;

		case 3: // program 3 Name
			cout << " Program 3) " << endl;
			do
			{
				// insert program here
			} while (repeat == 1);
			break;

		case 4: // program 4 Name
			cout << " Program 4) " << endl;
			do
			{
				// insert program here
			} while (repeat == 1);
			break;

		case 5: // program 5 Name
			cout << " Program 5) " << endl;
			do
			{
				// insert program here
			} while (repeat == 1);
			break;

		case 6: // program 6 Name
			cout << " Program 6) " << endl;
			do
			{
				// insert program here
			} while (repeat == 1);
			break;

		default:
			cout << " Please select VALID program number" << endl;
			break;
		}
		cout << " Return to menu?" << endl;
		cout << " 1) yes 2) no " << endl << endl;
		cin >> programContinue;
		LineBreak(2);
		if (programContinue == 1)
		{
			LineBreak(5);
		}
	}

	cout << " Program Terminated" << endl << endl;
	system("pause");
	return 0;
}

