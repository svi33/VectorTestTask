Task:

Use https://tarasmysko89.wixsite.com/vectortesttask01 
automate testing for the 1st form (id=”comp-jxd8gcbo”) using GUI automation (2-3 cases)
automate testing of 2nd form (id="comp-jxd8gc7s") via API (2-3 cases)
You can use any language, but we use C# on the project, everything else is up to you to choose
It is not about how fast you do it, it’s about quality and the code. 
We would like to receive the result from you as a shared repository on Github.
Ideally, it would be nice to see the history of commits to see the way you think, organize the code and improve it.
Some things that could help:
https://quicktype.io/csharp
https://medium.com/ 
https://www.google.com/ 
Add “--disable-blink-features=AutomationControlled”, in order to avoid reCapcha validation on site. https://stackoverflow.com/questions/53039551/selenium-webdriver-modifying-navigator-webdriver-flag-to-prevent-selenium-detec  
Ground Rules:
Usually, it takes up to 4 hours to complete the task, but we know it’s not the only thing you do. Please inform the Recruiter when you start working on it.



Solution:

Visual Studio 2019 Community was used to complete the task. 
Selenium-related Nuget libraries were also installed.
After testing:
1. The following form is available to fill in at the specified Internet address: 1st form (id = ”comp-jxd8gcbo”)
1.a)
significant fields on the form were checked using the "FindFirstFormTest" test.
Behavior meets expectations, except for the text on the button (in my opinion needs a fix John Now  in Join now).
using the "InputFirstFormTest" test checked the input to the fields and sending the form.
The blank form does not have proof of shipment, it is also partially filled in, which is expected behavior. 
The completed form gives a confirmation of sending that is OK. (confirmation time may require additional tests). 
Is don't use regex input checking, which I think needs fixing.

I tested only in chrome browser. I plan to use other browsers later.

1 b)
The following form is available to fill in at the specified Internet address:2nd form (id="comp-jxd8gc7s").
Similar  to previous tests ("InputSecondFormTest"), the form was excellent, expectations are confirmed.
API tests in development (not working just the moment).

