# CodeShare

**Consideration and Decisions**

Reusability

    Application components should be designed and developed in a way that those components should be re-suable in the future projects.
    
    Code
      •	Interfaces must be designed in such a way as to maximize its ability to be reused to implement certain patterns. 

SOA Architecture 

    •	Application is based on the service-oriented architecture with REST API. So, system can be easily extensible and adaptable with other systems or technologies.
    
Extendibility

    The system is extendable due to the de-coupled architecture. The effort of adding new services or application would not require major changes to the architecture.
    
    
**Limitations**

If we keep json file scalability would be an issue. Mainly if we start writing to the file. Also, the performance would rely on reading the file and processing it. 


**Design Patterns**

Repository Design Pattern is used to separate the actual database, queries, and other data access logic from the rest of the application. Business logic can access the data object without having the knowledge of the underlying data access architecture. 


**Future Enhancements**

Authentication and Authorization

  • A custom middleware to validate calls to make sure data is only accessible by the correct person.

Adding a Cross Cutting layer to handle logging and error handling.

Caching.

