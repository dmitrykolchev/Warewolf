﻿@TestingFrameworkMocking
Feature: TestingFrameworkMocking


Scenario: Executing Release Tests for Hello World should all be passing
	Given The Warewolf Studio is running
	And I have Hello World workflow on the Explorer
	And I Open Explorer First Item Tests With Context Menu
	And I Click Run all tests button
	Then The First Test "Is" Passing	
	And The Second Test "Is" Passing	
	And The Third Test "Is" Passing	

Scenario: Creating A Test From Debug While Theres An Unsaved Test In The Tests Tab
	Given The Warewolf Studio is running
	And I have Hello World workflow on the Explorer
	And I Open Explorer First Item Tests With Context Menu
	And I Click The Create "4"th test Button
	Then I Open Explorer First Item Context Menu
	And I Press F6
	And I Click Create Test From Debug
	And Message box window appears
	And I Click MessageBox OK 
	And Test tab is open
	And I Click Close Clean Workflow Tab
	And I Click EnableDisable Test 4, dirty "true"
	And I Delete Test "4"
	And I Click MessageBox Yes

Scenario: Run Test Then Edit The Workflow Sets The Test To Invalid
	Given The Warewolf Studio is running
	When I Run All Hello World Tests
	And I Open Explorer First Item With Double Click
	And I Enter "Hello There World" in the Assign message tool
	And I Click Save Ribbon Button Without Expecting a Dialog
	And I Open Explorer First Item Tests With Context Menu
	Then The First Test "Is" Invalid