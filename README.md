<h1>Encapsulation</h1>

One of the four pillars of object oriented programming, it refers to the bundling of data and methods that operate on that data into a single unit or class. It helps in protecting the internal state of an object from outside interference and misuse.

- Purpose
  - Ensures controlled access to the data
  - Protects object integrity by preventing unintended modifications
  - Make code easier to maintain and understand
 
- Real Life example
  - Think of a bank account. You can't directly access the balance `The balance is private` but you can deposit or withdraw money using specific methods `The public methods`. This ensures the balance is always updated correctly and is protected from unauthorized access.
 
- Access Modifiers
  - `Private`: Fields or methods that are `private` are only accessible in the same class.
    - ```private string name;```
  - `Public`: Fields or methods that are `public` are accessible outside of the class.
    - ```public string GetName(){ return this.name; }```
