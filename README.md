# SOLID Design Principles

## What is SOLID

- SOLID design principles are arguably the most popular design principles for OOP
- There are five design principles
    - Single Responsibility Principle
    - Open/Closed Principle
    - Liskov Substitution Principle
    - Interface Segregation Principle
    - Dependency Inversion

### Single Responsbility Principle
- A class should only have one responsibility. Only a single purpose.
- Microservices use single responsibility on the service level where it serves on specific purpose.
- **Benefits**:
    - Classes are easier to understand
    - Classes are easier to maintain
    - Classes are changed less frequently
        - Not all parts of the class will change when requirements change
    - Classes are easily and thoroughly testable

### Open/Closed Principle
- A class should be open for extension but closed for modification. 
- **Benefits**:
    - Not allowing modification provides the advantage of not introducing bugs
    - All dependent classes will not need to adapt
- If you are using an Interface, you are using Open/Closed principle

### Liskov Substitution Principle
- A subclass should be substitutable by its base class without having any negative impact to the caller. 
- **Benefits**:
    - Caller does not get surprising behavior when substitution applies
    - Complex bugs which might arise due to conflicting behavior between inheritance is easily avoided
- **Note**: This is not as common to be used as the other SOLID design principles

### Interface Segregation Principle
- Interface segregation principle is about separating interfaces. Essentially having multiple specific interfaces are better than generic single interface. 
- **Benefits**:
    - Easier to manage and maintain
    - Classes which implement interfaces are going to be smaller and more maintainable 

### Dependency Inversion Principle
- Classes should only depend on contracts, meaning interfaces or abstract classes rather than concrete implementations. 
- **Benefits**:
    - You can decide which implementation you pass
    - Unit testing becomes easier because instead of concrete classes we can mock them instead
