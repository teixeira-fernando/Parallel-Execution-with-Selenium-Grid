# Parallel-Execution-with-Selenium-Grid

Basic Project with a configuration for a parallel execution with Selenium Grid - Remote Web Driver

This project was created using C# and Visual Studio 2015. Selenium server version: 3.12.0

Some importants links:

1. Configuration of the hub and nodes:
https://www.softwaretestinghelp.com/selenium-grid-selenium-tutorial-29/
https://colinsalmcorner.com/post/parallel-testing-in-a-selenium-grid-with-vsts
https://seleniumhq.github.io/docs/grid.html
https://developers.perfectomobile.com/pages/viewpage.action?pageId=21435360

2. Driver Capabilities:
https://github.com/SeleniumHQ/selenium/wiki/Grid2
https://github.com/SeleniumHQ/selenium/wiki/DesiredCapabilities#read-write-capabilities


Command to initialize the hub: 
java -jar selenium-server-standalone-3.12.0.jar -role hub

Command to create a node that supports Chome, Firefox, IE and Opera:
java -jar selenium-server-standalone-3.12.0.jar -role node -hub http://localhost:4444/grid/register -browser "browserName=firefox, maxInstances=10, platform=ANY, seleniumProtocol=WebDriver" -browser "browserName=internet explorer, version=11, platform=WINDOWS, maxInstances=10"-browser "browserName=operablink, platform=WINDOWS, maxInstances=10"
