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

Run the test, then a new file gets generated  **YourTestNameHere.recieved.txt** if you are happy with your content rename the file to **YourTestNameHere.approved.txt** so now you have your expected result.

Every time that you run the test if there is a difference between the test outcome and the approved file, a new **YourTestNameHere.recieved.txt** will be generated for you so you can compare the differences among the two in a Diff tool.

Happy approval testing.
