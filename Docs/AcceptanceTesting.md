# Acceptance Testing

Automated Acceptance/Approval testing is a common technique that adds a quality gate to your system. You test 
your entire system from a known set of results to ensure that modifications made to the system did not change
the expected result. A great example of this is using Golden Master to refactor legacy systems with no tests
at all.

## Dot net tools for approval testing

Approval testing is common in all technology so each and every one of them has its own tools to deal with 
the matter. At dot net ecosystem there is a great nuget package called [ApprovalTests.Net](https://github.com/approvals/ApprovalTests.Net)

### How to use approval test net

Write your regular test, but at the end instead of Assert use:

```xUnit
var myVerify = "I like to eat eggs for breakfast";
Approvals.Verify(myVerify)
```

Run the test and you will see two files auto generated:
* YourTestNameHere.recieved.txt 
* YourTestNameHere.approved.txt 

Your approved file should be empty. On the first run if you are happy with your content, copy de content of **YourTestNameHere.recieved.txt** 
inside of **YourTestNameHere.approved.txt**, rerun your test, and now it passes.
This two files exist so you can compare them side by side with a Diff tool and see what has changed.
Happy approval testing.