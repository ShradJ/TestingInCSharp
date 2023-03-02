MSTest - 
   1. Create the blank project- Test project -  MSTest project - it brings most depenedencies needed. - both framework should be same. 
   2. NUnit - add NUnit test project. change default namespace to main project 
       there are a bunch of methods with assert statements whihc can be used to check variety of values, ranges etc. 
3. MOQ - for anything involved dependency injection- to run tests, we need fake objects of dependent interfaces or classess. To avoid this we use MOQ
     class to be tested must be tested alone. any depenedcies should not be included in testing. Mocking is replacing the actual dependecy, 
            with a test time only version that enables easier location of code that we want to test. 
            ** note** - Don't use mock when its not needed. for example if there was no dependency injection, then don't make interfaces just for Mocking. 
            Its called Abuse of Mocking. 
           ** To test a method which returns a value based on a condition we can use 2 separate methods each with a mock setup to satisfy the individual condition. 

           ** we can also test the output variable [void xy( out int x)], by putting out in MOQ setup 
           ** Above same as for "ref" objects too. 
 4.XUnit - Concept is same as NUnit, but annotations are different. 
 ** NUnit covers maximum feature, then XUnit, and least are MSUnit. 