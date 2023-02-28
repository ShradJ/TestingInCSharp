MSTest - 
   1. Create the blank project- Test project -  MSTest project - it brings most depenedencies needed. - both framework should be same. 
   2. NUnit - add NUnit test project. change default namespace to main project 
       there are a bunch of methods with assert statements whihc can be used to check variety of values, ranges etc. 
3. MOQ - for anything involved dependency injection- to run tests, we need fake objects of dependent interfaces or classess. To avoid this we use MOQ
     class to be tested must be tested alone. any depenedcies should not be included in testing. Mocking is replacing the actual dependecy, 
            with a test time only version that enables easier location of code that we want to test. 